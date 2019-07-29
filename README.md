# C# API for the SportRadar

[![Build Status](https://codevision.visualstudio.com/SportRadar/_apis/build/status/kant2002.sportradar-api?branchName=master)](https://codevision.visualstudio.com/SportRadar/_build/latest?definitionId=108&branchName=master)

> see https://aka.ms/autorest

``` yaml 
use-extension:
  "@microsoft.azure/autorest.csharp": "2.3.84"

input-file: openapi.yaml
csharp:
  namespace: AndriiKurdiumov.SportRadar.Client
  output-folder: SportRadar.Api.Client
```

All content of the client, generated using autorest. Just run in the root of solution:
```
autorest
```

## Usage

To use add custom NuGet feed https://codevision.pkgs.visualstudio.com/SportRadar/_packaging/sportradar/nuget/v3/index.json

    dotnet add package SportRadar.Api.Client -s https://codevision.pkgs.visualstudio.com/SportRadar/_packaging/sportradar/nuget/v3/index.json

