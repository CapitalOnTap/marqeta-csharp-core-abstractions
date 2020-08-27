[![Build Status](https://dev.azure.com/lflanagan/liamflan/_apis/build/status/CapitalOnTap.marqeta-csharp-core-abstractions?branchName=master)](https://dev.azure.com/lflanagan/liamflan/_build/latest?definitionId=3&branchName=master)
[![NuGet Version](https://img.shields.io/nuget/v/Marqeta.Core.Abstractions)](https://www.nuget.org/packages/Marqeta.Core.Abstractions)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Marqeta.Core.Abstractions)](https://www.nuget.org/packages/Marqeta.Core.Abstractions)

# marqeta-csharp-core-abstractions

Marqeta C# Data Transfer Objects

## Documentation

For complete reference documentation, see the [Marqeta Core API Reference](https://www.marqeta.com/api/docs/WYDH6igAAL8FnF21/api-introduction).

## Updating

To update the core abstractions you will need NSWAG installed on your machine you can find the latest download here - https://github.com/RicoSuter/NSwag (NSwagStudio MSI Installer). 

Once this is installed (you can check by running `nswag` in powershell) just run `./generate.ps1` You should be able to then verify any changes you were expecting from the updated swagger.json from [marqeta-swagger-json](https://github.com/CapitalOnTap/marqeta-swagger-json) repo.