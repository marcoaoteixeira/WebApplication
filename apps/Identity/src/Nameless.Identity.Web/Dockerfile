#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["apps/Identity/src/Nameless.Identity.Web/Nameless.Identity.Web.csproj", "apps/Identity/src/Nameless.Identity.Web/"]
RUN dotnet restore "apps/Identity/src/Nameless.Identity.Web/Nameless.Identity.Web.csproj"
COPY . .
WORKDIR "/src/apps/Identity/src/Nameless.Identity.Web"
RUN dotnet build "Nameless.Identity.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nameless.Identity.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nameless.Identity.Web.dll"]