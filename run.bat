@echo off

REM Build the solution
dotnet build CodingChallenge\WordCombinationFinder.csproj

REM Run the application
dotnet CodingChallenge\bin\Debug\net8.0\WordCombinationFinder.dll

pause