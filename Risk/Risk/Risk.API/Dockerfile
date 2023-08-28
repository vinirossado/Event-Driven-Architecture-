FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Risk/Risk.csproj", "Risk/"]
RUN dotnet restore "Risk/Risk.csproj"
COPY . .
WORKDIR "/src/Risk"
RUN dotnet build "Risk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Risk.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Risk.dll"]
