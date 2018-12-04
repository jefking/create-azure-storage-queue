# Create Azure Storage Queue
<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fjefking%2Fcreate-azure-storage-queue%2Fmaster%2Fazure.deploy.json" target="_blank">
    <img src="http://azuredeploy.net/deploybutton.png"/>
</a>

## Build
### Dotnet
```
dotnet build
```

### Docker
```
docker build .
```

## Run
```
docker run -t -e "queue=create" -e "connection=<Connection String>" jefking/create-queue:latest
```