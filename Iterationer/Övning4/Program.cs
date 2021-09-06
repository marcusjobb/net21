using System;

namespace Övning4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            foreach (char bokstav in name)
            {
                Console.WriteLine(bokstav);
            }
        }
    }
}
