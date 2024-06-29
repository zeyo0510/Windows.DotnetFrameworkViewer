@echo off
set MSBuild=%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe
%MSBuild% Windows.DotnetFrameworkViewer.csproj
pause