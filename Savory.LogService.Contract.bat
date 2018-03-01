msbuild Savory.LogService.Contract.Net40\Savory.LogService.Contract.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.LogService.Contract.xml;DebugType=none

msbuild Savory.LogService.Contract.Net45\Savory.LogService.Contract.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.LogService.Contract.xml;DebugType=none

pushd Savory.LogService.Contract.Net45
reference^
 /csproj:Savory.LogService.Contract.Net45.csproj^
 /target:savory-lib\Savory.LogService.Contract.txt
popd

nuget pack Savory.LogService.Contract.nuspec

@rem move /y Savory.LogService.Contract.*.nupkg D:\LocalWebRoot\SavoryNuget\Packages

pause