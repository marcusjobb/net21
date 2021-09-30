using Newtonsoft.Json;
using System.Windows.Forms;

namespace FilmAPI
{
    internal static class MovieAPI
    {
        public static SearchResult SearchMovie(string url)
        {
            string json = string.Empty;
            SearchResult movie = null;

            try
            {
                using (var wc = new System.Net.WebClient())
                {
                    json = wc.DownloadString(url);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Något gick fel i nedladdningen av data\n" + ex.Message);
                return movie;
            }

            try
            {
                movie = JsonConvert.DeserializeObject<SearchResult>(json);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("JSON filen var skadad\n" + ex.Message);
                return movie;
            }

            return movie;
        }

        public static Movie GetMovie(string url)
        {
            string json = string.Empty;
            Movie movie = null;

            try
            {
                using (var wc = new System.Net.WebClient())
                {
                    json = wc.DownloadString(url);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Något gick fel i nedladdningen av data\n" + ex.Message);
                return movie;
            }

            try
            {
                movie = JsonConvert.DeserializeObject<Movie>(json);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("JSON filen var skadad\n" + ex.Message);
                return movie;
            }

            return movie;
        }

        public static Movie GetByIMDBCode(string id)
        {
            return GetMovie($"http://www.omdbapi.com/?apikey={Settings.Key}&i={id}");
        }

        public static Movie GetByTitle(string title)
        {
            return GetMovie($"http://www.omdbapi.com/?apikey={Settings.Key}&t=" + title);
        }

        public static SearchResult SearchByTitle(string title, int page = 1)
        {
            return SearchMovie($"http://www.omdbapi.com/?apikey={Settings.Key}&page={page}&s={title}");
        }
    }
}