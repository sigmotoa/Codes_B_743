FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Basica_12mod/Basica_12mod.csproj", "Basica_12mod/"]
RUN dotnet restore "Basica_12mod/Basica_12mod.csproj"
COPY . .
WORKDIR "/src/Basica_12mod"
RUN dotnet build "Basica_12mod.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Basica_12mod.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Basica_12mod.dll"]
