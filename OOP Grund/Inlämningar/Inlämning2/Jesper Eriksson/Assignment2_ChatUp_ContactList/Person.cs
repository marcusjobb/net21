using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_ContactList
{
    public class Person
    {
        //  Required Properties - Meant to be necessary for the creation of the person.
        public string Name { get; set; }
        public string Surename { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            // Converts the date of birth to an int stored in Age. Subtracts current date with the users date of birth, and divides it by the amount of days per year.
            get
            {
                return (int)((DateTime.Now - DateOfBirth).Days / 365.25);
            }
        }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string FoodLikes { get; set; }
        public string FoodDislikes { get; set; }
        //      Flags
        public bool IsGhosted { get; set; } = false;
        public bool IsBlocked { get; set; } = false;

        // Optional Properties - Default empty values, are not required to be set upon construction.
        //      Socials
        public string SocialsLinkedin { get; set; } = "";
        public string SocialsFacebook { get; set; } = "";
        public string SocialsInstagram { get; set; } = "";
        public string SocialsTwitter { get; set; } = "";
        public string SocialsGithub { get; set; } = "";
        //      Misc
        public string FavouriteAnimal { get; set; } = "";
        public string FavouriteMoviegenre { get; set; } = "";

        // Constructor for the required properties.
        // Since the dating service needs to keep track of their users food dislikes, it seemed appropriate to make them mandatory upon creation of the contact.
        public Person(string name, string surename, DateTime dateOfBirth, string alias, string email, string foodLikes, string foodDislikes)
        {
            Name = name;
            Surename = surename;
            DateOfBirth = dateOfBirth;
            Alias = alias;
            Email = email;
            FoodLikes = foodLikes;
            FoodDislikes = foodDislikes;
        }
        // Overrides ToString in order to print out all the information in the person class.
        public override string ToString()
        {
            return "\t"+ Name + " " + Surename + " | Age: " + Age + " | Birthday: " + DateOfBirth.ToString("dddd, yyyy/MM/dd") +
                   "\n\tAlias: " + Alias + " | Email: " + Email +
                   "\n\tFavourite food: " + FoodLikes + " | Least favourite food: " + FoodDislikes +
                   "\n\tFavourite animal: " + FavouriteAnimal + " | Favourite movie genre: " + FavouriteMoviegenre +
                   "\n\tSocials | Twitter: " + SocialsTwitter + " | Facebook: " + SocialsFacebook + " | Instagram: " + SocialsInstagram + " | LinkedIn: " + SocialsLinkedin + " | GitHub: " + SocialsGithub +
                   "\n\tFlagged status | " + "Ghosted: " + IsGhosted + " | Blocked: " + IsBlocked +"\n";
        }

    }
}
