# AGENTS Instructions

These guidelines apply to the entire repository.

## Style
- C# code follows the settings in `.editorconfig`: 4-space indentation, spaces instead of tabs, UTF-8 encoding, trim trailing whitespace, and include a final newline.

## Building and Testing
- The project builds with `dotnet`. Use `_windebug.bat`/`_winrelease.bat` on Windows or `_makedebug`/`_makerelease` on other platforms.
- There is no automated test suite; verify the project builds successfully after code changes with `dotnet build`.

## Repository Structure
- Core server logic lives under `Server`.
- Game scripts reside in the `Scripts` directory; organize new scripts within the existing folder hierarchy.

## Commit and PR Guidelines
- Use descriptive commit messages.
- When modifying code, run `dotnet build` to ensure the project compiles. Documentation-only changes do not require a build.

