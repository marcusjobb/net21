using System;

namespace ChatUpNameList.DTO
{
    internal class Person
    {
        public string Name { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Alias { get; set; } = "";
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
        public string FavFood { get; set; }
        public string HateFood { get; set; }
        public string Animal { get; set; }
        public string MovieGenre { get; set; }
        public bool IsGhosted { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                if (DateOfBirth != default)
                {
                    return (int)((DateTime.Now - DateOfBirth).Days / 365.25);
                }
                return 0;
            }
        }

        public string Webpage { get; set; }

        public void Print()
        {
            Console.WriteLine("Name            : " + Name);
            Console.WriteLine("Lastname        : " + Lastname);
            Console.WriteLine("Alias           : " + Alias);
            if (DateOfBirth == DateTime.MinValue)
            {
                Console.Write("Date of birth   : ");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Date of birth   : " + DateOfBirth.ToString("yyyy-MM-dd"));
                Console.WriteLine(" (" + Age + " years old)");
            }
            Console.WriteLine("Email           : " + Email);
            Console.WriteLine("Webpage         : " + Webpage);
            Console.WriteLine("LinkedIn        : " + LinkedIn);
            Console.WriteLine("Facebook        : " + Facebook);
            Console.WriteLine("Instagram       : " + Instagram);
            Console.WriteLine("Twitter         : " + Twitter);
            Console.WriteLine("Github          : " + Github);
            Console.WriteLine("FavFood         : " + FavFood);
            Console.WriteLine("HateFood        : " + HateFood);
            Console.WriteLine("Animal          : " + Animal);
            Console.WriteLine("MovieGenre      : " + MovieGenre);
            Console.WriteLine("Ghosted         : " + IsGhosted);
            Console.WriteLine("Blocked         : " + IsBlocked);
            Console.WriteLine();
        }
    }
}