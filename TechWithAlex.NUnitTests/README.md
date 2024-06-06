# TechWithAlex.NUnitTests
.NET framework console application projects sample
    - TechWithAlex.SourceProject - Sample source project to be unit tested
    - TechWithAlex.NUnit3Tests - Sample NUnits tests project

## Installation
1. Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) or newer installed on your machine (projects were developed using .NET 8). Check installation
    ```PS
    dotnet --version
    ```
2. Clone this repository to your local machine.
3. Open the solution in Visual Studio or solution folder in VS Code or your preferred IDE. 
4. Optional: 
- to run NUnit 3 tests with nunit-console, download [nunit-console 3.16.0](https://github.com/nunit/nunit-console/releases/tag/3.16.0)
- to run NUnit 4 tests with nunit-console, download [nunit-console 3.17.0](https://github.com/nunit/nunit-console/releases/tag/3.17.0) or newer
5. Build projects:
    ```PS
    dotnet build
    ```
In most cases, you don't need to explicitly use the dotnet restore command, since if a NuGet restore is necessary, the following commands run it implicitly:

    dotnet new
    dotnet build
    dotnet build-server
    dotnet run
    dotnet test
    dotnet publish
    dotnet pack

## Usage
1. Run from IDE: Open the solution directory in VS Code or your preferred IDE. 
2. Run from cmd: Open Command Prompt and navigate to the directory containing unit tests .csproj file (make sure step #5(build) is executed before running the following):

- run unit tests using dotnet
```
dotnet test \TechWithAlex.NUnit4Tests\bin\Debug\net8.0\TechWithAlex.NUnit4Tests.dll
```

- run nunit 3 tests using nunit3.16-console. Note: remove single quote chars
```
'path to nunit3.16-(console-nunit3)'\nunit3-console.exe 'path to unit tests project'\TechWithAlex.NUnit4Tests\bin\Debug\net8.0\TechWithAlex.NUnit4Tests.dll
```

- run nunit 4 tests using nunit3.17-console. Note: remove single quote chars
```
'path to nunit3.17-(console-nunit4)\bin\net8.0'\nunit3-console.exe 'path to unit tests project'\TechWithAlex.NUnit4Tests\bin\Debug\net8.0\TechWithAlex.NUnit4Tests.dll
```

## YT channel
Please check my YouTube channel for step by step implementation or detailed tutorials on automation and more: https://www.youtube.com/@TechWithAlexDuta

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.