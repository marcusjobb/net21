using System;
using System.Threading;
using System.Windows.Forms;

namespace FilmAPI
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            Settings.LoadKey(); // Hämta nyckel från documents
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResult movies = null;

            movies = MovieAPI.SearchByTitle(txtSearch.Text);

            lstResults.Items.Clear();
            if (movies != null && movies.Response != "false")
            {
                int page = 1;
                int results = int.Parse(movies.totalResults);
                if (results > 250) results = 250;
                while (page * 10 < results)
                {
                    this.Text = "Reading " + (page * 10) + " of " + results;
                    foreach (var movie in movies.Search)
                    {
                        ListThingy movieData = new ListThingy();
                        movieData.Title = movie.Type + " : " + movie.Title + " (" + movie.Year + ")" + "\t" + movie.imdbID;
                        movieData.IMDB = movie.imdbID;
                        lstResults.Items.Add(movieData);
                    }
                    page++;
                    movies = MovieAPI.SearchByTitle(txtSearch.Text, page);
                    Thread.Sleep(10);
                }
            }
            this.Text = "Sök filmer";
        }

        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            ListThingy movieID = (ListThingy)lstResults.SelectedItem;
            var movie = MovieAPI.GetByIMDBCode(movieID.IMDB);

            ShowMovie frm = new ShowMovie();
            frm.ShowThisData(movie);
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.Text = "Sök filmer";
        }
    }
}