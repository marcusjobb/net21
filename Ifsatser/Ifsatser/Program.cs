using System;

namespace Ifsatser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett nummer!");
            string input = Console.ReadLine();
            int value = 0;

            bool doesWork = int.TryParse(input, out value);

            if (doesWork)
            {
                Console.WriteLine("Du angav värdet :" + value);
            }
            else
            {
                Console.WriteLine("Dumhuvve!!!");
            }


        }
    }
}
