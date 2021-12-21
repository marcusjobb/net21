// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace DictionaryDemo
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> budget = new();
            budget.Add("Hyra", 8540);

            Dictionary<string, string> dic = new();
            dic.Add("Dog", "Hund");
            dic.Add("Cat", "Katt");
            dic.Add("Deer", "Rådjur");

            Console.WriteLine(dic["Dog"]);
            Console.WriteLine(budget["Hyra"]);

            if (dic.ContainsKey("Deer"))
                Console.WriteLine(dic["Deer"]);

            if (dic.ContainsValue("Katt"))
            {

            }

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            // Överkurs: Tuple
            (int, string) tuple = (1, "Hello"); // Tuple
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

        }
    }
}
