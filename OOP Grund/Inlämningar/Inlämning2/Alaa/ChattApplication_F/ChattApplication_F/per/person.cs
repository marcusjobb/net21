using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattApplication_F.per
{
    public enum gender { male, female, unknown }
    class person
    {
        //Fields
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Alias { get; set; }
        public gender Gen { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
        public string FavoriteFood { get; set; }
        public string FoodDislike { get; set; }
        public string FavoriteAnimal { get; set; }
        public string FavoriteMovie { get; set; }
        public string FavoriteHobby { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsGhosted { get; set; }
        public static int Index = 0; //vi kan använda den här element för räknar ny object


        //Constructor
        public person() { } //en tom constructor
                            //constructor inhåller elementär attribut
        public person(string firstname, string lastname, string alias, gender gen, int age, string email, bool isblocked, bool isghosted)
        { firstName = firstname; this.lastName = lastname; Alias = alias; Gen = gen; Age = age; Email = email; IsBlocked = isblocked; IsGhosted = isghosted; Index++; }
        //en komplett constructor inhåller alla attribut
        public person(string firstname, string lastname, string alias, gender gen, int age, string address, string email,
            string linkedin, string facebook, string instagram, string twitter, string github, string favoritFood,
            string fooddislike, string favoriteAnimal, string favoriteMovie, string favoriteHobby, bool isblocked, bool isghosted)
        {
            firstName = firstname;
            lastName = lastname;
            Alias = alias;
            Gen = gen;
            Age = age;
            Address = address;
            Email = email;
            Linkedin = linkedin;
            Facebook = facebook;
            Instagram = instagram;
            Twitter = twitter;
            Github = github;
            FavoriteFood = favoritFood;
            FoodDislike = fooddislike;
            FavoriteAnimal = favoriteAnimal;
            FavoriteMovie = favoriteMovie;
            FavoriteHobby = favoriteHobby;
            IsBlocked = false;
            IsGhosted = false;
            Index++;
        }
    }
}
