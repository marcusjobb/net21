// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace BFU_Vecka1_01 // Hus
{
    using System; // Vi kommer att använda saker från det huset

    class Program // Rum
    {
        static void Main() // Möbel
        {
            // Variabel = burk
            // typ = vad den ska innehålla
            // namn = etikett på burken

            // deklarera variabel = skapa variabel
            // typ namn;
            string hero = null;

            // tilldela värde = ge den något att ha
            hero = "Bruce Wayne";

            Console.WriteLine(hero);
            Console.WriteLine(hero.Length);

            string girlfriend = "Celina Kyle";

            Console.WriteLine(hero + " <3 " + girlfriend);

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.Write("Hello World!");
            Console.WriteLine(" <--- Yay!");

        }
    }
}
