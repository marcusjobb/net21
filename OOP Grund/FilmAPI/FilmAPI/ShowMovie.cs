using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            textActors.Text = movie.Actors.Replace(",", "\r\n");

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(movie.Poster);
            Bitmap b = new Bitmap(new MemoryStream(bytes));

            pictureBox1.Image = b;
            pictureBox1.Tag = movie.imdbID;
            this.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = $"https://www.imdb.com/title/{pictureBox1.Tag}/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
