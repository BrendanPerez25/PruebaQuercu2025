FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/PruebaQuercu.Web.Host/PruebaQuercu.Web.Host.csproj", "src/PruebaQuercu.Web.Host/"]
COPY ["src/PruebaQuercu.Web.Core/PruebaQuercu.Web.Core.csproj", "src/PruebaQuercu.Web.Core/"]
COPY ["src/PruebaQuercu.Application/PruebaQuercu.Application.csproj", "src/PruebaQuercu.Application/"]
COPY ["src/PruebaQuercu.Core/PruebaQuercu.Core.csproj", "src/PruebaQuercu.Core/"]
COPY ["src/PruebaQuercu.EntityFrameworkCore/PruebaQuercu.EntityFrameworkCore.csproj", "src/PruebaQuercu.EntityFrameworkCore/"]
WORKDIR "/src/src/PruebaQuercu.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PruebaQuercu.Web.Host", "src/PruebaQuercu.Web.Host"]
COPY ["src/PruebaQuercu.Web.Core", "src/PruebaQuercu.Web.Core"]
COPY ["src/PruebaQuercu.Application", "src/PruebaQuercu.Application"]
COPY ["src/PruebaQuercu.Core", "src/PruebaQuercu.Core"]
COPY ["src/PruebaQuercu.EntityFrameworkCore", "src/PruebaQuercu.EntityFrameworkCore"]
WORKDIR "/src/src/PruebaQuercu.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PruebaQuercu.Web.Host.dll"]
