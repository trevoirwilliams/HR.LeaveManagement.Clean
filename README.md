# Educational .NET Core Leave Management System

This repository contains the source code for an Educational .NET Core Leave Management System built using Clean Architecture. The project uses CQRS, AutoMapper, Blazor, .NET API, and EF Core. It also includes unit and integration tests.

The project was created to support the course ASP.NET Core - SOLID and Clean Architecture, which can be found at this URL: https://www.udemy.com/course/aspnet-core-solid-and-clean-architecture-net-5-and-up/?referralCode=64873CEC8BFDA7423006.

## Table of Contents

- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Code Samples](#code-samples)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [License](#license)

## Technologies

The project uses the following technologies:

- .NET Core (6/7/8)
- CQRS
- AutoMapper
- Blazor
- .NET API
- EF Core
- xUnit
- Moq

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio or another IDE of your choice.
3. Restore the NuGet packages.
4. Set the startup projects to `HR.LeaveManagement.Api` and `HR.LeaveManagement.BlazorUI`.
5. Run the project.

## Project Structure

The project is organized using the Clean Architecture principles. The solution is composed of the following projects:

- `HR.LeaveManagement.Application`: Contains the application layer of the project, which contains the application logic and interfaces.
- `HR.LeaveManagement.Domain`: Contains the domain layer of the project, which contains the domain models and business rules.
- `HR.LeaveManagement.Infrastructure`: Contains the infrastructure layer of the project, which contains the implementation of the interfaces defined in the application layer.
- `HR.LeaveManagement.Api`: Contains the API layer of the project
- `HR.LeaveManagement.BlazorUI`: Contains the Blazor client application

## Code Samples

The project contains code samples for several areas of .NET Core development, including:

- CQRS
- AutoMapper
- Blazor
- .NET API
- EF Core
- Unit Testing
- Integration Testing

Each project and code sample is well-documented, and the code is designed to be easy to read and follow.

## Documentation

The repository contains documentation for each of the code samples, including:

- An overview of the sample and its intended use case
- Installation and configuration instructions
- Code walkthroughs and explanations
- Best practices and tips for working with the sample

The documentation is designed to be accessible to developers of all skill levels, from beginners to advanced users.

## Contributing

Contributions to this repository are welcome. If you have a code sample or educational resource that you would like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Make your changes and commit them to your branch.
4. Submit a pull request.

Please ensure that your contributions adhere to the repository's code of conduct and that they are well-documented and follow best practices.

## License

This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.
