namespace RandomExempel
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Slumpgenerator");

                for (int i = 0; i < 10; i++)
                {
                    int slump = random.Next(0, 100);
                    Console.WriteLine(slump);
                }
                Console.ReadLine(); // Paus

            }
        }
    }
}
