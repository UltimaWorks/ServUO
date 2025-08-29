using System;
using System.IO;
using System.Reflection;
using Server;

namespace Sandbox
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ServUO Script Sandbox");

            var baseDir = Directory.GetCurrentDirectory();
            var field = typeof(Core).GetField("_BaseDirectory", BindingFlags.Static | BindingFlags.NonPublic);
            field?.SetValue(null, baseDir);

            Core.Assembly = typeof(Core).Assembly;

            var compiled = ScriptCompiler.Compile(debug: true, cache: false);

            if (!compiled)
            {
                Console.WriteLine("Failed to compile scripts.");
                return;
            }

            Console.WriteLine("Scripts compiled. Type 'exit' to quit.");

            while (true)
            {
                Console.Write("> ");
                var line = Console.ReadLine();
                if (string.Equals(line, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.WriteLine("Command execution not yet implemented.");
            }
        }
    }
}
