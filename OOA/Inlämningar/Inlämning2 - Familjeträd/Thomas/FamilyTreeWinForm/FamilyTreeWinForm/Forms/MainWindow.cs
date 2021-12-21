// -----------------------------------------------------------------------------------------------
//  MainWindow.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Helpers;
    using FamilyTreeWF.Models;
    using System.Linq;

    public partial class MainWindow : Form
    {
        private List<Person> people = new();
        private List<Person> filteredPeople = new();
        private Person? person;
        public MainWindow()
        {
            InitializeComponent();
            UpdateDataForForm();
        }

        private void UpdateDataForForm()
        {
            people = PersonHelper.GetAllPeople();
            ResetFilter();
        }

        private void B_addPerson_Click(object sender, EventArgs e)
        {
            var person = new Person();
            AddEditPersonForm aepf = new(person);
            aepf.ShowDialog();
            UpdateDataForForm();
        }

        private void B_editPerson_Click(object sender, EventArgs e)
        {
            var person = PersonHelper.GetPersonById((int)lb_peopleList.SelectedValue);
            AddEditPersonForm aepf = new(person);
            aepf.ShowDialog();
            UpdateDataForForm();
        }
        private void Lb_peopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_peopleList.SelectedValue is not Person && lb_peopleList.SelectedValue != null)
            {
                if ((int)lb_peopleList.SelectedValue > 0) person = people.First(p => p.PersonId == (int)lb_peopleList.SelectedValue);
                UpdateMotherAndFather();
                UpdateSiblings();
                UpdateChildren();
            }
        }

        private void UpdateChildren()
        {
            var children = people.Where(p => p.FatherId == person?.PersonId || p.MotherId == person?.PersonId).ToList();
            lb_children.DataSource = children;
        }

        private void UpdateSiblings()
        {
            var siblings = new List<Person>();
            if (person?.Father != null || person?.Mother != null)
                siblings = people.Where(p => ((p.FatherId != null && p.FatherId == person.FatherId) || (p.MotherId != null && p.MotherId == person.MotherId)) && p.PersonId != person.PersonId).ToList();
            lb_siblings.DataSource = siblings;
        }

        private void UpdateMotherAndFather()
        {
            tb_father.Text = person?.Father == null ? "" : person.Father.FullNameAndLifeTime;
            tb_mother.Text = person?.Mother == null ? "" : person.Mother.FullNameAndLifeTime;
        }

        private void TextOrListBox_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListBox listBox)
            {
                var lb = listBox;
                if (filteredPeople.Any(p => p.PersonId == (int)lb.SelectedValue)) lb_peopleList.SelectedValue = lb.SelectedValue;
            }
            else
            {
                var tb = (TextBox)sender;
                var tbPerson = filteredPeople.Where(p => p.FullNameAndLifeTime == tb.Text).FirstOrDefault(new Person { PersonId = 0 });
                if (filteredPeople.Any(p => p.PersonId == tbPerson.PersonId)) lb_peopleList.SelectedValue = tbPerson.PersonId;
            }
        }

        private void B_showFamilyTree_Click(object sender, EventArgs e)
        {
            FamilyTreeForm ftf;
            if (person != null)
            {
                ftf = new FamilyTreeForm(person);
                ftf.Show();
            }
        }

        private void B_applyFilter_Click(object sender, EventArgs e)
        {
            CheckRadioButtons();

            if (filteredPeople.Count == 0) DisconnectDataSources();
            else ResetPeopleListDataSource();
            cb_filter.Text = "";
            ClearRadioButtons();
            UpdateFilterComboBox();
            if (filteredPeople.Count < people.Count) l_peopleList.Text = "Filtered list:";
        }

        private void ResetPeopleListDataSource()
        {
            lb_peopleList.DataSource = null;
            lb_peopleList.DataSource = filteredPeople;
            SetListboxesDisplayAndValueMembers();
        }

        private void DisconnectDataSources()
        {
            lb_peopleList.DataSource = null;
            lb_children.DataSource = null;
            lb_siblings.DataSource = null;
        }

        private void CheckRadioButtons()
        {
            if (rb_firstName.Checked) filteredPeople = filteredPeople.Where(x => x.FirstName.StartsWith(cb_filter.Text, true, null)).ToList();
            else if (rb_lastName.Checked) filteredPeople = filteredPeople.Where(x => x.LastName.StartsWith(cb_filter.Text, true, null)).ToList();
            else if (rb_birthYear.Checked && Int32.TryParse(cb_filter.Text, out int filterAge)) filteredPeople = filteredPeople.Where(x => x.BirthYear == filterAge).ToList();
            else if (rb_birthCity.Checked) filteredPeople = filteredPeople.Where(x => x.BirthCity?.Name.StartsWith(cb_filter.Text, true, null) == true).ToList();
            else if (rb_birthCountry.Checked) filteredPeople = filteredPeople.Where(x => x.BirthCountry?.Name.StartsWith(cb_filter.Text, true, null) == true).ToList();
        }

        private void UpdateFilterComboBox()
        {
            if (rb_firstName.Checked) cb_filter.DataSource = filteredPeople.OrderBy(x => x.FirstName).Select(x => x.FirstName).Distinct().ToList();
            else if (rb_lastName.Checked) cb_filter.DataSource = filteredPeople.OrderBy(x => x.LastName).Select(x => x.LastName).Distinct().ToList();
            else if (rb_birthYear.Checked) cb_filter.DataSource = filteredPeople.OrderBy(x => x.BirthYear).Select(x => x.BirthYear).Distinct().ToList();
            else if (rb_birthCity.Checked) cb_filter.DataSource = filteredPeople.OrderBy(x => x.BirthCity?.Name).Select(x => x.BirthCity?.Name).Distinct().ToList();
            else if (rb_birthCountry.Checked) cb_filter.DataSource = filteredPeople.OrderBy(x => x.BirthCountry?.Name).Select(x => x.BirthCountry?.Name).Distinct().ToList();
            else cb_filter.DataSource = null;
            cb_filter.SelectedIndex = -1;
        }

        private void B_resetFilter_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void ResetFilter()
        {
            ResetFilterCombobox();
            ResetFilteredPeopleList();
            ResetListboxPeopleList();
            SetListboxesDisplayAndValueMembers();
            ClearRadioButtons();
        }

        private void ResetListboxPeopleList()
        {
            lb_peopleList.DataSource = null;
            lb_peopleList.DataSource = filteredPeople;
            l_peopleList.Text = "People:";
        }

        private void ResetFilteredPeopleList()
        {
            filteredPeople.Clear();
            filteredPeople.AddRange(people);
            filteredPeople = filteredPeople.OrderBy(x => x.FirstName).ToList();
        }

        private void ResetFilterCombobox()
        {
            cb_filter.DataSource = null;
            cb_filter.Text = "";
        }

        private void ClearRadioButtons()
        {
            rb_firstName.Checked = false;
            rb_lastName.Checked = false;
            rb_birthYear.Checked = false;
            rb_birthCity.Checked = false;
            rb_birthCountry.Checked = false;
        }

        private void SetListboxesDisplayAndValueMembers()
        {
            lb_peopleList.DisplayMember = "FullNameAndLifeTime";
            lb_peopleList.ValueMember = "PersonId";
            lb_siblings.DisplayMember = "FullNameAndLifeTime";
            lb_siblings.ValueMember = "PersonId";
            lb_children.DisplayMember = "FullNameAndLifeTime";
            lb_children.ValueMember = "PersonId";
        }

        private void FilterRadioButtonCheckChanged(object sender, EventArgs e)
        {
            UpdateFilterComboBox();
        }

        private void B_deletePerson_Click(object sender, EventArgs e)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            const MessageBoxIcon icon = MessageBoxIcon.Warning;
            var answer = MessageBox.Show($"Really delete {person?.FullNameAndLifeTime}?\n This action cannot be undone.", "Confirm delete", buttons, icon);
            if (answer == DialogResult.Yes && person != null)
            {
                var result = PersonHelper.DeletePerson(person);
                if (result > 0) MessageBox.Show($"{person.FullName} removed from database.", "Person deleted.");
            }
            UpdateDataForForm();
        }

        private void B_showCities_Click(object sender, EventArgs e)
        {
            CityInfo showCities = new CityInfo();
            showCities.ShowDialog();
        }

        private void B_showCountries_Click(object sender, EventArgs e)
        {
            CountryInfo showCountries = new CountryInfo();
            showCountries.ShowDialog();
        }
    }
}