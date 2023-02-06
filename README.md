# unit-tests-nunit
SourceProject.sln
NUnits tests project sample - UnitTests
Source project sample - SourceProject

# run unit tests using nunit3-console
<path>\nunit3-console.exe "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll"

# run unit tests using nunit3-console by category
<path>\nunit3-console.exe "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll" --where "cat == UnitTest_P1"

# run unit tests using dotnet
dotnet test "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll"

# run unit tests using dotnet by category
dotnet test "<path>\SourceProject\UnitTests\bin\Debug\UnitTests.dll" --filter TestCategory=UnitTest_P1 

# Install Visual Studio, Create a NUnit tests project with Visual Studio, run unit tests from command line
Playlist "C# NUnit Test": https://www.youtube.com/@automation100/playlists