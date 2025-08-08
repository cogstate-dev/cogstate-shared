# Cogstate.Shared

This repository contains shared models, enums, and logic for Cogstate projects.

## Project Structure

- **Cogstate.Shared.sln**: Solution file for the project.
- **Cogstate.Shared/**: Main project directory.
  - **Cogstate.Shared.csproj**: Project file.
  - **Models/**: Contains model classes and enums.
    - **Enums/**: Contains enum definitions (Country, Language, RuleCategory, RuleName).
  - **bin/**, **obj/**: Build and output directories (auto-generated).

## Build Instructions

1. Open the solution in [JetBrains Rider](https://www.jetbrains.com/rider/) or Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the solution using your IDE or via command line:
   ```sh
   dotnet build Cogstate.Shared.sln
   ```

## Usage

Reference the `Cogstate.Shared` project in your other .NET solutions to access shared models and enums.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

Specify your license here (e.g., MIT, Apache 2.0, etc.).

