PROJECT_NAME = E-Commerce
MIGRATION_NAME ?= AddingUserModel

.PHONY: build run migrate update delete

build:
	dotnet build $(PROJECT_NAME).csproj

run:
	dotnet run --project $(PROJECT_NAME).csproj --urls "https://localhost:7060;http://localhost:5037"

migrate:
	dotnet ef migrations add $(MIGRATION_NAME) --project $(PROJECT_NAME).csproj
	dotnet ef database update --project $(PROJECT_NAME).csproj

update:
	dotnet ef database update --project $(PROJECT_NAME).csproj

delete:
	dotnet ef database drop --project $(PROJECT_NAME).csproj
