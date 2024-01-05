PROJECT_NAME = E-Commerce

.PHONY: build run 

build:
	dotnet build $(PROJECT_NAME).csproj

run:
	dotnet run --project $(PROJECT_NAME).csproj --urls "https://localhost:7060;http://localhost:5037"

migrateApp: 
	dotnet ef migrations add $(filter-out $@,$(MAKECMDGOALS)) --context ECommerceDbContext --project $(PROJECT_NAME).csproj
	dotnet ef database update --context ECommerceDbContext --project $(PROJECT_NAME).csproj

migrateUser:
	dotnet ef migrations add $(filter-out $@,$(MAKECMDGOALS)) --context SecurityDbContext --project $(PROJECT_NAME).csproj
	dotnet ef database update --context SecurityDbContext --project $(PROJECT_NAME).csproj

delete:
	dotnet ef database drop --context ECommerceDbContext --project $(PROJECT_NAME).csproj
	dotnet ef database drop --context SecurityDbContext --project $(PROJECT_NAME).csproj

reset: 
	rm -rf Migrations
	rm -rf Database.db
	dotnet ef migrations add init --context ECommerceDbContext --project $(PROJECT_NAME).csproj
	dotnet ef migrations add init2 --context SecurityDbContext --project $(PROJECT_NAME).csproj
	dotnet ef database update --context ECommerceDbContext --project $(PROJECT_NAME).csproj
	dotnet ef database update --context SecurityDbContext --project $(PROJECT_NAME).csproj
	dotnet build $(PROJECT_NAME).csproj
	dotnet run --project $(PROJECT_NAME).csproj --urls "https://localhost:7060;http://localhost:5037"