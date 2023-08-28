FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Invoice.API/Invoice.API.csproj", "Invoice.API/"]
RUN dotnet restore "Invoice.API/Invoice.API.csproj"
COPY . .
WORKDIR "/src/Invoice.API"
RUN dotnet build "Invoice.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Invoice.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Invoice.API.dll"]
