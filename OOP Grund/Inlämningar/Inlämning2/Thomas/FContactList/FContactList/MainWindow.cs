// -----------------------------------------------------------------------------------------------
//  MainWindow.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class MainWindow : Form
    {
        #region Private Fields

        private RefreshDisplay RefreshRadioSelectedInfo;

        #endregion Private Fields

        #region Public Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Delegates

        private delegate List<string> RefreshDisplay();

        #endregion Private Delegates

        #region Public Properties

        public ContactList CL { get; set; } = new();

        #endregion Public Properties

        #region Private Methods

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            ContactDetailsForm addForm = new(this, nameListBox.SelectedIndex);
            addForm.AddPerson();
        }

        private void bDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (bDayRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.BDaysThisMonth);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }

        private void blockedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (blockedRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.GetAllBlocked);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string fullName = CL.Contacts[nameListBox.SelectedIndex].FullName;
            int idx = nameListBox.SelectedIndex;
            DialogResult answer = MessageBox.Show($"Ta bort {fullName}.\r\nÄr du säker?", "Ta bort kontakt", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                CL.RemoveContact(idx);
                MessageBox.Show($"{fullName} borttagen.", "Kontakt borttagen.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ContactDetailsForm editForm = new ContactDetailsForm(this, nameListBox.SelectedIndex);
            editForm.EditPerson((Person)nameListBox.SelectedItem);
        }

        private void firstNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListBox.Focus();
        }

        private void ghostedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ghostedRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.GetAllGhosted);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }

        private void lastNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListBox.Focus();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            UpdateDataSources();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshRadioSelectedInfo = new RefreshDisplay(CL.BDaysThisMonth);
        }

        private void nameListBox_DoubleClick(object sender, EventArgs e)
        {
            ContactDetailsForm showForm = new(this, nameListBox.SelectedIndex);
            showForm.ShowPerson((Person)nameListBox.SelectedItem);
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (nameListBox.SelectedIndex >= 0 && CL.Contacts.Count >= nameListBox.SelectedIndex)
            {
                if (CL.Contacts[nameListBox.SelectedIndex].IsGhosted) ghostPicture.Visible = true;
                else ghostPicture.Visible = false;

                if (CL.Contacts[nameListBox.SelectedIndex].IsBlocked) blockedPicture.Visible = true;
                else blockedPicture.Visible = false;

                selectedPersonInfoDisplay.Text = CL.Contacts[nameListBox.SelectedIndex].ToString().Replace("|", "\r\n");
            }
        }
        private void UpdateDataSources()
        {
            nameListBox.DataSource = null;
            nameListBox.DataSource = CL.Contacts;
            nameListBox.DisplayMember = "FullName";

            firstNameCombo.DataSource = null;
            firstNameCombo.DataSource = CL.Contacts;
            firstNameCombo.DisplayMember = "Name";

            lastNameCombo.DataSource = null;
            lastNameCombo.DataSource = CL.Contacts;
            lastNameCombo.DisplayMember = "lastName";


            radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
        }

        #endregion Private Methods
    }
}
