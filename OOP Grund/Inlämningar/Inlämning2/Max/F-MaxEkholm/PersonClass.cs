using System;
using System.Collections.Generic;

namespace F
{
    public class PersonClass
    {
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }

        public string LikeFood { get; set; }
        public string HateFood { get; set; }
        public string FavAnimal { get; set; }
        public string FavMovGenre { get; set; }


        public bool IsGhosted { get; set; } = false;
        public bool IsBlocked { get; set; } = false;

        public static List<PersonClass> ContactList = new List<PersonClass>();
    }
}

