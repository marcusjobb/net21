using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string EmailAddress { get; set; }
        public string LinkedinProfile { get; set; }
        public string FacebookProfile { get; set; }
        public string InstagramProfile { get; set; }
        public string TwitterProfile { get; set; }
        public string GithubPage { get; set; }
        public string FavouriteFood { get; set; }
        public string Avskymat { get; set; }
        public string FavouriteAnimal { get; set; }
        public string FavouriteFilmGenre { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsGhosted { get; set; }

        public Person(string firstName, string lastName, string alias) // Metod som körs vid varje instantiering av Person.
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Alias = alias;
        }

        public Person() // default
        {
        }
    }
}
