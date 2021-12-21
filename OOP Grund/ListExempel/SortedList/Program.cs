// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SortedList
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sort = new();
            sort.Add("Dog", "Hund");
            sort.Add("Cat", "Katt");
            sort.Add("Deer", "Rådjur");

            foreach (var item in sort)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
