FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TodoSample/TodoSample.csproj", "TodoSample/"]
RUN dotnet restore "TodoSample/TodoSample.csproj"
COPY . .
WORKDIR "/src/TodoSample"
RUN dotnet build "TodoSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TodoSample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TodoSample.dll"]
