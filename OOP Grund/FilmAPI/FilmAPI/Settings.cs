using System;
using System.IO;

namespace FilmAPI
{
    public static class Settings
    {
        public static string Key { get; set; } = "xxxxxxxxx";

        public static void LoadKey()
        {
            // För att undvika dela med sig av sina nycklar
            // https://www.zdnet.com/article/over-100000-github-repos-have-leaked-api-or-cryptographic-keys/
            //
            // Hämtar sökvägen till "Mina Dokument"
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Lägget till \APIKeys\OMDB.txt
            var file = Path.Combine(path, "APIKeys", "OMDB.txt");
            // Kollar om filen finns, och läser den i så fal
            if (File.Exists(file)) Key = File.ReadAllText(file);
        }
    }
}