# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Solution ve proje dosyalarını kopyala
COPY ["CarRentalApp.sln", "./"]
COPY ["NLayer.Core/", "NLayer.Core/"]
COPY ["NLayer.Repository/", "NLayer.Repository/"]
COPY ["NLayer.Service/", "NLayer.Service/"]
COPY ["NLayer.API/", "NLayer.API/"]

# Restore
RUN dotnet restore "CarRentalApp.sln"

# Build
RUN dotnet build "CarRentalApp.sln" -c Release --no-restore

# Publish
RUN dotnet publish "NLayer.API/NLayer.API.csproj" -c Release -o /app/publish --no-restore /p:UseAppHost=false

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Güvenlik için non-root user
RUN addgroup --system --gid 1000 appgroup && \
    adduser --system --uid 1000 --ingroup appgroup appuser

COPY --from=build /app/publish .

# Migrations için EF Core tools (opsiyonel - production'da migrate etmek isterseniz)
# RUN dotnet tool install --global dotnet-ef
# ENV PATH="${PATH}:/root/.dotnet/tools"

USER appuser

EXPOSE 8080
EXPOSE 8081

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "YourApiProject.dll"]