namespace BFU_Vecka1_05
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal tal1;
            decimal tal2;
            decimal summa = 0;

            Console.Write("Ange tal 1: ");
            var one = Console.ReadLine();
            Console.Write("Ange tal 2: ");
            var two = Console.ReadLine();

            tal1 = decimal.Parse(one);
            tal2 = decimal.Parse(two);
            summa = tal1 + tal2;

            Console.Write("Summan av " + tal1 + " + " + tal2);
            Console.Write(" är " + summa);

            //string five = 5.ToString();

            //int number = int.Parse("1337"); // char[4]{'1','3','3','7'}
            //         51   53  53  58

            Console.WriteLine();
            Console.WriteLine();

         }
    }
}
