[CmdletBinding()]
param(
    [switch] $UsePreviewSwaggerCodeGen,
    [switch] $CapMaxItems = $true
)

# Add java to path if required
$pathes = @("C:\Program Files\Java\jdk1.8.0_172\bin")
foreach ($path in $pathes) {
    if (!($env:Path.Contains($path))) {
        Write-Verbose "Adding '$path' to '`$env:Path'"
        $env:Path += ";$($path)"
    }
}

# 
# git clean -xdf .
git clean -xdf docs
git clean -xdf src

#
# Swagger Code Generator
# 
if ($UsePreviewSwaggerCodeGen) {
    Write-Verbose 'Using pre-release version of swagger-codegen.'

    $swaggerSourcePath = 'swagger-codegen'
    if (!(Test-Path $swaggerSourcePath)) {
        git clone https://github.com/swagger-api/swagger-codegen
    }
    
    $swaggerCodeGenPath = 'swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar'
    if (!(Test-Path $swaggerCodeGenPath)) {
        Push-Location $swaggerSourcePath
        .\mvnw clean package
        Pop-Location
    }
}
else {
    Write-Verbose 'Using swagger-codegen v2.4.5.'
    $swaggerCodeGenPath = 'swagger-codegen-cli.jar'
    if (!(Test-Path $swaggerCodeGenPath)) {
        Invoke-WebRequest -Uri http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.4.5/swagger-codegen-cli-2.4.5.jar -OutFile $swaggerCodeGenPath
    }
}

#
# /Swagger Code Generator
# 

# Java
$javaArgs = @(
    '-d64',
    '-jar', $swaggerCodeGenPath
)
Write-Verbose "Using `$javaArgs: $($javaArgs)"

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

# Executing Code Generator
$swaggerArgs = @('generate')

#
# Cap 'maxItems'
# 
# NB: Currently the marqeta-core-api/v3/swagger.json does not play with swagger-codegen
#       Temporary measure to fix it. (Removing all instances of commando)
#
$defaultJsonUri = 'https://shared-sandbox-api.marqeta.com/v3/swagger.json'
if ($CapMaxItems) {
    Write-Verbose "Capping 'maxItems' values to 500."
    $defaultJsonPath = './swagger.json'
    $swaggerArgs += @('-i', $defaultJsonPath)

    if (!(Test-Path $defaultJsonPath)) {
        Write-Verbose "Downloading '$defaultJsonUri'."
        Invoke-WebRequest -Uri $defaultJsonUri -OutFile $defaultJsonPath

        # NB: We need to use the .NET JavaScriptSerializer because the build in powershell one cannot handle IDs with the same name but different casing
        [void][System.Reflection.Assembly]::LoadWithPartialName("System.Web.Extensions")
        $jsonObject = [System.Web.Script.Serialization.JavaScriptSerializer]::new().DeserializeObject((Get-Content -Path $defaultJsonPath))

        # Remove definitions
        Write-Verbose "Massaging JSON."

        # NB: We change the max items due to a bug in swagger-codegen
        #       https://github.com/swagger-api/swagger-codegen/issues/6394
        Write-Verbose "Removing large 'maxItem' properties."
        $newMax = 500
        $jsonObject.definitions["auth_user_request"].properties["roles"].maxItems = $newMax
        $jsonObject.definitions["auth_user_update_request"].properties["roles"].maxItems = $newMax
        $jsonObject.definitions["commando_mode_enables"].properties["velocity_controls"].maxItems = $newMax

        # Enum
        Write-Verbose "Removing problematic enums."
        Import-Module "$($PSScriptRoot)\HelpersModule.ps1" -Force
        $delegate = {
            param (
                [string] $PropertyName,
                [object] $JsonObject
            )
            try {
                # Early outs
                if ($null -eq $JsonObject) { return }
                $value = $JsonObject[$PropertyName]
                if ($null -eq $value) { $value = $JsonObject.$PropertyName }
                if ($null -eq $value) { return }

                # 
                switch ($JsonObject.GetType().ToString()) {
                    'System.Object[]' {
                        $JsonObject | ForEach-Object { Invoke-DelegateOnJsonNodeWithProperty -PropertyName $PropertyName -Delegate $Delegate -JsonObject $_ }
                        return
                    }
                }

                # 
                $value = $JsonObject[$PropertyName]
                if ($null -eq $value) {
                    $value = $JsonObject.$PropertyName
                }

                # Blacklist
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
                            # Delimited values
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
                            # Delimited values
                            $value1 = $value -like '*|*'
                            if ($value1) {
                                $newValue = $value1.Split('|').Trim().Replace('.', '_')
                                $JsonObject[$PropertyName] = $newValue
                            }
                        }
                    }
                }

                # 
                $value = $JsonObject[$PropertyName]
                if ($null -eq $value) { $value = $JsonObject.$PropertyName }

                # 
                if ($value.Length -le 1) {
                    $JsonObject.Remove($PropertyName) | Out-Null
                    return
                }

                # Regex replace (default = ) 
                $regex = [regex]::new("(\(default = [A-Za-z_]*\))")
                $newValue = $value | ForEach-Object { $regex.Replace($_, "") } | Where-Object { ![string]::IsNullOrWhiteSpace($_) } | ForEach-Object { $_.Trim() }
                # $JsonObject[$PropertyName] = $newValue
                switch ($value.GetType().ToString()) {
                    'System.Object[]' { $JsonObject[$PropertyName] = $newValue }
                    default {
                        $JsonObject.$PropertyName = $newValue
                        return
                    }
                }

                # 
                if ($null -eq $JsonObject) { return }
            }
            catch {
                throw $_
            }
        }
        Invoke-DelegateOnJsonNodeWithProperty -PropertyName "enum" -Delegate $delegate -JsonObject $JsonObject

        Write-Verbose "Writing file."
        $JsonObject | ConvertTo-Json -depth 100 | Out-File -Encoding utf8 $defaultJsonPath
    }
    else {
        Write-Verbose "File '$($defaultJsonPath)' already exists. Skipping."
    }
}
else {
    Write-Verbose "Using default swagger.json '$defaultJsonUri'."
    $swaggerArgs += @('-i', $defaultJsonUri)
}
#
# /Cap 'maxItems'
#

$swaggerArgs += @(
    '--config', 'csharp-config.json',

    # https://github.com/swagger-api/swagger-codegen#modifying-the-client-library-format
    # https://github.com/swagger-api/swagger-codegen#selective-generation
    # '-Dmodels', '-DsupportingFiles',
    '-Dmodels',
    # '-Dapis',
    # '-DsupportingFiles',
    '-l', 'csharp',
    '-o', $outDir
)
Write-Verbose "Using `$swaggerArgs: $($swaggerArgs)"

Write-Verbose "Running swagger-codegen."
# java $javaArgs $swaggerArgs