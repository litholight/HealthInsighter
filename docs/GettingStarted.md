# Getting Started with HealthInsighter

Welcome to the `HealthInsighter` project, a .NET-based application designed for health data management and analysis. This document will guide you through setting up the project on your local machine, building the application, and running it for development and testing purposes.

## Prerequisites

Before you start, ensure you have the following installed on your development machine:

- **.NET SDK 8.0**: The software development kit for building and running .NET applications. [Download here](https://dotnet.microsoft.com/download).
- **Visual Studio 2022** or **Visual Studio Code**: Integrated development environments (IDE) recommended for .NET development. [VS 2022](https://visualstudio.microsoft.com/vs/) | [VS Code](https://code.visualstudio.com/Download).
- **SQL Server** or **SQLite**: Depending on your development setup, you may need a database. SQL Server Express can be used for local development. [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads).

## Cloning the Repository

First, clone the `HealthInsighter` repository to your local machine using Git:

```bash
git clone https://your-repository-url/HealthInsighter.git
cd HealthInsighter
```

Replace `https://your-repository-url/HealthInsighter.git` with the actual URL of your Git repository.

## Project Structure

The solution contains several projects, organized as follows:

- **HealthInsighter.Core**: The core project containing business logic and domain models.
- **HealthInsighter.Data**: Handles data access and persistence.
- **HealthInsighter.Infrastructure**: Implements infrastructure services like logging and external API integrations.
- **HealthInsighter.Web**: The Blazor web application for the user interface.
- **HealthInsighter.Tests**: Contains unit and integration tests for the application.

## Setting Up the Development Environment

1. **Install the Prerequisites**: Make sure all required software is installed on your development machine.
2. **Open the Solution**: Open `HealthInsighter.sln` in Visual Studio 2022 or Visual Studio Code with the C# extension installed.
3. **Restore NuGet Packages**: Ensure all NuGet packages are restored to resolve any dependencies.

## Building the Application

To build the application, use the following .NET CLI command:

```bash
dotnet build
```

Alternatively, you can build the solution using the build functionality in Visual Studio or VS Code.

## Running the Application

To run the `HealthInsighter.Web` project, navigate to the project directory and use the .NET CLI:

```bash
cd src/HealthInsighter.Web
dotnet run
```

This command will start the Blazor Server application. You can access it by navigating to `https://localhost:5001` in your web browser.

## Next Steps

- **Explore the Application**: Try adding, modifying, and deleting health data to see how the application responds.
- **Run the Tests**: Execute the tests in the `HealthInsighter.Tests` project to ensure everything is working correctly.
- **Read the Documentation**: Familiarize yourself with the architecture and project structure by reading the `Architecture.md` document.

## Need Help?

If you encounter any issues or have questions, please refer to the project's README or reach out to the project maintainers.