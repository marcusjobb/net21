// ----------------------------------------------------------------------------------------------
// This file "frmSearch.cs" is published under the GPLV3 license.
// Created 01/10/2021 10:33:57 by DESKTOP-QU5QA1S\marcu
// ----------------------------------------------------------------------------------------------

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
            int results = int.Parse(movies.totalResults);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResult movies = MovieAPI.SearchByTitle(txtSearch.Text);

            lstResults.Items.Clear();
            if (movies != null && movies.Response != "false")
            {
                int page = 1;
                int results = GetMaxHits(movies);

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
            foreach (Search movie in movies.Search)
            {
                ListThingy movieData = new()
                {
                    Title = movie.Type + " : " + movie.Title + " (" + movie.Year + ")" + "\t" + movie.imdbID,
                    IMDB = movie.imdbID
                };
                lstResults.Items.Add(movieData);
            }
            page++;
            movies = MovieAPI.SearchByTitle(txtSearch.Text, page);
            Thread.Sleep(10);
        }

        /// <summary>
        /// The frmSearch_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void frmSearch_Load(object sender, EventArgs e)
        {
            Text = "Sök filmer";
        }

        /// <summary>
        /// The lstResults_DoubleClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            ListThingy movieID = (ListThingy)lstResults.SelectedItem;
            Movie movie = MovieAPI.GetByIMDBCode(movieID.IMDB);

            ShowMovie frm = new ShowMovie();
            frm.ShowThisData(movie);
        }
    }
}
