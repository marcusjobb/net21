// -----------------------------------------------------------------------------------------------
//  ContactListIOHelpers.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace FContactList.Helpers
{
    using FContactList.Extensions;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="ContactListIOHelpers" />.
    /// </summary>
    public static class ContactListIOHelpers
    {
        /// <summary>
        /// Attempts to load the contaclist from the specified path
        /// </summary>
        /// <param name="path">Path where the saved contactlist is located <see cref="string"/>.</param>
        /// <returns>The loaded contactlist <see cref="List{Person}"/>.</returns>
        public static List<Person> LoadList(string path)
        {
            DirectoryInfo dir = Directory.GetParent(path);
            List<Person> loadedList;
            string json = "";
            if (dir.Exists && File.Exists(path))
            {
                try
                {
                    json = File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte ladda kontaklistan.");
                    ex.LogThis();
                }
                loadedList = JsonToList(json);
            }
            else
            {
                loadedList = new List<Person>();
            }

            return loadedList;
        }

        /// <summary>
        /// Saves the contactlist to the file spcified in the path variable.
        /// </summary>
        /// <param name="contactList">The contactlist (List<Person>) to save. <see cref="List{Person}"/>.</param>
        /// <param name="path">Path where the file will be save at. <see cref="string"/>.</param>
        public static void SaveList(List<Person> contactList, string path)
        {
            string file = ListToJson(contactList);
            DirectoryInfo dir = Directory.GetParent(path);
            try
            {
                if (!dir.Exists) dir.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte skapa katalog för att spara kontaktlistan.");
                ex.LogThis();
            }
            try
            {
                File.WriteAllText(path, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte spara kontaktlistan.");
                ex.LogThis();
            }
        }

        /// <summary>
        /// Deserializes the json content to a List<Person>.
        /// </summary>
        /// <param name="json">Json formatted string. <see cref="string"/>.</param>
        /// <returns>The deserialized <see cref="List{Person}"/>.</returns>
        private static List<Person> JsonToList(string json)
        {
            List<Person> listFromJson = new();
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    listFromJson = JsonConvert.DeserializeObject<List<Person>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte tolka kontaklistan.");
                    ex.LogThis();
                }
            }
            return listFromJson;
        }

        /// <summary>
        /// Serializes a List<Person> to Json.
        /// </summary>
        /// <param name="contactList">The list to be serialized. <see cref="List{Person}"/>.</param>
        /// <returns>The json formatted string to be returned. <see cref="string"/>.</returns>
        private static string ListToJson(List<Person> contactList)
        {
            string json = "";
            try
            {
                json = JsonConvert.SerializeObject(contactList, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            }
            catch (Exception e)
            {
                e.LogThis();
                MessageBox.Show("Kunde inte omvandla till Json");
            }

            return json;
        }
    }
}
