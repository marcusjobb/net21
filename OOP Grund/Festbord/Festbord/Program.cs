namespace Festbord
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            {
                int PersonerPerBord = 4;
                int antalBord = 7;
                int totalPlatser = PersonerPerBord * antalBord;
                int platserFörsvinner = PersonerPerBord / 2 * antalBord;
                int antalKantplatser = 2;
                int antalSittplatser = totalPlatser - platserFörsvinner + antalKantplatser;
                Console.WriteLine($"Platser att sitta på när man har {antalBord} bord: {antalSittplatser}");
            }

            {
                int antalBord = 7;
                int antalSidoplatser = 2;
                int antalKantplatser = 2;
                int antalSittplatser = antalBord * antalSidoplatser + antalKantplatser;
                Console.WriteLine($"Platser att sitta på när man har {antalBord} bord: {antalSittplatser}");
            }


        }
    }
}
