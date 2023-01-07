
# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./InternetShop.Api/InternetShop.Api.csproj" --disable-parallel
RUN dotnet publish "./InternetShop.Api/InternetShop.Api.csproj" -c release -o /artifacts --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal
WORKDIR /app
COPY --from=build /artifacts ./

EXPOSE 5001

ENTRYPOINT ["dotnet", "InternetShop.Api.dll"]
