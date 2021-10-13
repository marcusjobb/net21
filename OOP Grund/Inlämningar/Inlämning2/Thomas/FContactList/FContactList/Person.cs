// -----------------------------------------------------------------------------------------------
//  Person.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using Newtonsoft.Json;
    using System;

    public class Person : ICloneable
    {
        #region Public Properties

        public int Age
        {
            get
            {
                TimeSpan temp = DateTime.Now - BirthDate;
                return (int)(temp.Days / 365.25);
            }

        }

        public string Alias { get; set; } = "";
        public string BestFood { get; set; } = "";
        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);
        public string Email { get; set; } = "";
        public string Facebook { get; set; } = "";
        public string FavouriteAnimal { get; set; } = "";
        public string FavouriteMovieGenre { get; set; } = "";
        public string FullName => Name + " " + LastName;
        public string GitHub { get; set; } = "";
        public string Instagram { get; set; } = "";
        public bool IsBlocked { get; set; } = false;
        public bool IsGhosted { get; set; } = false;
        public string LastName { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string Name { get; set; } = "";
        public string Notes { get; set; }
        public string Twitter { get; set; } = "";
        public string WorstFood { get; set; } = "";

        #endregion Public Properties

        #region Public Methods

        public static int CompareByFullName(Person p1, Person p2)
        {
            return string.Compare(p1.FullName, p2.FullName);
        }

        public object Clone()
        {
            string json = JsonConvert.SerializeObject(this, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            return JsonConvert.DeserializeObject<Person>(json);
        }

        public override string ToString()
        {
            return $"Namn: {Name}|Efternamn: {LastName}|Alias: {Alias}|Ålder: {Age}|Email: {Email}|LinkedIn: {LinkedIn}|Facebook: {Facebook}|Instagram: {Instagram}|Twitter: {Twitter}|GitHub: {GitHub}|Favoritmat: {BestFood}|Värsta mat: {WorstFood}|Favoritdjur: {FavouriteAnimal}|Födelsedatum: {BirthDate.ToString("dd MMM, yyyy")}|Anteckningar: {Notes}";
        }

        #endregion Public Methods
    }
}
