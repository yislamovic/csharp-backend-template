# csharp-backend-template
This is the begining of backend project..
New features will be implemented.

## Tech Stack:
- .NET 9.0
- Entity Framework Core
- PostgreSQL
- Docker

## Project Setup

### Prerequisites
Before running this project, make sure you have the following installed:
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [PostgreSQL](https://www.postgresql.org/download/) (or Docker for containerized setup)
- [Docker](https://www.docker.com/get-started/) (optional, for containerized development)

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd csharp-backend-template
   ```

2. **Install dependencies**
   ```bash
   cd BackendTemplate
   dotnet restore
   ```

3. **Database Setup**

   **Option A: Using PostgreSQL directly**
   - Install PostgreSQL on your machine
   - Create a database named `mydatabase`
   - Update the connection string in `appsettings.json` if needed:
     ```json
     "ConnectionStrings": {
       "ConnectionString": "Host=localhost;Port=5432;Username=postgres;Password=password;Database=mydatabase"
     }
     ```

   **Option B: Using Docker (Recommended)**
   ```bash
   # Run PostgreSQL in Docker
   docker run --name postgres-db -e POSTGRES_PASSWORD=password -e POSTGRES_DB=mydatabase -p 5432:5432 -d postgres:latest
   ```

4. **Run Database Migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the Application**
   ```bash
   dotnet run
   ```

   The API will be available at:
   - Swagger UI: https://localhost:7001/swagger
   - API Base URL: https://localhost:7001

### Development

- **Add new migrations**: `dotnet ef migrations add MigrationName`
- **Update database**: `dotnet ef database update`
- **Remove last migration**: `dotnet ef migrations remove`

### Project Structure
```
BackendTemplate/
├── Controller/          # API Controllers
├── Data/               # Database context and configurations
├── Models/             # Entity models
├── Migrations/         # Entity Framework migrations
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration file
```

### Environment Variables
The application uses the following configuration:
- Database connection string (configured in `appsettings.json`)
- Logging levels
- Allowed hosts

For production deployment, consider using environment variables or secure configuration management.