msbuild Savory.LogService.Contract.Net40\Savory.LogService.Contract.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.LogService.Contract.xml;DebugType=none

msbuild Savory.LogService.Contract.Net45\Savory.LogService.Contract.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.LogService.Contract.xml;DebugType=none

nuget pack Savory.LogService.Contract.nuspec

move /y Savory.LogService.Contract.*.nupkg D:\LocalWebRoot\SavoryNuget\Packages

pause