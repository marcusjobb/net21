// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Övning_6___För_liten_array
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            const int MaxValuesAtStart = 10;
            // -------------------------------------------------------------------
            // Instansiera randomizer
            // -------------------------------------------------------------------
            Random rnd = new Random();
            // -------------------------------------------------------------------
            // skapa array för 10 tal
            // -------------------------------------------------------------------
            int[] nuffror = new int[MaxValuesAtStart];
            // -------------------------------------------------------------------
            // lägg till slumpade värden i listan
            // -------------------------------------------------------------------
            for (int i = 0; i < MaxValuesAtStart; i++)
            {
                nuffror[i] = rnd.Next(0, 100);
            }

            // -------------------------------------------------------------------
            // skapa temporär array för 20 tal
            // -------------------------------------------------------------------
            int[] tmp = new int[20];

            // -------------------------------------------------------------------
            // kopiera nuffer arrayen till temp
            // -------------------------------------------------------------------
            Array.Copy(nuffror, tmp, nuffror.Length);

            // -------------------------------------------------------------------
            // kopiera tmp arrayen till nuffror
            // egentligen döp om tmp till nuffror
            // -------------------------------------------------------------------
            nuffror = tmp;
            // original nuffror försvinner och både tmp och nuffror blir likadana
            // och använder samma plats i minnet

            // -------------------------------------------------------------------
            // loopa igenom 5 värden och stoppa in i listan
            // -------------------------------------------------------------------
            for (int i = 10; i < 16; i++)
            {
                nuffror[i] = rnd.Next(0, 100);
            }

            // -------------------------------------------------------------------
            // skriv ut listan
            // värden som inte fyllts på blir noll vid utskrift
            // -------------------------------------------------------------------
            for (int i = 0; i < nuffror.Length; i++)
            {
                int nuffra = nuffror[i];
                Console.WriteLine(nuffra + " tmp=" + tmp[i]);
            }
        }
    }
}