FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

COPY ["src/Application/Application.csproj", "Application/"]
COPY ["src/Infra.Data/Infra.Data.csproj", "Infra.Data/"]
COPY ["src/Infra.CrossCutting.Ioc/Infra.CrossCutting.Ioc.csproj", "Infra.CrossCutting.Ioc/"]
COPY ["src/Infra.CrossCutting.Utils/Infra.CrossCutting.Utils.csproj", "Infra.CrossCutting.Utils/"]
COPY ["src/Presentation/Presentation.csproj", "Presentation/"]
COPY ["src/Domain/Domain.csproj", "Domain/"]
COPY ["src/Application/Application.csproj", "Application/"]

RUN dotnet restore "Application/Application.csproj"
COPY . .
WORKDIR "/src/Application"
RUN dotnet build "Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Application.dll"]