// -----------------------------------------------------------------------------------------------
//  ContactList.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using static Helpers.ContactListIOHelpers;

    public class ContactList
    {
        #region Private Fields

        private readonly string directory = "Contacts";
        private readonly string fileName = "contactlist";

        #endregion Private Fields

        #region Public Constructors

        public ContactList()
        {
            Contacts = Load();
        }

        public ContactList(string dir = "Contacts", string fileName = "contactlist")
        {
            directory = dir;
            this.fileName = fileName;
            Contacts = Load();
        }

        #endregion Public Constructors

        #region Public Properties

        public List<Person> Contacts { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void AddContact(Person newContact)
        {
            if (!string.IsNullOrWhiteSpace(newContact.Name) && newContact.Name.Length > 2)
                newContact.Name = newContact.Name.Substring(0, 1).ToUpper() + newContact.Name.Substring(1).ToLower();
            if (!string.IsNullOrWhiteSpace(newContact.LastName) && newContact.LastName.Length > 2)
                newContact.LastName = newContact.LastName.Substring(0, 1).ToUpper() + newContact.LastName.Substring(1).ToLower();

            Contacts.Add(newContact);
            Save();
        }

        public List<string> BDaysThisMonth()
        {
            List<string> thisMonthsBdays = new();
            foreach (Person contact in Contacts)
            {

                if (DateTime.Now.Month == contact.BirthDate.Month && !contact.IsBlocked)
                {
                    string tense = DateTime.Now.Day > contact.BirthDate.Day ? "fyllde" : "fyller";
                    string when = DateTime.Now.Day == contact.BirthDate.Day ? "IDAG!" : $"den { contact.BirthDate.Day} { contact.BirthDate.ToString("MMMM")}.";
                    thisMonthsBdays.Add($"{contact.FullName} {tense} {DateTime.Now.Year - contact.BirthDate.Year} år {when}");
                }
            }
            return thisMonthsBdays;
        }

        public List<string> GetAllBlocked()
        {
            List<string> allBlocked = new();
            foreach (Person person in Contacts)
            {
                if (person.IsBlocked) allBlocked.Add(person.FullName);
            }
            return allBlocked;
        }

        public List<string> GetAllGhosted()
        {
            List<string> allGhosted = new();
            foreach (Person person in Contacts)
            {
                if (person.IsGhosted) allGhosted.Add(person.FullName);
            }
            return allGhosted;
        }

        public void RemoveContact(int idx)
        {
            Contacts.RemoveAt(idx);
            Save();
        }

        public void Save()
        {
            string path = Path.Combine(directory, fileName + ".json");

            Contacts.Sort(Person.CompareByFullName);

            SaveList(Contacts, path);
        }

        #endregion Public Methods

        #region Private Methods

        private List<Person> Load()
        {
            string path = Path.Combine(directory, fileName + ".json");
            return LoadList(path);
        }

        #endregion Private Methods
    }
}