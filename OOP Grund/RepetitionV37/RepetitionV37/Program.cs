namespace RepetitionV37  // Hus
{
    using System;

    // Åtkomstgrad static namn
    internal static class Program // Rum
    {
        // Åtkomst static typ namn = standardvärde
        private static int Nummer = 4;

        // åtkomst static typ namn
        private static void Main(string[] args) // Möbel
        {
            AskForNumber(maxValue: 5, minValue: 3);



        }
        //          returvärde
        //          |
        //          |
        // åtkomst typ namn (inparametrar)
        private static int AskForNumber(string message = "Ange ett nummer: ", int minValue = 1, int maxValue = 10)
        {
            int value = 0;
            while (value < minValue || value > maxValue)
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out value);
            }
            Nummer = value;
            return value;
        }

        private static int AntalPlatser(int antalBord)
        {
            if (antalBord > 1)
            {
                return antalBord * 2 + 2;
            }
            else
            {
                return 4;
            }
        }

    }

    internal class Katt
    {
        private readonly int antalTassar = 4;
        private readonly int antalSvans = 1;
    }
}
