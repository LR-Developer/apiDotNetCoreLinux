FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["ApiIndicadores.csproj", "./"]
RUN dotnet restore "./ApiIndicadores.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ApiIndicadores.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ApiIndicadores.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ApiIndicadores.dll"]
