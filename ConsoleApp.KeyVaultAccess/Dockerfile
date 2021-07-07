#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ConsoleApp.KeyVaultAccess/ConsoleApp.KeyVaultAccess.csproj", "ConsoleApp.KeyVaultAccess/"]
RUN dotnet restore "ConsoleApp.KeyVaultAccess/ConsoleApp.KeyVaultAccess.csproj"
COPY . .
WORKDIR "/src/ConsoleApp.KeyVaultAccess"
RUN dotnet build "ConsoleApp.KeyVaultAccess.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp.KeyVaultAccess.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp.KeyVaultAccess.dll"]