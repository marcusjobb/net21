// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;
    internal class MatteTabeller
    {
        public void Start()
        {
            Console.WriteLine("Mattetabeller");

            for (int tabell = 1; tabell < 16; tabell++)
            {
                for (int multi = 1; multi < 11; multi++)
                {
                    Console.Write($"{tabell * multi}\t");
                }
                Console.WriteLine();
            }
        }
    }
}