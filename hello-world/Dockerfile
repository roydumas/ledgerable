FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY hello-world/*.csproj ./hello-world/
RUN dotnet restore

# copy everything else and build app
COPY hello-world/. ./hello-world/
WORKDIR /app/hello-world
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/hello-world/out ./
ENTRYPOINT ["dotnet", "hello-world.dll"]
