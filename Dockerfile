FROM microsoft/dotnet:latest
WORKDIR /app
COPY . ./
RUN dotnet pack src/Paket.SDK/Paket.SDK.csproj -o ../../nugets
RUN dotnet build test/TestApp/TestApp.fsproj -v d

