#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/SmartH2RCore.Web/SmartH2RCore.Web.csproj", "src/SmartH2RCore.Web/"]
COPY ["src/SmartH2RCore.Services/SmartH2RCore.Services.csproj", "src/SmartH2RCore.Services/"]
COPY ["src/SmartH2RCore.Core/SmartH2RCore.Core.csproj", "src/SmartH2RCore.Core/"]
COPY ["src/SmartH2RCore.Models/SmartH2RCore.Models.csproj", "src/SmartH2RCore.Models/"]
RUN dotnet restore "src/SmartH2RCore.Web/SmartH2RCore.Web.csproj"
COPY . .
WORKDIR "/src/src/SmartH2RCore.Web"
RUN dotnet build "SmartH2RCore.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartH2RCore.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartH2RCore.Web.dll"]