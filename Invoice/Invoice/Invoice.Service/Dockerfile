FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Invoice.Service/Invoice.Service.csproj", "Invoice.Service/"]
RUN dotnet restore "Invoice.Service/Invoice.Service.csproj"
COPY . .
WORKDIR "/src/Invoice.Service"
RUN dotnet build "Invoice.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Invoice.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Invoice.Service.dll"]
