del /F /Q Raps.csproj.user
del /F /Q bin\*.pdb
del /F /Q bin\*.xml
del /F /Q bin\*.config
del /F /Q bin\*.dll
del /F /Q bin\roslyn\*.*

rd /S /Q .vs
rd /S /Q obj
rd /S /Q packages
rd /S /Q bin\roslyn
