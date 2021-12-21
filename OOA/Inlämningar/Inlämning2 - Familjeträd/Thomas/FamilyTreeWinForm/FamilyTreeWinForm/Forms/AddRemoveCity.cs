// -----------------------------------------------------------------------------------------------
//  AddRemoveCity.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Helpers;
    using FamilyTreeWF.Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddRemoveCity : Form
    {
        private List<City> cities = new();
        private int id = 0;
        private string name = "";

        public AddRemoveCity(List<City> cityList)
        {
            cities = cityList;
            InitializeComponent();
            SetupDataForForm();
        }
        public AddRemoveCity()
        {
            InitializeComponent();
            SetupDataForForm();
        }

        private void B_addCity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cb_cities.Text)) MessageBox.Show("Can not add a city without a name.", "Input error");
            else
            {
                var city = cities.Where(c => c.Name == cb_cities.Text).FirstOrDefault(new City() { CityId = 0, Name = cb_cities.Text });
                if (city.CityId == 0) AddCity(city);
                else MessageBox.Show($"A city with the name {city.Name} already exists.", "Duplicate city");
            }
        }

        private void RemoveCity(City city)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            const MessageBoxIcon icon = MessageBoxIcon.Warning;
            var answer = MessageBox.Show($"Really delete {city.Name}?\n This action cannot be undone.", "Confirm delete", buttons, icon);
            if (answer == DialogResult.Yes)
            {
                var result = CityHelper.RemoveCity(city);
                if (result > 0) MessageBox.Show($"City {city.Name} removed from database.", "Success");
                this.Close();
            }
        }
        private void RenameCity(City city)
        {
            city = TidyUpCityName(city);
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var answer = MessageBox.Show($"Rename city {this.name} to {city.Name}?", "Confirm rename", buttons);
            if (answer == DialogResult.Yes)
            {
                int result = CityHelper.RenameCity(city);
                if (result>0)MessageBox.Show($"City {this.name} renamed to {city.Name}.", "Success");
                this.Close();
            }
        }

        private void AddCity(City city)
        {
            city = TidyUpCityName(city);
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var answer = MessageBox.Show($"Create city {city.Name}?", "Confirm add", buttons);
            if (answer == DialogResult.Yes)
            {
                city = CityHelper.AddCity(city);
                MessageBox.Show($"City {city.Name} added to the database with Id {city.CityId}", "Success");
                this.Close();
            }
        }

        private static City TidyUpCityName(City city)
        {
            string name = city.Name.Trim();
            if (name.Length >= 2 && !name.Contains(' ') && !string.Equals(name, name.ToUpper())) name = name[..1].ToUpper() + name[1..].ToLower();
            city.Name = name;
            return city;
        }

        private void SetupDataForForm()
        {
            if (cities.Count == 0) cities = CityHelper.GetAllCities();
            cb_cities.DataSource = null;
            cb_cities.DataSource = cities;
            cb_cities.DisplayMember = "Name";
            cb_cities.ValueMember = "CityId";
            cb_cities.SelectedIndex = -1;
        }

        private void Cb_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (cb.SelectedIndex != -1)
            {
                if (cb.SelectedValue is int cityid)
                {
                    this.name = cb.Text;
                    this.id = cityid;
                    b_removeEdit.Text = "Remove";
                    b_add.Enabled = false;
                }
            }
        }

        private void B_removeEdit_Click(object sender, EventArgs e)
        {
            var city = cities.Find(c => c.CityId == this.id);
            if (city != null)
            {
                city.Name = cb_cities.Text;
                if (b_removeEdit.Text == "Remove") RemoveCity(city);
                else RenameCity(city);
            }
        }

        private void Cb_cities_TextChanged(object sender, EventArgs e)
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
