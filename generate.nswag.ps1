[CmdletBinding()]
param(
    [bool] $JsonManipulation = $true,
    [bool] $CleanUpCode = $false,
    [bool] $BuildAfterGeneration = $true
)

# Timer
$sw = [System.Diagnostics.Stopwatch]::StartNew()

#
# Sanity checks
#

# NSwag
if (!(Get-Command 'nswag' -ErrorAction SilentlyContinue)) {
    # TODO install nswag
    Write-Error "Cannot find command 'nswag' which is required for generation."
    return
}

#
# /Sanity checks
#

# 
# git clean -xdf .
git clean -xdf docs
git clean -xdf src

# Output settings
$outDir = $PSScriptRoot
Write-Verbose "Using `$outDir: $($outDir)"

# # Purge output directory
# if (Test-Path $outDir) {
#     Write-Verbose "Purging directory '$outDir'."
#     Remove-Item -Recurse -Force $outDir -ErrorAction SilentlyContinue
# }
# Write-Verbose "Creating directory '$outDir'."
# mkdir $outDir -ErrorAction SilentlyContinue | Out-Null

# # Copy ignore file
# Write-Verbose "Copying swagger-codegen-ignore file."
# $ignoreFileName = '.swagger-codegen-ignore'
# Copy-Item -Force $( $PSScriptRoot + '\' + $ignoreFileName) $($outDir + '\' + $ignoreFileName) -ErrorAction SilentlyContinue | Out-Null

#
# JSON Manipulation
# 
# NB: Currently the marqeta-core-api/v3/swagger.json does not play with swagger-codegen
#       Temporary measure to fix it. (Removing all instances of commando)
#
$defaultJsonUri = 'https://shared-sandbox-api.marqeta.com/v3/swagger.json'
if ($JsonManipulation) {
    Write-Verbose "Capping 'maxItems' values to 500."
    $defaultJsonPath = './swagger.json'

    if (!(Test-Path $defaultJsonPath)) {
        Write-Verbose "Downloading '$defaultJsonUri'."
        Invoke-WebRequest -Uri $defaultJsonUri -OutFile $defaultJsonPath

        Write-Verbose 'Massaging JSON.'

        # Remove diacritics
        Write-Verbose 'Removing diacritics.'
        (Get-Content -Path $defaultJsonPath).Replace("é", "e") | Out-File -Encoding utf8 $defaultJsonPath

        # NB: We need to use the .NET JavaScriptSerializer because the build in powershell one cannot handle IDs with the same name but different casing
        [void][System.Reflection.Assembly]::LoadWithPartialName("System.Web.Extensions")
        $jsonObject = [System.Web.Script.Serialization.JavaScriptSerializer]::new().DeserializeObject((Get-Content -Path $defaultJsonPath))

        # Title
        Write-Verbose "Adding 'title' property."
        $jsonObject.info.title = 'Marqeta Core Api'

        # NB: We change the max items due to a bug in swagger-codegen
        #       https://github.com/swagger-api/swagger-codegen/issues/6394
        Write-Verbose "Removing large 'maxItem' properties."
        $newMax = 500
        $jsonObject.definitions["auth_user_request"].properties["roles"].maxItems = $newMax
        $jsonObject.definitions["auth_user_update_request"].properties["roles"].maxItems = $newMax
        $jsonObject.definitions["commando_mode_enables"].properties["velocity_controls"].maxItems = $newMax

        #
        # Enum
        #       
        Write-Verbose "Removing problematic enums."
        Import-Module "$($PSScriptRoot)\HelpersModule.ps1" -Force
        $delegate = {
            param (
                [string] $PropertyName,
                [object] $JsonObject
            )

            # Early out if null
            if ($null -eq $JsonObject) { return }
            $value = $JsonObject[$PropertyName]
            if ($null -eq $value) { $value = $JsonObject.$PropertyName }
            if ($null -eq $value) { return }

            # If object is an array, recurse through array
            switch ($JsonObject.GetType().ToString()) {
                'System.Object[]' {
                    $JsonObject | ForEach-Object { Invoke-DelegateOnJsonNodeWithProperty -PropertyName $PropertyName -Delegate $Delegate -JsonObject $_ }
                    return
                }
            }

            #
            # Object is not an array so process object
            #

            # Blacklist - Remove enum value if it contains any of the following patterns
            $blacklist = @(
                '*Authentication*',
                '*char max*',
                '*chars max*',
                '*createdTime',
                '*created_time',
                '*user_transaction_time',
                '*max char*',
                '*max chars*',
                '*Must be * char*',
                '*Payment card or ACH account number*',
                '*Required if*',
                '*String representing batch id*',
                '*Strong password required*',
                '*Valid URL*',
                '*yyyy-MM-dd*'
                '*yyyyMMdd*'
            )
            foreach ($pattern in $blacklist) {
                if ($value -like $pattern) {
                    $JsonObject.Remove($PropertyName) | Out-Null
                    return
                }
            }

            # Arrays
            switch ($value.GetType().ToString()) {
                'System.Object[]' {
                    if ($value.Length -eq 1) {
                        $delimiters = @('|', 'or', ' ')
                        $value1 = $value[0]
                        foreach ($delimiter in $delimiters) {
                            if ($value1.Contains($delimiter)) {
                                $newValue = $value1.Split($delimiter).Trim()
                                $JsonObject[$PropertyName] = $newValue
                                break
                            }
                        }
                    }
                    else {
                        $value1 = $value -like '*|*'
                        if ($value1) {
                            $newValue = $value1.Split('|').Trim()
                            $JsonObject[$PropertyName] = $newValue
                        }
                    }
                }
            }

            # If the above manipulation has reduced the array to one or less items, remove it
            $value = $JsonObject[$PropertyName]
            switch ($value.GetType().ToString()) {
                'System.Object[]' {
                    if ($value.Length -le 1) {
                        $JsonObject.Remove($PropertyName) | Out-Null
                        return
                    }
                }
            }

            # Regex
            # Delete unsavory content within enumerations
            $regexes = @(
                [regex]::new("(\(default[ = ]*[0-9A-Za-z_]*\))")    # (default*)
                , [regex]::new("[^0-9A-Za-z_.]*")                   # Non alphanumeric characters - This should be done last
            )
            $newValue = $value `
            | ForEach-Object { 
                # Run each regex on the object and return it
                foreach ($regex in $regexes) { $_ = $regex.Replace($_, "") }
                $_
            } `
            | Where-Object { ![string]::IsNullOrWhiteSpace($_) } `
            | ForEach-Object { $_.Trim() }
            $JsonObject[$PropertyName] = $newValue
        }
        Invoke-DelegateOnJsonNodeWithProperty -PropertyName "enum" -Delegate $delegate -JsonObject $JsonObject
        #
        # /Enum
        #

        #
        # Remove operation ids
        #
        Write-Verbose "Removing problematic operation ids."
        $delegate = {
            param (
                [string] $PropertyName,
                [object] $JsonObject
            )

            # Early out if null
            if ($null -eq $JsonObject) { return }
            $value = $JsonObject[$PropertyName]
            if ($null -eq $value) { $value = $JsonObject.$PropertyName }
            if ($null -eq $value) { return }

            # If object is an array, recurse through array
            switch ($JsonObject.GetType().ToString()) {
                'System.Object[]' {
                    $JsonObject | ForEach-Object { Invoke-DelegateOnJsonNodeWithProperty -PropertyName $PropertyName -Delegate $Delegate -JsonObject $_ }
                    return
                }
            }

            # Object is not an array so process object
            $JsonObject.Remove($PropertyName) | Out-Null
        }
        Invoke-DelegateOnJsonNodeWithProperty -PropertyName "operationId" -Delegate $delegate -JsonObject $JsonObject
        #
        # /Remove operation ids
        #

        #
        # Paginated responses
        #
        Write-Verbose "Adding paginated responses."

        $paths = @(
            '/acceptedcountries'
            '/accountholdergroups'
            '/authcontrols'
            '/autoreloads'
            '/bulkissuances'
            '/businesses'
            '/campaigns'
            '/cardproducts'
            '/cards/user/{token}'
            '/chargebacks'
            '/commandomodes'
            '/digitalwallettokens'
            '/directdeposits'
            '/fees'
            '/fundingsources/addresses/business/{business_token}'
            '/fundingsources/addresses/user/{user_token}'
            '/fundingsources/program/ach'
            '/fundingsources/user/{user_token}'
            '/gpaorders/unloads'
            '/kyc/business/{business_token}'
            '/kyc/user/{user_token}'
            '/mccgroups'
            '/merchants'
            '/merchants/{token}/stores'
            '/msaorders/unloads'
            '/offers'
            '/programreserve/transactions'
            '/programtransfers'
            '/programtransfers/types'
            '/pushtocards/disburse'
            '/pushtocards/paymentcard'
            '/realtimefeegroups'
            '/stores'
            '/transactions'
            '/transactions/fundingsource/{funding_source_token}'
            '/transactions/{token}/related'
            '/usertransitions/user/{user_token}'
            '/users'
            '/users/phonenumber/{phone_number}'
            '/users/{parent_token}/children'
            '/users/{token}/notes'
            '/velocitycontrols'
            '/velocitycontrols/user/{user_token}/available'
            '/webhooks'
        )
        foreach ($path in $paths) {
            Write-Verbose "Adding paginated response for '$($path)'."

            $jsonResponse = $jsonObject.paths[$path].get.responses["200"]

            $responseSchema = $jsonResponse.schema
            if ($responseSchema.items) { $responseRefValue = $responseSchema.items['$ref'] }
            elseif ($responseSchema.'$ref') { $responseRefValue = $responseSchema.'$ref' }

            $modelName = $responseRefValue.Split('/') | Select-Object -Last 1
            $paginatedResponseName = $modelName + '_paginated_response'

            $jsonResponse.schema = @{
                '$ref' = '#/definitions/' + $paginatedResponseName;
            }
            $paginatedResponseSchema = @{
                'type'       = 'object';
                'properties' = @{
                    'count'       = @{
                        'type'   = 'integer';
                        'format' = 'int32';
                    };
                    'start_index' = @{
                        'type'   = 'integer';
                        'format' = 'int32';
                    };
                    'end_index'   = @{
                        'type'   = 'integer';
                        'format' = 'int32';
                    };
                    'is_more'     = @{
                        'type' = 'boolean';
                    };
                    'data'        = @{
                        'type'  = 'array';
                        'items' = @{
                            '$ref' = '#/definitions/' + $modelName;
                        };
                    }
                }
            }
            $jsonObject.definitions[$paginatedResponseName] = $paginatedResponseSchema
        }

        #
        # /Paginated responses
        #

        Write-Verbose "Writing file."
        $jsonObject | ConvertTo-Json -depth 100 | Out-File -Encoding utf8 $defaultJsonPath
    }
    else {
        Write-Verbose "File '$($defaultJsonPath)' already exists. Skipping."
    }
}
#
# /JSON Manipulation
#

# Swagger arguments
$nswagArgs = @(
    'run', '.\nswag.json'
    , '/runtime:NetCore22'
)
Write-Verbose "Using `$nswagArgs: $($nswagArgs)"

Write-Verbose "Running nswag."
nswag $nswagArgs

# 
# Build solution
#
$solutionPath = './Marqeta.Core.Abstractions.sln'
if ($BuildAfterGeneration) {
    if (Get-Command 'dotnet' -ErrorAction SilentlyContinue) {
        # Build solution
        dotnet build $solutionPath
    }
    else {
        Write-Host -ForegroundColor Yellow "Warning: dotnet CLI could not be found within the current environment. ReSharper Clean Up Code has not been run."
    }
}

# 
# Clean up code
#
if ($CleanUpCode) {
    # Check for dotnet CLI
    # We need to build the solution before running the ReSharper Clean Up Code to prevent errors in the clean up
    if (Get-Command 'dotnet' -ErrorAction SilentlyContinue) {
        # Build solution
        dotnet build $solutionPath

        # Clean up code
        $reSharperCltUrl = 'https://download-cf.jetbrains.com/resharper/ReSharperUltimate.2019.1.2/JetBrains.ReSharper.CommandLineTools.2019.1.2.zip'
        $reSharperCltDirectory = './JetBrains.ReSharper.CommandLineTools.2019.1.2'
        $reSharperCltZipPath = $reSharperCltDirectory + '.zip'
        $reSharperCleanUpCodePath = $reSharperCltDirectory + '/cleanupcode.exe'
        if (!(Test-Path $reSharperCleanUpCodePath)) {
            Write-Verbose "Downloading 'ReSharper Command Line Tools'."
            Invoke-WebRequest -Uri $reSharperCltUrl -OutFile $reSharperCltZipPath
            Expand-Archive -Path $reSharperCltZipPath -DestinationPath $reSharperCltDirectory
            Remove-Item -Path $reSharperCltZipPath -Force
        }
        . $reSharperCleanUpCodePath $solutionPath
    }
    else {
        Write-Host -ForegroundColor Yellow "Warning: dotnet CLI could not be found within the current environment. ReSharper Clean Up Code has not been run."
    }
}

# Timer
$sw.Stop()
Write-Host "Code generation completed in '$($sw.Elapsed)'." 
