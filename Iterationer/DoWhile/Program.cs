using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "abc123";
            string input = "abc123";
            do
            {
                Console.WriteLine("Ange lösenord:");
                input = Console.ReadLine();
            } while (input != password);
        }
    }
}
