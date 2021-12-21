// -----------------------------------------------------------------------------------------------
//  MovieTester.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Livekodning_Arv_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MovieTester
    {
        public MovieTester()
        {
            List<Movie> myDVDMovies = new List<Movie>
            {
                new Movie
                {
                    Title = "Zodiac",
                    Year = 2007,
                    Director = "David Fincher",
                    Actors = new List<string> { "Jake Gyllenhaal", "Robert Downey Jr", "Mark Ruffalo" }
                },
                new TVShow
                {
                    Title = "The mist",
                    Year = 2017,
                    Director = "Misc",
                    Actors = new List<string> { "Morgan Spector", "Alyssa Sutherland", "Gus Birney" },
                    Episodes = new List<string> { "Pilot", "Withdrawal", "Show and Tell" }
                }
            };

            foreach (var movie in myDVDMovies)
            {
                movie.Print();
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
