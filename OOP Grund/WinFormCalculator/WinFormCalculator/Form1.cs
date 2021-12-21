// -----------------------------------------------------------------------------------------------
//  Form1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class Form1 : Form
    {
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }


        private void Plus_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double value);
            memory += value;
            label1.Text = memory.ToString();
            textBox1.Text = "";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double value);
            memory -= value;
            label1.Text = memory.ToString();
            textBox1.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double value);
            if (value == 0)
            {
                MessageBox.Show("Du kan inte dividera med noll");
                return;
            }
            memory /= value;
            label1.Text = memory.ToString();
            textBox1.Text = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double value);
            memory *= value;
            label1.Text = memory.ToString();
            textBox1.Text = "";
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            memory = 0;
            label1.Text = "";
            textBox1.Text = "";
        }
    }
}
