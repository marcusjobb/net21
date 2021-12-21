// -----------------------------------------------------------------------------------------------
//  ShowCountryInfo.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Models;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CountryInfo : Form
    {
        private List<Country> countries = new();
        public CountryInfo()
        {
            InitializeComponent();
            SetupDataForForm();
        }

        private void SetupDataForForm()
        {
            countries = Helpers.CountryHelper.GetAllCountries();
            cb_countries.DataSource = null;
            cb_countries.DataSource = countries;
            cb_countries.DisplayMember = "Name";
            cb_countries.ValueMember = "CountryId";
        }

        private void Cb_countries_SelectedValueChanged(object sender, EventArgs e)
        {
            int idx = -1;
            if (cb_countries.SelectedValue is not Country && cb_countries.SelectedValue!=null) idx = countries.FindIndex(c => c.CountryId == (int)cb_countries.SelectedValue);
            if (idx != -1)
            {
                lb_born.DataSource = countries[idx].PeopleBorn;
                lb_dead.DataSource = countries[idx].PeopleDead;
                lb_born.DisplayMember = "FullNameAndLifeTime";
                lb_dead.DisplayMember = "FullNameAndLifeTime";
            }
        }

        private void B_addRemoveCountry_Click(object sender, EventArgs e)
        {
            AddRemoveCountry ac = new AddRemoveCountry(countries);
            ac.ShowDialog();
            SetupDataForForm();
        }
    }
}
