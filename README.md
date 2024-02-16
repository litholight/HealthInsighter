# HealthInsighter

HealthInsighter is a .NET 8.0 application designed for health data management and analysis. It aims to harness the power of scientific wellness, providing insights through the storage, processing, and visualization of health-related data. By leveraging advanced data analysis techniques and the Blazor framework for an interactive web interface, HealthInsighter seeks to empower individuals to take an active role in managing their health.

## Scientific Wellness and HealthInsighter

Scientific wellness, as championed in "The Age of Scientific Wellness," emphasizes the importance of personalized health and the role each person plays in managing their wellness. This emerging field combines data analysis, personal health monitoring, and the latest scientific research to optimize individual health outcomes.

HealthInsighter aligns with these principles by enabling users to:
- **Track and Analyze Personal Health Data**: From steps and heart rate to sleep patterns and blood samples, HealthInsighter facilitates a comprehensive view of one's health data.
- **Discover Personal Health Insights**: Through data visualization and analysis, the application reveals trends, patterns, and potential areas for improvement in the user's health.
- **Empower Personalized Health Decisions**: Equipped with data-driven insights, users can make informed decisions about lifestyle changes, preventive measures, and when to seek professional advice.

Inspired by "The Age of Scientific Wellness," HealthInsighter strives to be a tool that individuals can use to contribute to their personalized health journey, embodying the spirit of active participation and empowerment in one's wellness.

## Getting Started

These instructions will guide you through setting up the project on your local machine for development and testing purposes.

### Prerequisites

Before you begin, ensure you have the following software installed on your machine:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) - The software development kit for building and running .NET applications.
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/Download) - Recommended IDEs for .NET development.

### Installation

To set up the project for development, follow these steps:

1. **Clone the repository** to your local machine:

   ```bash
   git clone https://your-repository-url/HealthInsighter.git
   cd HealthInsighter
   ```

   Replace `https://your-repository-url/HealthInsighter.git` with the actual URL of your Git repository.

2. **Build the solution** to restore NuGet packages and compile the projects:

   ```bash
   dotnet build
   ```

3. **Run the application** by navigating to the `HealthInsighter.Web` project directory and using the .NET CLI:

   ```bash
   cd src/HealthInsighter.Web
   dotnet run
   ```

   Access the application by navigating to `https://localhost:5001` in your web browser.

## Project Structure

The solution is organized into several projects, each serving a distinct role within the application:

- `HealthInsighter.Core` - Contains the domain models, interfaces, and business logic.
- `HealthInsighter.Data` - Manages data access and persistence.
- `HealthInsighter.Infrastructure` - Provides implementations for cross-cutting concerns.
- `HealthInsighter.Web` - The Blazor Server application serving the user interface.
- `HealthInsighter.Tests` - Contains unit and integration tests for the application.

For a detailed overview of the project structure and architecture, refer to the [ProjectStructure.md](docs/ProjectStructure.md) and [Architecture.md](docs/Architecture.md) documents.

## Contributing

We welcome contributions to the HealthInsighter project. Whether you're interested in fixing bugs, adding new features, or improving documentation, your help is appreciated. Please read

[CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct and the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.