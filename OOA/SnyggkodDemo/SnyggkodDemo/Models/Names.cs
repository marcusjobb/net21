// -----------------------------------------------------------------------------------------------
//  Names.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SnyggkodDemo.Models
{
    public class Names
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public bool IsEvil { get; set; }

        public Names(string firstName, string lastName, string city, bool isEvil = false)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            IsEvil = isEvil;
        }

        public override string ToString() => FirstName + " " +
                                 LastName +
                                 " lives in " + City
                                 + (IsEvil ? " and is evil" : "");
    }
}