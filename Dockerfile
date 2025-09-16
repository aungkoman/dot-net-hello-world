# escape=`

# Use the .NET Framework 4.7.2 SDK image to build the application
FROM mcr.microsoft.com/dotnet/framework/sdk:4.7.2-windowsservercore-ltsc2019 AS build
WORKDIR /app

# Copy the solution and project files
COPY *.sln .
COPY HelloDotNet/*.csproj ./HelloDotNet/
COPY HelloDotNet/packages.config ./HelloDotNet/
COPY packages ./packages

# Restore NuGet packages
RUN nuget restore

# Copy the rest of the application files
COPY . .

# Build the application
RUN msbuild /p:Configuration=Release HelloDotNet/HelloDotNet.csproj

# Use the ASP.NET 4.7.2 runtime image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.7.2-windowsservercore-ltsc2019 AS final
WORKDIR /inetpub/wwwroot

# Copy the built application from the build stage
COPY --from=build /app/HelloDotNet .
