﻿// -----------------------------------------------------------------------------------------------
//  Form1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace WinFormsProperties
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Avbryt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;
            progressBar1.Minimum = 0;

            numericUpDown1.Maximum = 1000;
            numericUpDown1.Minimum = 0;
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        }

    }
}
