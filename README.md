# ASP.NET Core + Angular playground

## Commands used:

Install [generator-aspnetcore-spa](https://www.npmjs.com/package/generator-aspnetcore-spa)

`npm install -g yo generator-aspnetcore-spa`

Add dotnet watch to *.csproj

```
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="1.0.0" />
  </ItemGroup>
```

and then

`dotnet restore`

Since this moment use:

`dotnet watch run`

## Entity Framework Core
Add `Microsoft.EntityFrameworkCore.Tools.DotNet` reference to .csproj which enables EF commands:

`dotnet ef`

`dotnet add package Microsoft.EntityFrameworkCore.Design`

`dotnet ef migrations add InitialModel`

`dotnet ef migrations remove`

## Troubleshooting db connection
To use HeidiSQL to connect to database Vega use:

```
cd 'C:\Program Files\Microsoft SQL Server\130\LocalDB\Binn'
SqlLocalDB.exe info
if not running
SqlLocalDB.exe start MSSQLLocalDb
SqlLocalDB.exe info MSSQLLocalDb

Name:               mssqllocaldb
Version:            13.0.1601.5
Shared name:
Owner:              DESKTOP-DNALHJH\domin
Auto-create:        Yes
State:              Running
Last start time:    10.08.2017 23:45:48
Instance pipe name: np:\\.\pipe\LOCALDB#1D00D124\tsql\query
```

Then in connection manager use `\\.\pipe\LOCALDB#1D00D124\tsql\query` as a host name for _MS SQL Server (named pipe)_ connection