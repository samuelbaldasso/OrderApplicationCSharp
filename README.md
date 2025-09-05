# OrderApplicationCSharp

A simple .NET 9 Web API for managing orders, built with Entity Framework Core and following clean architecture principles.

## Features

- CRUD operations for orders (Pedidos)
- Repository and Service layers
- RESTful API with controllers
- CORS enabled for Angular frontend
- Unit tests for services, repositories, and controllers

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- SQL Server (or use InMemory for tests)

### Setup

1. Clone the repository:
   ```sh
   git clone <repo-url>
   cd Pedidos-C-
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Update the connection string in `appsettings.json` if needed.
4. Run database migrations (if using SQL Server):
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run --project pedidos-app.csproj
   ```

### Running Tests

Unit tests are in the `Pedidos.Tests` project:

```sh
cd Pedidos.Tests
dotnet test
```

## Project Structure

- `src/` - Application source code
  - `entities/` - Entity models
  - `repositories/` - Repository interfaces and implementations
  - `services/` - Service interfaces and implementations
  - `controllers/` - API controllers
- `Pedidos.Tests/` - Unit tests
- `test/` - (Legacy or extra tests)
- `wwwroot/` - Static files

## API Endpoints

- `GET /api/pedidos` - List all orders
- `POST /api/pedidos` - Create a new order
- ... (extend as needed)

## License

MIT
