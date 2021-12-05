using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {

        List<Person> people = new List<Person>();
        List<int> countryC = new List<int>();
        List<string> commonC = new List<string>();
        List<int> scandinaviaC = new List<int>();
        List<int> nordicC = new List<int>();

        public Dashboard()
        {
            InitializeComponent();

            ShowFullInfo();
        }

        private void ShowFullInfo()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchLastNameButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetLastName(lastnameText.Text);

            ShowFullInfo();
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetAll();

            ShowFullInfo();
        }

        private void searchIdButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetId(idText.Text);

            ShowFullInfo();
        }

        private void searchFirstnameButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetFirstName(firstnameText.Text);

            ShowFullInfo();
        }

        private void searchEmailButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetEMail(emailText.Text);

            ShowFullInfo();
        }

        private void searchUsernameButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetUserName(usernameText.Text);

            ShowFullInfo();
        }

        private void searchPasswordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPassword(passwordText.Text);

            ShowFullInfo();
        }

        private void searchCountryButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetCountry(countryText.Text);

            ShowFullInfo();
        }

        private void howManyCountriesLabel_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            var count = db.GetCountryCount();

            countryC = new List<int>() { count };

            peopleFoundListbox.DataSource = countryC;

        }

        private void listTop10LLabel_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetFirstTenNamesL();

            ShowFullInfo();
        }

        private void DestrictLabel_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            var uniqueUsernamesAndPasswords = db.AreUsernamesAndPasswordsUnique();

            string result;
            if (uniqueUsernamesAndPasswords)
            {
                result = "Usernames and passwords are unique";
            }
            else
            {
                result = "Usernames and passwords are not unique";
            }

            var resultList = new List<string>() { result };

            peopleFoundListbox.DataSource = resultList;
        }

        // • Visa alla användare vars för- och efternamn har samma begynnelsebokstav.
        private void sameInitialsLabel_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            var users = db.GetAll();

            people = new List<Person>();

            foreach (var user in users)
            {
                if (user.First_Name[0] == user.Last_Name[0])
                {
                    people.Add(user);
                }
            }

            ShowFullInfo();
        }

        private void mostCommonCountryLabel_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var topResultCountry = db.MostCommonCountry();
            commonC = new List<string>() { topResultCountry };
            peopleFoundListbox.DataSource = commonC;
        }

        private void ScandinaviaButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var scandinaviaCount = db.GetScandinaviaContriesCount();
            scandinaviaC = new List<int>() { scandinaviaCount };
            peopleFoundListbox.DataSource = scandinaviaC;
        }

        private void nordicButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var nordicCount = db.GetNordicContriesCount();
            nordicC = new List<int>() { nordicCount };
            peopleFoundListbox.DataSource = nordicC;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
