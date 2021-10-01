// -----------------------------------------------------------------------------------------------
//  FormSearch.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FilmAPI
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="FormSearch" />.
    /// </summary>
    public partial class FormSearch : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSearch"/> class.
        /// </summary>
        public FormSearch()
        {
            InitializeComponent();
            Settings.LoadKey(); // Hämta nyckel från documents
        }

        /// <summary>
        /// The GetMaxHits.
        /// </summary>
        /// <param name="movies">The movies<see cref="SearchResult"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        private static int GetMaxHits(SearchResult movies)
        {
            var results = int.Parse(movies.totalResults);
            if (results > 250)
            {
                results = 250;
            }

            return results;
        }

        /// <summary>
        /// Sökknappen.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var movies = MovieAPI.SearchByTitle(txtSearch.Text);

            ListResults.Items.Clear();
            if (movies != null && movies.Response != "false")
            {
                var page = 1;
                var results = GetMaxHits(movies);

                while (page * 10 < results)
                {
                    FillListbox(ref movies, ref page, results);
                }
            }
            Text = "Sök filmer";
        }

        /// <summary>
        /// Fyller listan med filmförslag.
        /// </summary>
        /// <param name="movies">filmer.</param>
        /// <param name="page">sida.</param>
        /// <param name="results">filmförslag.</param>
        private void FillListbox(ref SearchResult movies, ref int page, int results)
        {
            Text = "Reading " + (page * 10) + " of " + results;
            foreach (var movie in movies.Search)
            {
                ListThingy movieData = new()
                {
                    Title = $"{movie.Type} : {movie.Title} ({movie.Year})\t{movie.imdbID}",
                    IMDB = movie.imdbID
                };
                ListResults.Items.Add(movieData);
            }
            page++;
            movies = MovieAPI.SearchByTitle(txtSearch.Text, page);
            Thread.Sleep(10);
        }

        /// <summary>
        /// The FormSearch_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FormSearch_Load(object sender, EventArgs e) => Text = "Sök filmer";

        /// <summary>
        /// The ListResults_DoubleClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ListResults_DoubleClick(object sender, EventArgs e)
        {
            var movieID = (ListThingy)ListResults.SelectedItem;
            var movie = MovieAPI.GetByIMDBCode(movieID.IMDB);

            var frm = new ShowMovie();
            frm.ShowThisData(movie);
        }
    }
}