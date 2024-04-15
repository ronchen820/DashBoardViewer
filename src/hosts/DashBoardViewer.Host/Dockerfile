FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY ["/src/hosts/DashBoardViewer.Host/DashBoardViewer.Host.csproj", "/src/hosts/DashBoardViewer.Host/DashBoardViewer.Host.csproj"]
RUN dotnet restore "/src/hosts/DashBoardViewer.Host/DashBoardViewer.Host.csproj" -nowarn:NETSDK1138
COPY . .
WORKDIR "/src/src/hosts/DashBoardViewer.Host"
ENV NUGET_XMLDOC_MODE none
RUN dotnet publish "DashBoardViewer.Host.csproj" -nowarn:NETSDK1138 -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app .
EXPOSE 8000
ENTRYPOINT ["dotnet", "DashBoardViewer.Host.dll"]