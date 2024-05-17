#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ForeningsPortalen.Api/ForeningsPortalen.Api.csproj", "ForeningsPortalen.Api/"]
COPY ["ForeningsPortalen.Application/ForeningsPortalen.Application.csproj", "ForeningsPortalen.Application/"]
COPY ["ForeningsPortalen.Domain/ForeningsPortalen.Domain.csproj", "ForeningsPortalen.Domain/"]
COPY ["ForeningsPortalen.DatabaseMigration/ForeningsPortalen.DatabaseMigration.csproj", "ForeningsPortalen.DatabaseMigration/"]
COPY ["ForeningsPortalen.Infrastructure/ForeningsPortalen.Infrastructure.csproj", "ForeningsPortalen.Infrastructure/"]
RUN dotnet restore "./ForeningsPortalen.Api/ForeningsPortalen.Api.csproj"
COPY . .
WORKDIR "/src/ForeningsPortalen.Api"
RUN dotnet build "./ForeningsPortalen.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ForeningsPortalen.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForeningsPortalen.Api.dll"]