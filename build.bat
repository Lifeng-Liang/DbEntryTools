@echo off
if not exist Tools md Tools

msbuild DbEntryTools.sln /t:Rebuild /p:Configuration=Release

cd AssemblyNameGetter\bin\Release
copy *.exe ..\..\..\Tools /Y
copy *.dll ..\..\..\Tools /Y
copy *.config ..\..\..\Tools /Y
cd ..\..\..\

cd SqlQuerier\bin\Release
copy *.exe ..\..\..\Tools /Y
copy *.dll ..\..\..\Tools /Y
copy *.config ..\..\..\Tools /Y
cd ..\..\..\

cd TemplateBuilder\bin\Release
copy *.exe ..\..\..\Tools /Y
copy *.dll ..\..\..\Tools /Y
copy *.config ..\..\..\Tools /Y
cd ..\..\..\

del Tools\*.vshost.*

echo done.
