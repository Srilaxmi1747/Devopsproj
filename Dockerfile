# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore src/Devopsproj.App/Devopsproj.App.csproj
RUN dotnet publish src/Devopsproj.App/Devopsproj.App.csproj -c Release -o /app/publish

# Runtime stage (REPLACED)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Devopsproj.App.dll"]
