FROM microsoft/dotnet:latest
WORKDIR /app
COPY . ./
RUN dotnet pack src/Paket.SDK/Paket.SDK.fsproj -o ../../nugets
RUN dotnet build test/TestApp/TestApp.fsproj -v d

