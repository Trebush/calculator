# Calculator Application README

## Overview
This project is a simple calculator web application built using ASP.NET Core. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Project Structure
The project consists of the following main components:
- **Controllers**: Handles the user input and interaction.
- **Views**: Manages the presentation layer, displaying the user interface.
- **Models**: Defines the data structures used in the application.

## Files

### HomeController.cs
This file contains the main logic for handling requests and performing calculations. Below is a summary of the functionalities provided by this controller:

- **Index()**: 
  - HTTP GET request handler that returns the main view.
  
- **Privacy()**: 
  - Returns the privacy view.

- **Error()**: 
  - Handles errors and returns an error view with the request ID.

- **Index(int a, int b, string operation)**: 
  - HTTP POST request handler that performs the arithmetic operations based on the user input.
  - Supports operations: addition, subtraction, multiplication, and division.
  - Checks for division by zero to avoid errors.
  - Uses ViewBag to pass data between the controller and the view.
  - Logs exceptions and redirects to the error view in case of any issues.

## How to Run

1. **Prerequisites**:
   - .NET SDK installed on your machine.
   - Visual Studio or any other preferred IDE for ASP.NET development.

2. **Setup**:
   - Clone the repository.
   - Navigate to the project directory.
   - Restore the dependencies using `dotnet restore`.

3. **Build and Run**:
   - Build the project using `dotnet build`.
   - Run the project using `dotnet run`.
   - Open a web browser and navigate to `http://localhost:5000` to access the calculator application.

## Usage

1. Navigate to the main page of the calculator.
2. Enter two numbers in the provided input fields.
3. Select the desired operation (addition, subtraction, multiplication, or division) from the options.
4. Submit the form to view the result of the calculation.

## Error Handling
- The application includes basic error handling.
- If an error occurs during the processing of a request, an error message will be displayed, and the user will be redirected to the error view.
- Division by zero is specifically handled to prevent runtime exceptions.

## Logging
- Exceptions are logged using `System.Diagnostics.Debug.WriteLine`.
- It is recommended to integrate a proper logging framework (e.g., Serilog, NLog) for better logging capabilities in a production environment.
  
