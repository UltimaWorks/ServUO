# ServUO Script Sandbox

This project provides a command-line environment for compiling and experimenting with ServUO scripts without launching the full server or connecting a game client.

## Goals

- Compile scripts using the existing `ScriptCompiler`.
- Run in isolation from `ServUO.exe`.
- Offer an interactive shell for invoking script functionality in a controlled environment.

## Current State

The sandbox compiles scripts and starts a basic interactive loop. Command execution is not yet implemented.

## Next Steps

1. Implement command parsing and execution to invoke script methods.
2. Provide facilities for loading individual scripts or subsets.
3. Add automated tests to validate script behavior.
4. Integrate logging and diagnostics to assist script development.

Run the sandbox with:

```bash
dotnet run --project Sandbox
```
