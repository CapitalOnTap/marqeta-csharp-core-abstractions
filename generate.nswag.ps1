[CmdletBinding()]
param(
    [bool] $JsonManipulation = $true,
    [bool] $CleanUpCode = $false
)

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

        # NB: We need to use the .NET JavaScriptSerializer because the build in powershell one cannot handle IDs with the same name but different casing
        [void][System.Reflection.Assembly]::LoadWithPartialName("System.Web.Extensions")
        $jsonObject = [System.Web.Script.Serialization.JavaScriptSerializer]::new().DeserializeObject((Get-Content -Path $defaultJsonPath))

        # Remove definitions
        Write-Verbose "Massaging JSON."

        # Tite
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
                                $newValue = $value1.Split($delimiter).Trim().Replace('.', '_')
                                $JsonObject[$PropertyName] = $newValue
                                break
                            }
                        }
                    }
                    else {
                        $value1 = $value -like '*|*'
                        if ($value1) {
                            $newValue = $value1.Split('|').Trim().Replace('.', '_')
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
            # Replace (default*) 
            $regex = [regex]::new("(\(default[ = ]*[0-9A-Za-z_]*\))")
            $newValue = $value | ForEach-Object { $regex.Replace($_, "") } | Where-Object { ![string]::IsNullOrWhiteSpace($_) } | ForEach-Object { $_.Trim() }
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

            $jsonResponse = $jsonObject.paths[$path].get.responses["200"]

            $modelName = $jsonResponse.schema.items['$ref'].Split('/') | Select-Object -Last 1
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
        $JsonObject | ConvertTo-Json -depth 100 | Out-File -Encoding utf8 $defaultJsonPath
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
    'run', '.\nswag.template.json'
    , '/runtime:NetCore22'
)
Write-Verbose "Using `$nswagArgs: $($nswagArgs)"

Write-Verbose "Running nswag."
nswag $nswagArgs

# 
# Clean up code
#
if ($CleanUpCode) {
    # Check for dotnet CLI
    # We need to build the solution before running the ReSharper Clean Up Code to prevent errors in the clean up
    if (Get-Command 'dotnet' -ErrorAction SilentlyContinue) {
        $solutionPath = './Marqeta.Core.Abstractions.sln'

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
