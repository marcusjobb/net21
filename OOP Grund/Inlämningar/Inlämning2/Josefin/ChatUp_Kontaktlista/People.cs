using System;
using System.Collections.Generic;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    public class People // klass som mall för enskilda people-objekt      
    {
        public string Name;
        public string LastName;
        public string Alias;
        public string Email;
        public string LinkedIn;
        public string Facebook;
        public string Instagram;
        public string Twitter;
        public string Github;
        public string FavFood;
        public string LeastFavFood;
        public string FavAnimal;
        public string FavMovieGenre;
        public bool IsBlocked;
        public bool IsGhosted;

        public People() // en tom constructor, behövs t.ex till Create-metoden då man först skapar en ny person helt utan attribut
        {
        }

        // constructor för att skapa nya personer med attribut
        public People(string name, string lastName, string alias, string email, string linkedIn, string facebook, string instagram, string twitter, string github, string favFood, string leastFavFood, string favAnimal, string favMovieGenre, bool isBlocked, bool isGhosted)
        {
            Name = name; 
            LastName = lastName;
            Alias = alias;
            Email = email;
            LinkedIn = linkedIn;
            Facebook = facebook;
            Instagram = instagram;
            Twitter = twitter;
            Github = github;
            FavFood = favFood;
            LeastFavFood = leastFavFood;
            FavAnimal = favAnimal;
            FavMovieGenre = favMovieGenre;
            IsBlocked = isBlocked;
            IsGhosted = isGhosted;
        }
    }
}

