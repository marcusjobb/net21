using System;

namespace Övning_4___hundår
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du");
            string input = Console.ReadLine();
            int.TryParse(input, out var age);

            double doggie = 16 * Math.Log(age) + 31;
            int cat = 0;
            if (age == 1)
            {
                cat = 14;
            }
            else if (age == 2)
            {
                cat = 24;
            }
            else if (age > 0)
            {
                cat = age * 4 + 16;
            }
            Console.WriteLine($"Du har levt i {doggie} hundår och {cat} kattår");
        }
    }
}
