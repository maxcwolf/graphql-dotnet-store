

### GraphQL API built with .NET Core



1. `dotnet restore` to install dependencies.

2. `dotnet ef migrations <MigrationName>` to generate initial DB migration. (Must have a MySQL instance running)

3. `dotnet ef database update` to create the database, and update it with seed data.

4. `dotnet run` to start the application.