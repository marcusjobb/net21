using System;

namespace Inläming_1___Tärningar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int PixBankKonto = 500;
            int ValtLyckoTal = 0;
            int SatsadePix = 0;
            string sant = "ja";


            while (PixBankKonto >= 50 && sant == "ja")
            {

                int tärning1 = rnd.Next(1, 6);
                int tärning2 = rnd.Next(1, 6);
                int tärning3 = rnd.Next(1, 6);
                Console.WriteLine("Välj ett lyckotal mellan 1 och 6");
                ValtLyckoTal = int.Parse(Console.ReadLine());
                Console.WriteLine("Du har: " + PixBankKonto + " Pix ");
                Console.WriteLine("Satsa Pix:");
                SatsadePix = int.Parse(Console.ReadLine());

                if (SatsadePix >= 50 && SatsadePix <= PixBankKonto && ValtLyckoTal >= 1 && ValtLyckoTal <= 6)


                {


                    if (tärning1 == ValtLyckoTal && tärning2 == ValtLyckoTal && tärning3 == ValtLyckoTal)
                    {

                        Console.WriteLine("Tärning ett blev: " + tärning1 + " Tärning två blev: " + tärning2 + " Tärning tre blev: " + tärning3);
                        SatsadePix = SatsadePix *= 4;
                        Console.WriteLine("Du har Vunnit: " + SatsadePix + " Pix");
                        PixBankKonto = PixBankKonto += SatsadePix;
                        Console.WriteLine("Pix kvar: " + PixBankKonto);


                    }

                    else if (tärning1 == ValtLyckoTal && tärning2 == ValtLyckoTal || tärning2 == ValtLyckoTal && tärning3 == ValtLyckoTal || tärning3 == ValtLyckoTal && tärning1 == ValtLyckoTal)
                    {
                        Console.WriteLine("Tärning ett blev: " + tärning1 + " Tärning två blev: " + tärning2 + " Tärning tre blev: " + tärning3);
                        SatsadePix = SatsadePix *= 3;
                        Console.WriteLine("Du har Vunnit: " + SatsadePix + " Pix");
                        PixBankKonto = PixBankKonto += SatsadePix;
                        Console.WriteLine("Pix kvar: " + PixBankKonto);
                    }


                    else if (tärning1 == ValtLyckoTal || tärning2 == ValtLyckoTal || tärning3 == ValtLyckoTal)
                    {

                        Console.WriteLine("Tärning ett blev: " + tärning1 + " Tärning två blev: " + tärning2 + " Tärning tre blev: " + tärning3);
                        SatsadePix = SatsadePix *= 2;
                        Console.WriteLine("Du har Vunnit: " + SatsadePix + " Pix");
                        PixBankKonto = PixBankKonto += SatsadePix;
                        Console.WriteLine("Pix kvar: " + PixBankKonto);


                    }

                    else
                    {
                        Console.WriteLine("Tärning ett blev: " + tärning1 + " Tärning två blev: " + tärning2 + " Tärning tre blev: " + tärning3);
                        Console.WriteLine("Du har förlorat: " + SatsadePix + " Pix");
                        PixBankKonto = PixBankKonto -= SatsadePix;
                        Console.WriteLine("Pix Kvar: " + PixBankKonto);

                    }

                }

                else
                {
                    Console.WriteLine("Du angivit ett för stort eller litet tal");


                }


                if (PixBankKonto >= 50)
                {

                    Console.WriteLine("Vill du spel igen? " + "Skriv ja om du vill köra igen.");

                    sant = Console.ReadLine();
                    Console.Clear();

                }

            }
        }


    }


}
