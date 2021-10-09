// -----------------------------------------------------------------------------------------------
//  Repetetion_del_2.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Net21RepetitionV37
{
    using System;

    /*
    *  Definiera variabler
    *  Kontrollera värden
    *  Bearbeta värden
    *  Presentera resultat
    * */

    internal class Repetetion_del_2
    {
        // Först klass variabler
        private readonly int antalDjur = 10;
        // publika metoder
        public int RäknaDjur()
        {
            // först deklarera variabler
            int counter = 0;

            // Kontrollera variabler
            while (counter < 10)
            {
                // Bearbeta rubbet
                counter++;
            }
            // Presentera för användaren
            return counter;
        }

        // privata metoder
        private int MataDjur()
        {
            int katter = 3;
            int månader = 10;
            //    definiera     kontrollera   bearbeta
            for (int count = 0; count < 10; count++)
            {

            }

            if (katter > 2)
            {
                // Deklarerar
                double kattUngar = katter * månader / 6;

                // Kontrollera
                if (katter > 300)
                {
                    // Presentera
                    Console.WriteLine("Panik! Katterna tar över");
                }
            }


            return 0;
        }
    }
}
