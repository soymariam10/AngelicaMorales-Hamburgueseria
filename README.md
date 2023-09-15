# skeleton-app-webapi

dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./API/ --output-dir ./Data/Migrations/

dotnet ef database update --project ./Persistencia/ --startup-project ./API/  

para actualizar: dotnet tool update --global dotnet -ef