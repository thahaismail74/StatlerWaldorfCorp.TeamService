#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["StatlerWaldorfCorp.TeamService.csproj", "./"]
RUN dotnet restore "StatlerWaldorfCorp.TeamService.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "StatlerWaldorfCorp.TeamService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StatlerWaldorfCorp.TeamService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StatlerWaldorfCorp.TeamService.dll"]
