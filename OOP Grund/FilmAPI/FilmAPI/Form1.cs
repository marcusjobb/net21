using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Settings.LoadKey(); // Hämta nyckel från documents
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchResult movies = null;
            //switch (comboBox1.SelectedIndex)
            //{
            //    case 0: movie = MovieAPI.GetByTitle(textBox1.Text); break;
            //    case 1: movie = MovieAPI.GetByIMDBCode(textBox1.Text); break;
            //    default:
            //        break;
            //}

            movies = MovieAPI.SearchByTitle(textBox1.Text);

            //if (movie != null)
            //{
            //    listBox1.Items.Clear();
            //    listBox1.Items.Add(movie.Title);
            //    listBox1.Items.Add(movie.Actors);
            //}
            listBox1.Items.Clear();
            int page = 1;
            int results = int.Parse(movies.totalResults);
            while (page * 10 < results)
            {
                this.Text = "Reading " + (page * 10) + " of " + results;
                foreach (var movie in movies.Search)
                {
                    ListThingy movieData=new ListThingy();
                    movieData.Title = movie.Type + " : " + movie.Title + " (" + movie.Year + ")" + "\t" + movie.imdbID;
                    movieData.IMDB = movie.imdbID;
                    listBox1.Items.Add(movieData);
                }
                page++;
                movies = MovieAPI.SearchByTitle(textBox1.Text, page);
                Thread.Sleep(10);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ListThingy movieID = (ListThingy)listBox1.SelectedItem;
            var movie = MovieAPI.GetByIMDBCode(movieID.IMDB);

            ShowMovie frm = new ShowMovie();
            frm.ShowThisData(movie);

        }
    }
}
