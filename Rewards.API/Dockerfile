#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Rewards.API/Rewards.API.csproj", "Rewards.API/"]
COPY ["Rewards.Infra/Rewards.Infra.csproj", "Rewards.Infra/"]
COPY ["Rewards.Core/Rewards.Core.csproj", "Rewards.Core/"]
COPY ["Rewards.Service/Rewards.Service.csproj", "Rewards.Service/"]
RUN dotnet restore "Rewards.API/Rewards.API.csproj"
COPY . .
WORKDIR "/src/Rewards.API"
RUN dotnet build "Rewards.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rewards.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rewards.API.dll"]