# Book API

This repository contains a RESTful API built with .NET and C# for managing a collection of books. The Book API provides endpoints for creating, reading, updating, and deleting book records, allowing for efficient management of book data.

## Features:
- **CRUD Operations**: Perform Create, Read, Update, and Delete operations on book records.
- **SQL Integration**: Uses Entity Framework Core with SQL Server for robust data storage and management.
- **Scalable and Extensible**: Built on .NET, ensuring scalability and easy integration with other services.
- **Secure**: Includes basic security features to protect data integrity.
- **Easy Deployment**: Configured for deployment on Azure, providing cloud scalability and reliability.

## Endpoints:
- `GET /api/books`: Retrieves a list of all books.
- `GET /api/books/{id}`: Retrieves a specific book by ID.
- `POST /api/books`: Adds a new book to the collection.
- `PUT /api/books/{id}`: Updates an existing book by ID.
- `DELETE /api/books/{id}`: Deletes a book by ID.

## Getting Started:
1. Clone the repository.
2. Update the connection string in `appsettings.json` to point to your SQL Server instance.
3. Run the following commands to apply migrations and start the API:
   ```bash
   dotnet ef database update
   dotnet run
