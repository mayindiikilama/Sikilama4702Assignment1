# Vehicle Maintenance Microservice

**Student Name:** Samson Ikilama
**Student Number:** 8904702

## Project Description

The Vehicle Maintenance Microservice is a RESTful Web API i built using ASP.NET Core and Entity Framework Core. This service allows us to use and manage vehicle maintenance records by performing CRUD operations. My data is stored in an SQLite database and can be tested and documented using Swagger.

## Domain Model

### MaintenanceRecord

The MaintenanceRecord model represents a vehicle maintenance entry and contains the following properties:

| Property    | Type     | Description                                   |
| ----------- | -------- | --------------------------------------------- |
| Id          | int      | Unique identifier for each maintenance record |
| VehicleName | string   | Name of the vehicle being serviced            |
| ServiceType | string   | Type of maintenance performed                 |
| Cost        | decimal  | Cost of the maintenance service               |
| ServiceDate | DateTime | Date the service was completed                |

### Validation

* VehicleName is required.
* ServiceType is required.
* Cost must be a value between 0 and 10,000.

## Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQLite Database
* Swagger/OpenAPI
* Git Version Control

## API Endpoints

| Method | Endpoint              | Description                           |
| ------ | --------------------- | ------------------------------------- |
| GET    | /api/Maintenance      | Retrieve all maintenance records      |
| GET    | /api/Maintenance/{id} | Retrieve a maintenance record by ID   |
| POST   | /api/Maintenance      | Create a new maintenance record       |
| PUT    | /api/Maintenance/{id} | Update an existing maintenance record |
| DELETE | /api/Maintenance/{id} | Delete a maintenance record           |

## Running the Project


* .NET 8 SDK
* Visual Studio 2022 or Visual Studio Code

### Steps

1. Clone or extract the project folder.

2. Open the project in Visual Studio.

3. Restore NuGet packages:

   ```
   dotnet restore
   ```

4. Apply database migrations:

   ```
   dotnet ef database update
   ```

5. Run the application:

   ```
   dotnet run
   ```

6. Open Swagger in your browser:

   ```
   https://localhost:7232/swagger
   ```

7. Test the API endpoints using Swagger.

## Database

The application uses SQLite for persistent storage. The database file is automatically created after running migrations.

Database file:

```
maintenance.db
```

## Git Version Control

Git was used throughout development to track project progress and maintain version history through multiple meaningful commits.

## Notes

* I used SQLite was selected for simplicity and portability.
* I used Swagger for testing and documentation of API endpoints.
* All CRUD operations return appropriate HTTP status codes.
* Entity Framework Core migrations were used to create and manage the database schema.

