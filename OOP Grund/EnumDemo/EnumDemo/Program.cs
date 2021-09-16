namespace EnumDemo
{
    using EnumDemo.Enums;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en dag (1-7)");
            string input = Console.ReadLine();
            int.TryParse(input, out int day);
            // Skriv ut dagen
            Console.WriteLine((Veckodagar)day);
        }
    }
}
