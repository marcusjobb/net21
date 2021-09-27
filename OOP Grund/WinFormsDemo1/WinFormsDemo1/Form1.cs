using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo1
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textRuta.Text = "Hejsan hoppsan";
            string[] companies =
            {
                "Campus Mölndal",       // 0
                "Codic Education AB",   // 1
                "Net21"                 // 2
            };
            listBox1.Items.Clear();
            listBox1.Items.AddRange(companies);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("Check på");
            else
                MessageBox.Show("Check av");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    textRuta.Text = "Coolaste utbildningarna i stan!";
                    break;
                case 1:
                    textRuta.Text = "Coolaste utbildarna i stan!";
                    break;
                case 2:
                    textRuta.Text = "Coolaste kodarna ever!";
                    break;
                default:
                    break;
            }
        }
    }
}
