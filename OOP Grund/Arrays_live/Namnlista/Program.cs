using System;

namespace Namnlista
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] names = new string[]
            {
                "Bruce Wayne",
                "Clark Kent",
                "Oliver x",
                "Peter Parker",
                "Kit Walker"
            };

            Array.Sort(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
