# ASP.NET Core + Angular playground

## Commands used:

Install [generator-aspnetcore-spa](https://www.npmjs.com/package/generator-aspnetcore-spa)
> npm install -g yo generator-aspnetcore-spa

## Add dotnet watch to *.csproj

```
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="1.0.0" />
  </ItemGroup>
```

and then

> dotnet restore

Since this moment use:

> dotnet watch run

## Entity Framework Core
Add `Microsoft.EntityFrameworkCore.Tools.DotNet` reference to .csproj which enables EF commands:

> dotnet ef
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet ef migrations add InitialModel