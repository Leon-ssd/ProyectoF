FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["StreamApp.csproj", "./"]
RUN dotnet restore "StreamApp.csproj"

COPY . .
RUN dotnet publish "StreamApp.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "StreamApp.dll"]
