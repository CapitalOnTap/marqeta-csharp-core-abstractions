[CmdletBinding()]
param()

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
if ($usePreviewSwaggerCodeGen) {
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

####

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
$swaggerArgs = @(
    'generate', '-i', 'https://shared-sandbox-api.marqeta.com/v3/swagger.json',
    '--config', 'csharp-config.json',

    # https://github.com/swagger-api/swagger-codegen#modifying-the-client-library-format
    # https://github.com/swagger-api/swagger-codegen#selective-generation
    # '-Dmodels', '-DsupportingFiles',
    '-Dmodels',
    # '-Dapis', '',
    # '-DsupportingFiles', '',
    '-l', 'csharp',
    '-o', $outDir
)
Write-Verbose "Using `$swaggerArgs: $($swaggerArgs)"

Write-Verbose "Running swagger-codegen."
java $javaArgs $swaggerArgs

# java -DdebugModels -jar swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -i https://shared-sandbox-api.marqeta.com/v3/swagger.json -l csharp
