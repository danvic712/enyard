FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_14.x | bash - \
    && apt-get install -y \
        nodejs \
    && rm -rf /var/lib/apt/lists/*

# Copy src folder contents to the build path
COPY ./src /app

WORKDIR /app/Enyard.Web
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
RUN ln -sf /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
ENTRYPOINT ["dotnet", "Enyard.Web.dll"]