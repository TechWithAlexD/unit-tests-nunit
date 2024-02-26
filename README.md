# unit-tests-nunit
.NET framework console application projects sample
    - SourceProject - Sample source project to be unit tested
    - UnitTests - Sample NUnits tests project

## Installation
1. Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) or newer installed on your machine (projects were developed using .NET 8). Check installation
    ```PS
    dotnet --version
    ```
2. Clone this repository to your local machine.
3. Open the solution in Visual Studio or solution folder in VS Code or your preferred IDE. 
4. Download [nuget.exe](https://www.nuget.org/downloads).
5. Open Command Prompt and navigate to the directory containing .NET Framework project's solution file (.sln).
6. Restore NuGet Packages:
    ```PS
    <path>\nuget.exe restore .\<SourceProject.sln>
    ```
6. Build projects:
    ```PS
    dotnet build
    ```

## Usage
1. Run from IDE: Open the solution directory in VS Code or your preferred IDE. 
2. Run from cmd: Open Command Prompt and navigate to the directory containing unit tests .csproj file.

- run unit tests using dotnet
```
dotnet test .\bin\Debug\UnitTests.dll
```

- run unit tests by category using dotnet 
```
dotnet test .\bin\Debug\UnitTests.dll --filter TestCategory=UnitTest_P1 
```

## YT channel
Please check my YouTube channel for step by step implementation or detailed tutorials on automation and more: https://www.youtube.com/@TechWithAlexDuta

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.