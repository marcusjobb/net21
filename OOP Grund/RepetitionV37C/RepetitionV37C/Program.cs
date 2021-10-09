// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace RepetitionV37C
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10;
            int value2 = 0;

            DivideNumbers(value1, value2);
        }

        private static void DivideNumbers(int value1, int value2)
        {
            // Kontrollerar
            if (value2 != 0)
            {
                // Bearbeta värden
                double res = value1 / value2;
                // Presenterar resultat
                Console.WriteLine(res);
            }
            else
            {
                // Presenterar resultat
                Console.WriteLine("Error ID10T: External error.");
                Console.WriteLine("Can not divide with Zero.");
            }
        }
    }
}
