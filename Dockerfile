FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["BackEnd/BackEnd.csproj", "BackEnd/"]
RUN dotnet restore "BackEnd/BackEnd.csproj"
COPY . .
WORKDIR "/src/BackEnd"
RUN dotnet build "BackEnd.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BackEnd.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackEnd.dll"]
