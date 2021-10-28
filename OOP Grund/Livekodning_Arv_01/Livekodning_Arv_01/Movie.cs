// -----------------------------------------------------------------------------------------------
//  Film.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Livekodning_Arv_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Movie
    {
        public string Title { get; set; } = "";
        public int Year { get; set; }
        public string Director { get; set; } = "";
        public List<string> Actors { get; set; } = new();

        public virtual void Print()
        {
            Console.WriteLine("Title    : " + Title);
            Console.WriteLine("Year     : " + Year);
            Console.WriteLine("Director : " + Director);
            Console.WriteLine("Actors   : ");
            foreach (var actor in Actors)
            {
                Console.WriteLine("           " + actor);
            }
        }
    }

    internal class TVShow : Movie
    {
        public List<string> Episodes { get; set; } = new();
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Episodes  : ");
            foreach (var episode in Episodes)
            {
                Console.WriteLine("           " + episode);
            }
        }
    }

}
