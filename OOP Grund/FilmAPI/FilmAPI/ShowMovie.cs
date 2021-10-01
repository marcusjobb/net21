// -----------------------------------------------------------------------------------------------
//  ShowMovie.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FilmAPI
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;

    public partial class ShowMovie : Form
    {
        public ShowMovie() => InitializeComponent();

        public void ShowThisData(Movie movie)
        {
            textTitle.Text = movie.Title;
            textYear.Text = movie.Year;
            textPlot.Text = movie.Plot;
            textActors.Text = movie.Actors.Replace(", ", "\r\n");

            var wc = new WebClient();
            var bytes = wc.DownloadData(movie.Poster);
            try
            {
                var b = new Bitmap(new MemoryStream(bytes));

                MoviePoster.Image = b;
                MoviePoster.Tag = movie.imdbID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda bilden\n" + ex.Message);
            }
            Show();
        }

        private void MoviePoster_DoubleClick(object sender, EventArgs e)
        {
            // Code snatched from https://stackoverflow.com/a/4580317
            Process myProcess = new();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = $"https://www.imdb.com/title/{MoviePoster.Tag}/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}