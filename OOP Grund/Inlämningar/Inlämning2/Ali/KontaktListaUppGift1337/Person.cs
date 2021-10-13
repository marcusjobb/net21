using System;

namespace KontaktListaUppGift1337
{
    public class Person
    {
        private int age;

        public string Name { get; internal set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public DateTime BirthDay { get; set; }

        public int Age
        {
            get => age;
            set => age = DateTime.Today.Year - BirthDay.Year;
        }

        public string Email { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Steam { get; set; }
        public string Github { get; set; }
        public string FavoriteFood { get; set; }
        public string FoodDoesNotLike { get; set; }
        public string FavoritAnimal { get; set; }
        public string FavoriteMovieGenre { get; set; }
        public string FavoriteMovie { get; set; }
        public bool Blocked { get; set; }
        public bool Ghosted { get; set; }
    }
}