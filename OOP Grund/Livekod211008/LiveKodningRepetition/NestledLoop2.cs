// -----------------------------------------------------------------------------------------------
//  NestledLoop2.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;
    using System.Collections.Generic;

    /*
        Game[]
            People[]
                Children[]
    */

    internal class Character // POCO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Character[] Children { get; set; }
    }

    internal class Game
    {
        public string Name { get; set; }
        public List<Character> People = new();
    }

    internal class NestledLoop2
    {
        internal void Start()
        {
            // Deklarera variabler
            const int amount = 2;
            Game[] game = new Game[amount];

            // Instansiera klasser i arrayen
            for (int first = 0; first < amount; first++)
                game[first] = new Game();

            game[0].Name = "Silent Hill 2";
            game[0].People.Add(new Character { Name = "James", LastName = "Sunderland" });
            game[0].People.Add(new Character { Name = "Maria", LastName = "" });
            game[0].People.Add(new Character { Name = "Claudia", LastName = "" });

            game[1].Name = "Silent Hill 3";
            game[1].People.Add(new Character { Name = "Heather", LastName = "Mason" });
            game[1].People.Add(new Character { Name = "Harry", LastName = "Mason" });
            game[1].People.Add(new Character { Name = "Douglas", LastName = "" });

            // -------------------------------------------------------------------------
            for (int yearClass = 0; yearClass < amount; yearClass++)
            {
                Console.WriteLine(game[yearClass].Name);

                for (var i = 0; i < game[yearClass].People.Count; i++)
                {
                    var person = game[yearClass].People[i];
                    Console.WriteLine(person.Name + " " + person.LastName);
                    for (int c = 0; c <= person.Children.Length; c++)
                    {
                        Console.WriteLine(person.Children[c].Name + " " + person.Children[c].LastName);
                    }
                }
            }
            // -------------------------------------------------------------------------
            foreach (var g in game)
            {
                Console.WriteLine(g.Name);
                foreach (var person in g.People)
                {
                    Console.WriteLine(person.Name + " " + person.LastName);
                    foreach (var child in person.Children)
                    {
                        Console.WriteLine(child.Name + " " + child.LastName);
                    }
                }
            }
            // -------------------------------------------------------------------------
        }
    }
}