namespace Övning_4___Swappie
{
    using System;
    // Marcus -> MrSacu <-- mitt nya gamernamn helt klart!

    internal class Program
    {
        private static void Main(string[] args)
        {
            // -------------------------------------------------------------------
            // Definiering
            // -------------------------------------------------------------------
            const int MaxLoop = 10;
            // -------------------------------------------------------------------
            // instansiera randomizer
            // -------------------------------------------------------------------
            Random rnd = new Random();

            // -------------------------------------------------------------------
            // hämta in data
            // -------------------------------------------------------------------
            Console.WriteLine("Vad heter du?");

            // -------------------------------------------------------------------
            // Trim tar bort onödiga mellanslag
            // -------------------------------------------------------------------
            string input = Console.ReadLine().Trim();

            // -------------------------------------------------------------------
            // Omvandla strängen till en array
            // -------------------------------------------------------------------
            char[] chars = input.ToCharArray();

            // -------------------------------------------------------------------
            // Loopa igenom arrayen
            // -------------------------------------------------------------------
            for (int i = 0; i < MaxLoop; i++)
            {
                // -------------------------------------------------------------------
                // Välj två slumptal
                // -------------------------------------------------------------------
                int num1 = rnd.Next(0, input.Length);
                int num2 = rnd.Next(0, input.Length);
                // -------------------------------------------------------------------
                // kopiera tecknet på position 1 till tmp
                // -------------------------------------------------------------------
                char tmp = chars[num1];
                // kopiera tecknet på position 2 till position 1
                chars[num1] = chars[num2];
                // kopiera tecknet från tmp till position 2
                chars[num2] = tmp;
            }

            // -------------------------------------------------------------------
            // Skriv ut arrayen
            // -------------------------------------------------------------------
            Console.WriteLine(chars);
        }
    }
}