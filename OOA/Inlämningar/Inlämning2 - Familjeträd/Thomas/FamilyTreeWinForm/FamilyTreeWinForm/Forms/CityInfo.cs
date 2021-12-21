// -----------------------------------------------------------------------------------------------
//  CityInfo.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Models;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CityInfo : Form
    {
        private List<City> cities = new();
        public CityInfo()
        {
            InitializeComponent();
            SetupDataForForm();
        }

        private void SetupDataForForm()
        {
            cities = Helpers.CityHelper.GetAllCities();
            cb_cities.DataSource = null;
            cb_cities.DataSource = cities;
            cb_cities.DisplayMember = "Name";
            cb_cities.ValueMember = "CityId";
        }

        private void Cb_countries_SelectedValueChanged(object sender, EventArgs e)
        {
            int idx = -1;
            if (cb_cities.SelectedValue is not City && cb_cities.SelectedValue != null) idx = cities.FindIndex(c => c.CityId == (int)cb_cities.SelectedValue);
            if (idx != -1)
            {
                lb_born.DataSource = cities[idx].PeopleBorn;
                lb_dead.DataSource = cities[idx].PeopleDead;
                lb_born.DisplayMember = "FullNameAndLifeTime";
                lb_dead.DisplayMember = "FullNameAndLifeTime";
            }
        }

        private void B_addRemoveCity_Click(object sender, EventArgs e)
        {
            AddRemoveCity ac = new AddRemoveCity(cities);
            ac.ShowDialog();
            SetupDataForForm();
        }
    }
}
