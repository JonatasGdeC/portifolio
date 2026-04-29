FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Portifolio/Portifolio.csproj", "Portifolio/"]
RUN dotnet restore "Portifolio/Portifolio.csproj"

COPY . .
WORKDIR /src/Portifolio
RUN dotnet publish "Portifolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Portifolio.dll"]