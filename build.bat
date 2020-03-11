dotnet build

cd src/ui/ng-alain
npm install && npm run-script build && del ..\..\CPS.Web\wwwroot\* /q && copy dist\* ..\..\CPS.Web\wwwroot\ && cd ..\..\CPS.Web && dotnet build -c Release && dotnet publish -c Release && cd ..\..\ && docker build -t cps.web .
