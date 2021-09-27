using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsHej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // radera allt i listan
            listBox1.DataSource=
                new Person[]
                {
                    new Person{Name="Clark Kent", Alias="Superman", City="Smallville"},
                    new Person{Name="Bruce Wayne", Alias="Batman", City="Gotham"},
                    new Person{Name="Oliver Queen", Alias="Green Arrow", City="Seattle"},
                };
            listBox1.ValueMember = "Alias";
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Person item = (Person)listBox1.SelectedItem;
            int index = listBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(checkBox1.Checked.ToString());
            textBox1.Enabled = checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person item = (Person)comboBox1.SelectedItem;
            int index = comboBox1.SelectedIndex;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var selectedDate = monthCalendar1.SelectionRange.Start;

            do
            {
                MessageBox.Show(selectedDate.ToString());

                var current = selectedDate.AddDays(1); // nästa dag

            } while (selectedDate <= monthCalendar1.SelectionRange.End);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hej på dig!");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string City { get; set; }
    }

}
