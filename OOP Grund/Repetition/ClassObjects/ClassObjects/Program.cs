// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie1 = "Elf";
            string actors1 = "Will Ferrell";
            int starsRating1 = 1;

            string movie2 = "Death Wish";
            string actors2 = "Bruce Willis";
            int starsRating2 = 4;

            string movie3 = "Malignant";
            string actors3 = "Annabelle Wallis, Maddie Hasson";
            int starsRating3 = 10;

            string movie4 = "Death Note";
            string actors4 = "Nat Wolff, LaKeith Stanfield, Margaret Qualley";
            int starsRating4 = 3;

            Console.WriteLine(movie1 + " - " + actors1);
            Console.WriteLine("Stars: " + new string('*', starsRating1));
            Console.WriteLine();
            Console.WriteLine(movie2 + " - " + actors2);
            Console.WriteLine("Stars: " + new string('*', starsRating2));
            Console.WriteLine();
            Console.WriteLine(movie3 + " - " + actors3);
            Console.WriteLine("Stars: " + new string('*', starsRating3));
            Console.WriteLine();
            Console.WriteLine(movie4 + " - " + actors4);
            Console.WriteLine("Stars: " + new string('*', starsRating4));
            Console.WriteLine();

            // Gör om projektet
            // 1 - Skapa en POCO-klass för film information
            // 2 - Lägg filmerna i en lista
            // 3 - Foreacha filmerna och skriv ut dem
        }
    }
}
