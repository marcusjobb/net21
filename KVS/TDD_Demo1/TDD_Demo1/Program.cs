// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Namespace
{
    public static class Filereader
    {
        public static string Read (string filename)
        {
            var file = string.Empty;
            if (File.Exists(filename))
            {
                file = File.ReadAllText(filename);
            }

            return file;
        }
    }

    internal static class Program
    {
        private static void Main ()
        {
        }
    }
}