FROM mcr.microsoft.com/dotnet/aspnet:9.0-noble-chiseled
#-composite

COPY publish/ app/
ENTRYPOINT ["app/DeploymentTest"]