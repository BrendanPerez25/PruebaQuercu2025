FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/PruebaQuercu.Web.Mvc/PruebaQuercu.Web.Mvc.csproj", "src/PruebaQuercu.Web.Mvc/"]
COPY ["src/PruebaQuercu.Web.Core/PruebaQuercu.Web.Core.csproj", "src/PruebaQuercu.Web.Core/"]
COPY ["src/PruebaQuercu.Application/PruebaQuercu.Application.csproj", "src/PruebaQuercu.Application/"]
COPY ["src/PruebaQuercu.Core/PruebaQuercu.Core.csproj", "src/PruebaQuercu.Core/"]
COPY ["src/PruebaQuercu.EntityFrameworkCore/PruebaQuercu.EntityFrameworkCore.csproj", "src/PruebaQuercu.EntityFrameworkCore/"]
WORKDIR "/src/src/PruebaQuercu.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PruebaQuercu.Web.Mvc", "src/PruebaQuercu.Web.Mvc"]
COPY ["src/PruebaQuercu.Web.Core", "src/PruebaQuercu.Web.Core"]
COPY ["src/PruebaQuercu.Application", "src/PruebaQuercu.Application"]
COPY ["src/PruebaQuercu.Core", "src/PruebaQuercu.Core"]
COPY ["src/PruebaQuercu.EntityFrameworkCore", "src/PruebaQuercu.EntityFrameworkCore"]
WORKDIR "/src/src/PruebaQuercu.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PruebaQuercu.Web.Mvc.dll"]
