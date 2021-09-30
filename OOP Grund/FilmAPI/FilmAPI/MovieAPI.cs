using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAPI
{

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

}
