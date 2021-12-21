// -----------------------------------------------------------------------------------------------
//  AddEditPersonForm.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Helpers;
    using FamilyTreeWF.Models;
    using System;
    using System.Windows.Forms;

    public partial class AddEditPersonForm : Form
    {
        private Person person;
        public AddEditPersonForm(Person person)
        {
            InitializeComponent();
            this.person = person.PersonId == 0 ? person : PersonHelper.GetPersonById(person.PersonId);
            SetupComboBoxes();
        }

        private void SetupComboBoxes()
        {
            cb_birthCity.DisplayMember = "Name";
            cb_birthCountry.DisplayMember = "Name";
            cb_deathCity.DisplayMember = "Name";
            cb_deathCountry.DisplayMember = "Name";
            cb_father.DisplayMember = "Name";
            cb_mother.DisplayMember = "Name";
            cb_birthCity.ValueMember = "Id";
            cb_birthCountry.ValueMember = "Id";
            cb_deathCity.ValueMember = "Id";
            cb_deathCountry.ValueMember = "Id";
            cb_father.ValueMember = "Id";
            cb_mother.ValueMember = "Id";
        }

        private void UpdateLocationBindings()
        {
            UpdateCountryDataSources();
            UpdateCityDataSources();
        }

        private void UpdateCityDataSources()
        {
            cb_birthCity.DataSource = CityHelper.GetAllCityNames();
            cb_deathCity.DataSource = CityHelper.GetAllCityNames();
        }

        private void UpdateCountryDataSources()
        {
            cb_birthCountry.DataSource = CountryHelper.GetAllCountryNames();
            cb_deathCountry.DataSource = CountryHelper.GetAllCountryNames();
        }

        private void B_addCountry_Click(object sender, EventArgs e)
        {
            AddRemoveCountry arc = new();
            arc.ShowDialog();
            UpdateCountryDataSources();
        }

        private void B_addCity_Click(object sender, EventArgs e)
        {
            AddRemoveCity arCity = new();
            arCity.ShowDialog();
            UpdateCityDataSources();
        }

        private void AddEditPersonForm_Load(object sender, EventArgs e)
        {
            UpdateLocationBindings();
            SetupParentComboBoxes();
            if (person.PersonId != 0)
            {
                SetupFirstAndLastNames();
                SetupBirthData();
                SetUpDeathData();
            }
        }

        private void SetupFirstAndLastNames()
        {
            tb_firstName.Text = person.FirstName;
            tb_lastName.Text = person.LastName;
        }

        private void SetUpDeathData()
        {
            num_deathYear.Value = person.DeathYear ?? 0;
            check_deceased.Checked = person.DeathYear != null && person.DeathYear != 0;
            if (person.DeathCity != null) cb_deathCity.SelectedValue = person.DeathCity.CityId;
            if (person.DeathCountry != null) cb_deathCountry.SelectedValue = person.DeathCountry.CountryId;
        }

        private void SetupBirthData()
        {
            num_birthYear.Value = person.BirthYear;
            if (person.BirthCity != null) cb_birthCity.SelectedValue = person.BirthCity.CityId;
            if (person.BirthCountry != null) cb_birthCountry.SelectedValue = person.BirthCountry.CountryId;
        }

        private void SetupParentComboBoxes()
        {
            if (person.PersonId != 0)
            {
                cb_father.DataSource = PersonHelper.GetAllFirstLastNames(true, true, person.PersonId);
                cb_mother.DataSource = PersonHelper.GetAllFirstLastNames(true, true, person.PersonId);
            }
            else
            {
                cb_father.DataSource = PersonHelper.GetAllFirstLastNames();
                cb_mother.DataSource = PersonHelper.GetAllFirstLastNames();
            }
            cb_father.SelectedValue = person.Father != null ? person.Father.PersonId : -1;
            cb_mother.SelectedValue = person.Mother != null ? person.Mother.PersonId : -1;
        }

        private void SetPersonValues()
        {
            person.FirstName = tb_firstName.Text.Trim();
            person.LastName = tb_lastName.Text.Trim();

            person.BirthYear = (int)num_birthYear.Value;
            person.BirthCityId = (int)cb_birthCity.SelectedValue != -1 ? (int)cb_birthCity.SelectedValue : null;
            person.BirthCountryId = (int)cb_birthCountry.SelectedValue != -1 ? (int)cb_birthCountry.SelectedValue : null;

            person.DeathYear = (int)num_deathYear.Value;
            person.DeathCityId = (int)cb_deathCity.SelectedValue != -1 ? (int)cb_deathCity.SelectedValue : null;
            person.DeathCountryId = (int)cb_deathCountry.SelectedValue != -1 ? (int)cb_deathCountry.SelectedValue : null;

            person.FatherId = (int)cb_father.SelectedValue != -1 ? (int)cb_father.SelectedValue : null;
            person.MotherId = (int)cb_mother.SelectedValue != -1 ? (int)cb_mother.SelectedValue : null;
        }

        private void B_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_firstName.Text) || string.IsNullOrEmpty(tb_lastName.Text))
                MessageBox.Show("Atleast first and last name must be filled in to add a new person.", "Input error");
            else
            {
                SetPersonValues();
                (int rowsAffected, bool duplicate) = PersonHelper.UpsertPerson(person);
                if (rowsAffected > 0) MessageBox.Show("Submission successful", "Success");
                else if (duplicate) MessageBox.Show("Person with same data already exists in database","Duplicate");
                this.Close();
            }
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_deceased_CheckedChanged(object sender, EventArgs e)
        {
            if (check_deceased.Checked)
            {
                l_deathYear.Visible = true;
                l_deathCity.Visible = true;
                l_deathCountry.Visible = true;
                num_deathYear.Visible = true;
                cb_deathCity.Visible = true;
                cb_deathCountry.Visible = true;
            }
            else
            {
                l_deathYear.Visible = false;
                l_deathCity.Visible = false;
                l_deathCountry.Visible = false;
                num_deathYear.Visible = false;
                cb_deathCity.Visible = false;
                cb_deathCountry.Visible = false;
            }
        }
    }
}
