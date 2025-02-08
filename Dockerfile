#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/runtime:8.0@sha256:e6b552fd7a0302e4db30661b16537f7efcdc0b67790a47dbf67a5e798582d3a5 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:35792ea4ad1db051981f62b313f1be3b46b1f45cadbaa3c288cd0d3056eefb83 AS build
WORKDIR /src
COPY ["./Contato.Cadastrar/Contato.Cadastrar.csproj", "Contato.Cadastrar/"]
RUN dotnet restore "./Contato.Cadastrar/Contato.Cadastrar.csproj"
COPY . .
WORKDIR "/src/Contato.Cadastrar"
RUN dotnet build "Contato.Cadastrar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contato.Cadastrar.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contato.Cadastrar.dll"]