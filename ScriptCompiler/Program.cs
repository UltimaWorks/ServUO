using System;
using System.IO;
using System.Reflection;
using Server;

namespace ScriptCompilerCli
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            var debug = false;
            var cache = true;

            foreach (var arg in args)
            {
                if (string.Equals(arg, "-debug", StringComparison.OrdinalIgnoreCase))
                {
                    debug = true;
                }
                else if (string.Equals(arg, "-release", StringComparison.OrdinalIgnoreCase))
                {
                    debug = false;
                }
                else if (string.Equals(arg, "-nocache", StringComparison.OrdinalIgnoreCase))
                {
                    cache = false;
                }
            }

            var baseDir = Directory.GetCurrentDirectory();
            var field = typeof(Core).GetField("_BaseDirectory", BindingFlags.Static | BindingFlags.NonPublic);
            field?.SetValue(null, baseDir);

            Core.Assembly = typeof(Core).Assembly;

            var success = ScriptCompiler.Compile(debug, cache);

            return success ? 0 : 1;
        }
    }
}
