FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Invoice.Repository/Invoice.Repository.csproj", "Invoice.Repository/"]
RUN dotnet restore "Invoice.Repository/Invoice.Repository.csproj"
COPY . .
WORKDIR "/src/Invoice.Repository"
RUN dotnet build "Invoice.Repository.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Invoice.Repository.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Invoice.Repository.dll"]
