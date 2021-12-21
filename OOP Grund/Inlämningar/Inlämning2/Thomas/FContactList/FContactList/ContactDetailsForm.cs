// -----------------------------------------------------------------------------------------------
//  ContactDetailsForm.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Windows.Forms;

    internal partial class ContactDetailsForm : Form
    {
        #region Private Fields

        private readonly int index;
        private readonly MainWindow mw;
        private bool addingPerson = false;
        private Person person;

        #endregion Private Fields

        #region Public Constructors

        public ContactDetailsForm(MainWindow main, int idx = 0)
        {
            index = idx;
            mw = main;
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Methods

        public void AddPerson()
        {
            addingPerson = true;
            person = new();
            SetupForm();
            Show();
        }

        public void EditPerson(Person person)
        {
            this.person = (Person)mw.CL.Contacts[index].Clone();
            SetupForm();
            Show();
        }

        public void ShowPerson(Person person)
        {
            this.person = (Person)mw.CL.Contacts[index].Clone();
            SetUpAsViewWindow();
            Show();
        }

        #endregion Public Methods


        #region Private Methods

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Stänga utan att spara?", "Stänga fönster", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                Close();
            }
        }

        private void ContactDetailsForm_Load(object sender, EventArgs e)
        {
            VerifySaveButton();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            VerifySaveButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (addingPerson) mw.CL.AddContact(person);
            else mw.CL.Contacts[index] = person;

            mw.CL.Save();

            Close();
        }
        private void SetDataBindings()
        {
            nameBox.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            LastNameBox.DataBindings.Add("Text", person, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
            aliasBox.DataBindings.Add("Text", person, "Alias", false, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", person, "BirthDate", false, DataSourceUpdateMode.OnPropertyChanged);
            mailBox.DataBindings.Add("Text", person, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            linkedinBox.DataBindings.Add("Text", person, "LinkedIn", false, DataSourceUpdateMode.OnPropertyChanged);
            facebookBox.DataBindings.Add("Text", person, "Facebook", false, DataSourceUpdateMode.OnPropertyChanged);
            instagramBox.DataBindings.Add("Text", person, "Instagram", false, DataSourceUpdateMode.OnPropertyChanged);
            twitterBox.DataBindings.Add("Text", person, "Twitter", false, DataSourceUpdateMode.OnPropertyChanged);
            githubBox.DataBindings.Add("Text", person, "GitHub", false, DataSourceUpdateMode.OnPropertyChanged);
            bestFoodBox.DataBindings.Add("Text", person, "BestFood", false, DataSourceUpdateMode.OnPropertyChanged);
            worstFoodBox.DataBindings.Add("Text", person, "WorstFood", false, DataSourceUpdateMode.OnPropertyChanged);
            favAnimalBox.DataBindings.Add("Text", person, "FavouriteAnimal", false, DataSourceUpdateMode.OnPropertyChanged);
            favMovieGenreBox.DataBindings.Add("Text", person, "FavouriteMovieGenre", false, DataSourceUpdateMode.OnPropertyChanged);
            notesBox.DataBindings.Add("Text", person, "Notes", false, DataSourceUpdateMode.OnPropertyChanged);
            ghostedcheckBox.DataBindings.Add("Checked", person, "IsGhosted", false, DataSourceUpdateMode.OnPropertyChanged);
            blockedCheckBox.DataBindings.Add("Checked", person, "IsBlocked", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void SetUpAsViewWindow()
        {
            SetDataBindings();
            VerifySaveButton();
            nameBox.ReadOnly = true;
            LastNameBox.ReadOnly = true;
            aliasBox.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            mailBox.ReadOnly = true;
            linkedinBox.ReadOnly = true;
            facebookBox.ReadOnly = true;
            instagramBox.ReadOnly = true;
            twitterBox.ReadOnly = true;
            githubBox.ReadOnly = true;
            bestFoodBox.ReadOnly = true;
            worstFoodBox.ReadOnly = true;
            favAnimalBox.ReadOnly = true;
            favMovieGenreBox.ReadOnly = true;
        }

        private void SetupForm()
        {
            SetDataBindings();
            VerifySaveButton();
        }

        private void VerifySaveButton()
        {
            if (nameBox.Text is null || nameBox.Text.Length < 2)
            {
                saveButton.Enabled = false;
                tooShortNameLabel.Visible = true;
            }
            else
            {
                saveButton.Enabled = true;
                tooShortNameLabel.Visible = false;
            }
        }

        #endregion Private Methods
    }
}
