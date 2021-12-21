// -----------------------------------------------------------------------------------------------
//  AddRemoveCountry.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Helpers;
    using FamilyTreeWF.Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

    public partial class AddRemoveCountry : Form
    {
        private List<Country> countries = new();
        private int id = 0;
        private string name = "";

        public AddRemoveCountry(List<Country> countryList)
        {
            countries = countryList;
            InitializeComponent();
            SetupDataForForm();
        }
        public AddRemoveCountry()
        {
            InitializeComponent();
            SetupDataForForm();
        }

        private void B_addCountry_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cb_countries.Text)) MessageBox.Show("Can not add a city without a name.", "Input error");
            else
            {
                var country = countries.Where(c => c.Name == cb_countries.Text).FirstOrDefault(new Country() { CountryId = 0, Name = cb_countries.Text });
                if (country.CountryId == 0) AddCountry(country);
                else MessageBox.Show($"A country with the name {country.Name} already exists.", "Duplicate country");
            }
        }

        private void RemoveCountry(Country country)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            const MessageBoxIcon icon = MessageBoxIcon.Warning;
            var answer = MessageBox.Show($"Really delete {country.Name}?\n This action cannot be undone.", "Confirm delete", buttons, icon);
            if (answer == DialogResult.Yes)
            {
                var result = CountryHelper.RemoveCountry(country);
                if (result > 0) MessageBox.Show($"Country {country.Name} removed from database.", "Success");
                this.Close();
            }
        }
        private void RenameCountry(Country country)
        {
            country.Name = country.Name.Trim();
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var answer = MessageBox.Show($"Rename country {this.name} to {country.Name}?", "Confirm rename", buttons);
            if (answer == DialogResult.Yes)
            {
                int result = CountryHelper.RenameCountry(country);
                if(result>0)MessageBox.Show($"Country {this.name} renamed to {country.Name}.", "Success");
                this.Close();
            }
        }

        private void AddCountry(Country country)
        {
            country.Name = country.Name.Trim();
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var answer = MessageBox.Show($"Create country {country.Name}?", "Confirm add", buttons);
            if (answer == DialogResult.Yes)
            {
                country = CountryHelper.AddCountry(country);
                MessageBox.Show($"City {country.Name} added to the database with Id {country.CountryId}", "Success");
                this.Close();
            }
        }
        private void SetupDataForForm()
        {
            if (countries.Count == 0) countries = CountryHelper.GetAllCountries();
            cb_countries.DataSource = null;
            cb_countries.DataSource = countries;
            cb_countries.DisplayMember = "Name";
            cb_countries.ValueMember = "CountryId";
            cb_countries.SelectedIndex = -1;
        }
        private void Cb_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (cb.SelectedIndex != -1)
            {
                if (cb.SelectedValue is int countryid)
                {
                    this.name = cb.Text;
                    this.id = countryid;
                    b_removeEdit.Text = "Remove";
                    b_add.Enabled = false;
                }
            }
        }
        private void B_removeEdit_Click(object sender, EventArgs e)
        {
            var country = countries.Find(c => c.CountryId == this.id);
            if (country != null)
            {
                country.Name = cb_countries.Text;
                if (b_removeEdit.Text == "Remove") RemoveCountry(country);
                else RenameCountry(country);
            }
        }
        private void Cb_countries_TextChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (!string.IsNullOrEmpty(this.name))
            {
                if (cb.Text == this.name)
                {
                    b_removeEdit.Text = "Remove";
                    b_add.Enabled = false;
                }
                else if (cb.Text.Trim().Length < 2)
                {
                    b_add.Enabled = false;
                    b_removeEdit.Enabled = false;
                }
                else
                {
                    b_add.Enabled = true;
                    b_removeEdit.Enabled = true;
                    b_removeEdit.Text = "Rename";
                }
            }
        }
    }
}
