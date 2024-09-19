# Use a imagem base do .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use a imagem do SDK do .NET 8 para compilar e publicar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SeuProjeto.csproj", "./"]
RUN dotnet restore "SeuProjeto.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SeuProjeto.csproj" -c Release -o /app/build
RUN dotnet publish "SeuProjeto.csproj" -c Release -o /app/publish

# Use a imagem base para rodar a aplicação
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SeuProjeto.dll"]
