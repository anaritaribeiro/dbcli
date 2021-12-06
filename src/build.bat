echo off

dotnet publish .\NCommand.Template.Host -c Release -o .\artefactsdata\NCommand.Template.Host.all
dotnet publish .\NCommand.Template.Host -c Release -r win10-x64 --self-contained false /p:PublishSingleFile=true -o .\artefactsdata\NCommand.Template.Host.win10-x64
dotnet publish .\NCommand.Template.Host -c Release -r linux-x64 --self-contained false /p:PublishSingleFile=true -o .\artefactsdata\NCommand.Template.Host.linux-x64

pause