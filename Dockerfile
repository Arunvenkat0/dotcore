FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app
COPY . .
RUN dotnet restore "CISample/CIService.WebApi/CIService.WebApi.csproj"
RUN dotnet publish "CISample/CIService.WebApi/CIService.WebApi.csproj" -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/CISample/CIService.WebApi/out .

WORKDIR /app
ENTRYPOINT ["dotnet", "CIService.WebApi.dll"]
