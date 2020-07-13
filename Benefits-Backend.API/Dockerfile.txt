FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Release/netcoreapp3.1/ API/
WORKDIR /API
EXPOSE 44339
ENTRYPOINT ["dotnet", "Benefits-Backend.API.dll"]