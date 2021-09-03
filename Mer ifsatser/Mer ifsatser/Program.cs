using System;

namespace Mer_ifsatser
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 0;
            Console.WriteLine("Skriv ett nummer");
            string input = Console.ReadLine();
            bool funkar = int.TryParse(input, out value);

            if (funkar)
            {
                while (true)
                {
                    value+=2;
                    Console.WriteLine("Aktuell siffra:" + value);
                    if (value < 10)
                    {
                        Console.WriteLine("Mindre än 10");
                    }
                    else if (value == 10)
                    {
                        Console.WriteLine("Lika med 10");
                    }
                    else if (value > 10)
                    {
                        Console.WriteLine("Större än 10");
                    }

                    if (value % 2 == 0)
                    {
                        Console.WriteLine("Jämt delbar med 2");
                    }
                    else
                    {
                        Console.WriteLine("Inte jämt delbar med 2");
                    }

                    System.Threading.Thread.Sleep(500);
                }
            }
        }
    }
}
