using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FilmAPI
{
    public partial class ShowMovie : Form
    {
        public ShowMovie()
        {
            InitializeComponent();
        }

        public void ShowThisData(Movie movie)
        {
            textTitle.Text = movie.Title;
            textYear.Text = movie.Year;
            textPlot.Text = movie.Plot;
            textActors.Text = movie.Actors.Replace(", ", "\r\n");

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(movie.Poster);
            try
            {
                Bitmap b = new Bitmap(new MemoryStream(bytes));

                picMoviePoster.Image = b;
                picMoviePoster.Tag = movie.imdbID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda bilden\n" + ex.Message);
            }
            this.Show();
        }

        private void picMoviePoster_DoubleClick(object sender, EventArgs e)
        {
            // Code snatched from https://stackoverflow.com/a/4580317
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = $"https://www.imdb.com/title/{picMoviePoster.Tag}/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}