using System;
using System.Collections.Generic;

namespace GanericStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>()
            {
                "Harley Quinn",
                "Poison Ivy",
                "Catwoman",
                "The Penguin",
                "Fish",
                "Penguin",
            };

            people.Sort();

            while (people.Contains("Penguin"))
            {
                //int idx = people.IndexOf("Penguin");
                //people.RemoveAt(idx);
                people.Remove("Penguin");
            }

            //int count = people.Count;
            //for (int i = count - 1; i >= 0; i--)
            //{
            //    if (people[i].Contains("Penguin"))
            //    {
            //        people.RemoveAt(i);
            //    }
            //}

            foreach (var villainess in people)
            {
                Console.WriteLine(villainess);
            }
        }
    }
}
