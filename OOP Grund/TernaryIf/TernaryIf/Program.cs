using System;

namespace TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en nuffra");
            string input = Console.ReadLine();
            int value = 0;
            bool isOK = int.TryParse(input, out value);
            if (isOK)
            {
                string message = (value > 10 ? "Större än 10" : "Inte större än 10");
                Console.Write("Ditt värde är " + message);
            }
        }
    }
}
