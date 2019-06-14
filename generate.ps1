[CmdletBinding()]
param(
    [switch] $UsePreviewSwaggerCodeGen,
    [switch] $RemoveCommandoCommands = $true
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
$outDir = $PSScriptRoot + '\swagger-codegen-output'
Write-Verbose "Using `$outDir: $($outDir)"

# Purge output directory
if (Test-Path $outDir) {
    Write-Verbose "Purging directory '$outDir'."
    Remove-Item -Recurse -Force $outDir -ErrorAction SilentlyContinue
}
Write-Verbose "Creating directory '$outDir'."
mkdir $outDir -ErrorAction SilentlyContinue | Out-Null

# Copy ignore file
Write-Verbose "Copying swagger-codegen-ignore file."
$ignoreFileName = '.swagger-codegen-ignore'
Copy-Item -Force $( $PSScriptRoot + '\' + $ignoreFileName) $($outDir + '\' + $ignoreFileName) -ErrorAction SilentlyContinue | Out-Null

# Executing Code Generator
$swaggerArgs = @('generate')

#
# Remove commando commands
# 
# NB: Currently the marqeta-core-api/v3/swagger.json does not play with swagger-codegen
#       Temporary measure to fix it. (Removing all instances of commando)
#
$defaultJsonUri = 'https://shared-sandbox-api.marqeta.com/v3/swagger.json'
if ($RemoveCommandoCommands) {
    Write-Verbose "Removing 'Commando' commands."
    $defaultJsonPath = './swagger.json'

    Write-Verbose "Downloading '$defaultJsonUri'."
    Invoke-WebRequest -Uri $defaultJsonUri -OutFile $defaultJsonPath

    # $jsonObject = Get-Content -Path $defaultJsonPath | ConvertFrom-Json
    [void][System.Reflection.Assembly]::LoadWithPartialName("System.Web.Extensions")
    # $json = (New-Object -TypeName System.Web.Script.Serialization.JavaScriptSerializer).DeserializeObject((Get-Content -Path $defaultJsonPath))
    $jsonObject = [System.Web.Script.Serialization.JavaScriptSerializer]::new().DeserializeObject((Get-Content -Path $defaultJsonPath))

    # Remove definitions
    Write-Verbose "Massaging JSON."
    # $jsonObject.tags = $jsonObject.tags | Where-Object { $_.name -ne "commandomodes : Operation for commandomodes" }
    # $jsonObject.paths.Remove("/commandomodes") | Out-Null
    # $jsonObject.paths.Remove("/commandomodes/transitions/{token}") | Out-Null
    # $jsonObject.paths.Remove("/commandomodes/{commandomode_token}/transitions") | Out-Null
    # $jsonObject.paths.Remove("/commandomodes/{token}") | Out-Null
    # $jsonObject.definitions.Remove("commando_mode_request") | Out-Null
    # $jsonObject.definitions.Remove("commando_mode_transition_response") | Out-Null

    # Minimum required
    $jsonObject.paths["/commandomodes"].get.responses["200"].schema.items.Remove("`$ref") | Out-Null
    $jsonObject.paths["/commandomodes/{token}"].get.responses["200"].schema.Remove("`$ref") | Out-Null

    Write-Verbose "Writing file."
    # $jsonObject | ConvertTo-Json -depth 100 | Out-File $defaultJsonPath
    # $jsonObject | ConvertTo-Json -depth 100 | ForEach-Object { $_.Replace("\u003c", "<").Replace("\u003e", ">").Replace("\u0027", "'") } | Out-File './swagger.1.json'
    [System.IO.File]::WriteAllLines($defaultJsonPath, ($jsonObject | ConvertTo-Json -depth 100), [System.Text.UTF8Encoding]::new($false))

    $swaggerArgs += @('-i', $defaultJsonPath)
}
else {
    Write-Verbose "Using default swagger.json '$defaultJsonUri'."
    $swaggerArgs += @('-i', $defaultJsonUri)
}
#
# /Remove commando commands
#

$swaggerArgs += @(
    '--config', 'csharp-config.json',

    # https://github.com/swagger-api/swagger-codegen#modifying-the-client-library-format
    # https://github.com/swagger-api/swagger-codegen#selective-generation
    # '-Dmodels', '-DsupportingFiles',
    #'-Dmodels',
    '-Dapis',
    # '-DsupportingFiles',
    '-l', 'csharp',
    '-o', $outDir
)
Write-Verbose "Using `$swaggerArgs: $($swaggerArgs)"

Write-Verbose "Running swagger-codegen."
java $javaArgs $swaggerArgs

# java -DdebugModels -jar swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -i https://shared-sandbox-api.marqeta.com/v3/swagger.json -l csharp
