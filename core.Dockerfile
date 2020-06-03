FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

COPY "Sticker.sln" .
COPY ["Sticker.Core/Sticker.Core.csproj", "Sticker.Core/"]
COPY ["Sticker.Model/Sticker.Model.csproj", "Sticker.Model/"]

RUN dotnet restore

COPY "Sticker.Core/" ./Sticker.Core/
COPY "Sticker.Model/" ./Sticker.Model/

RUN dotnet publish --no-restore -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Sticker.Core.dll"]