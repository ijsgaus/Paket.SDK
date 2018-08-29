dotnet pack src\Paket.SDK\Paket.SDK.csproj -o ..\..\nugets
dotnet nuget push nugets\Paket.SDK.0.0.1-beta1.nupkg --source ".\123"
dotnet build test\TestApp\TestApp.fsproj -v d