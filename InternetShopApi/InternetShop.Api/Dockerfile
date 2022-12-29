FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["InternetShop/InternetShop.csproj", "InternetShop/"]
RUN dotnet restore "InternetShop/InternetShop.csproj"
COPY . .
WORKDIR "/src/InternetShop"
RUN dotnet build "InternetShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InternetShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InternetShop.dll"]
