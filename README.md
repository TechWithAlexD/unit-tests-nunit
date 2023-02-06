# unit-tests-nunit
SourceProject.sln

UnitTests - NUnits tests project sample

SourceProject - Source project to be unit tested sample

# run unit tests using nunit3-console
```
<pat>\nunit3-console.exe "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll"
```

# run unit tests using nunit3-console by category
```
<path>\nunit3-console.exe "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll" --where "cat == UnitTest_P1"
```

# run unit tests using dotnet
```
dotnet test "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll"
```

# run unit tests using dotnet by category
```
dotnet test "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll" --filter TestCategory=UnitTest_P1 
```

# Install Visual Studio, Create a NUnit tests project with Visual Studio, Run unit tests from command line
**Playlist "C# NUnit Test": https://www.youtube.com/@automation100/playlists**
