namespace DictionaryDemo
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> heroes = new();
            AddToList(heroes, "Batman", "Bruce Wayne");
            AddToList(heroes, "Superman", "Clark Kent");
            AddToList(heroes, "Equalizer", "Denzel Washington");
            AddToList(heroes, "Equalizer", "Robert McCall");

            if (heroes.TryAdd("Spiderman", "Peter Parker"))
            {
                Console.WriteLine("Spiderman is OK");
            }

            if (!heroes.ContainsKey("Green Arrow"))
            {
                heroes.Add("Green Arrow", "Oliver Quinn");
            }


            Console.WriteLine("Hello " + heroes["Equalizer"]);

            foreach (var hero in heroes)
            {
                if (hero.Value == "Clark Kent")
                    Console.WriteLine(hero.Key + " is " + hero.Value);
            }

            Console.WriteLine();

            heroes.Remove("Green Arrow");

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key + " is " + hero.Value);
            }
            //Console.WriteLine("-----------------------------------------");

            //SortedDictionary<string, string> villians = new();
            //villians.Add("Catwoman", "Celina Kyle");
            //villians.Add("Harley Quinn", "Harley Quinzell");
            ////names.Add("Catwoman", "Celina Kyle");

            //SortedDictionary<string, SortedDictionary<string, string>> all = new();
            //all.Add("Heroes", heroes);
            //all.Add("Villians", villians);


            //foreach (var people in all)
            //{
            //    Console.WriteLine(people.Key);
            //    foreach (var person in people.Value)
            //    {
            //        Console.WriteLine(person.Key +" = " +person.Value);
            //    }
            //}
        }

        static void AddToList(SortedDictionary<string, string> heroes, string key, string value)
        {
            if (heroes.TryAdd(key, value))
            {
                Console.WriteLine(key + " Is OK");
            }
            else
            {
                heroes[key] = value;
            }
        }
    }
}
