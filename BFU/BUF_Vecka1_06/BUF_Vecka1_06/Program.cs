namespace BFU_Vecka1_06
{
    using System;

    class Program
    {
        static void Main()
        {
            // Deklarera vad som ska användas
            decimal tal1;
            decimal tal2;
            decimal summa = 0;

            // Bearbetning av data
            {
                // Fråga användaren om data
                Console.Write("Ange tal 1: ");
                var one = Console.ReadLine();
                Console.Write("Ange tal 2: ");
                var two = Console.ReadLine();

                // Kontrollera om det går att omvandla och vad som ev. gått fel
                bool oneTest = decimal.TryParse(one, out tal1);
                bool twoTest = decimal.TryParse(two, out tal2);

                // Meddela användaren om vad som gått fel
                if (oneTest == false) Console.WriteLine("Tal1 var felaktigt");
                if (twoTest == false) Console.WriteLine("Tal2 var felaktigt");

                // Summera värden
                summa = tal1 + tal2;
            }

            // Skriv ut resultat
            {
                Console.Write("Summan av " + tal1 + " + " + tal2);
                Console.Write(" är " + summa);

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
