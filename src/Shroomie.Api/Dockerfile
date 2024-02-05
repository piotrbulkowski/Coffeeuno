FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Shroomie.Api/Shroomie.Api.csproj", "Shroomie.Api/"]
RUN dotnet restore "Shroomie.Api/Shroomie.Api.csproj"
COPY . .
WORKDIR "/src/Shroomie.Api"
RUN dotnet build "Shroomie.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shroomie.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shroomie.Api.dll"]
