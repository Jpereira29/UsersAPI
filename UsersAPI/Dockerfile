# Use the official .NET Core SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY ["UsersAPI.csproj", "./"]
RUN dotnet restore

# Copy the remaining source code and build the app
COPY . ./ 
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80

# Specify the entry point for the app
ENTRYPOINT ["dotnet", "UsersAPI.dll"]
