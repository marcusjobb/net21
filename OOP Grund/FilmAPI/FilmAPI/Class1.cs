using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAPI
{

    public class Rating
    {
        public string Source { get; set; }="";
        public string Value { get; set; }="";
    }

    class MovieAPI
    {
        private Movie GetMovie(string url)
        {
            string json = string.Empty;
            using (var wc = new System.Net.WebClient())
            {
                json = wc.DownloadString(url);
            }
            return JsonConvert.DeserializeObject<Movie>(json);
        }
    }

    public static class Settings
    {
        public static string Key { get; set; } = "xxxxxxxxx";

        public static void LoadKey()
        {
            // Hämtar sökvägen till "Mina Dokument"
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Lägget till \APIKeys\OMDB.txt
            var file = Path.Combine(path, "APIKeys", "OMDB.txt");
            // Läser filen
            Key = File.ReadAllText(file);
        }
    }

}
