# Asp.Net Core Web API N-Tier

.NET Core N-Tier architecture Web Api sample project.

## Setup

- Uses PostgreSQL as local LocalDB you can install it from
[here ](https://www.postgresql.org).
- You can change connection string from *appsettings.json* within *aspnetcore-n-tier.API*
- Apply database migrations to create the tables. From a command line within the **aspnetcore-n-tier.DAL** project folder use the dotnet CLI to run :

```
dotnet ef --startup-project ../aspnetcore-n-tier.API migrations add initial --context AspNetCoreNTierDbContext
```
```
dotnet ef --startup-project ../aspnetcore-n-tier.API migrations add initial --context AspNetCoreNTierDbContext
```
## Layers

- aspnetcore-n-tier.API - Presentation Layer *.Net Core Web API project*.
- aspnetcore-n-tier.BLL - Business Logic Layer responsible for data exchange between DAL and Presentation Layer.
- aspnetcore-n-tier.DAL - Data Access Layer responsible for interacting database. *Generic repositories* have been used.
- aspnetcore-n-tier.DTO - Data transfer objects.
- aspnetcore-n-tier.Entity - Database entities.
- aspnetcore-n-tier.IoC - Responsible for *dependency injection* it has ```DependencyInjection``` class and ```InjectDependencies``` method in it.
- aspnetcore-n-tier.Utility - Has *AutoMapperProfiles* (You can get detailed information about *Automapper* from [here](https://automapper.org/)) class in it.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Show your support

Give a ⭐️ if this project helped you!
