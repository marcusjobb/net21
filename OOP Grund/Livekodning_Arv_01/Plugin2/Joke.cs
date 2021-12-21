// -----------------------------------------------------------------------------------------------
//  Joke.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Plugin2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Livekodning_Arv_01;

    public class Joke : Plugin
    {
        public void Settings() => Console.WriteLine("Joke settings");
        public void Start() => Console.WriteLine("Don't interrupt someone working intently on a puzzle. Chances are, you'll hear some crosswords.");
        public void Stop() => Console.WriteLine("Joke stop");
    }
}
