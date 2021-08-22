# API Worker
Simple POC for REST API with worker service running constantly in background, that can be installed as windows service.

Written in .net5.

How to build:
```winbatch
dotnet run -c Release -r win10-x64 
```
Publish:
```winbatch
dotnet publish -c Release -r win10-x64 /p:PublishSingleFile=true
``` 
Install:
```winbatch
sc.exe create "API-WorkerService" binPath="<PATTH_TO_YOUR_REPO>\bin\Release\net5.0\win10-x64\publish\restapi.exe"
```
Uninstall:
```winbatch
sc.exe delete "API-WorkerService"
```