echo off

dotnet publish .\DbCli.Host -c Release -o .\artefactsdata\DbCli.Host.all
dotnet publish .\DbCli.Host -c Release -r win10-x64 --self-contained false /p:PublishSingleFile=true -o .\artefactsdata\DbCli.Host.win10-x64
dotnet publish .\DbCli.Host -c Release -r linux-x64 --self-contained false /p:PublishSingleFile=true -o .\artefactsdata\DbCli.Host.linux-x64

pause