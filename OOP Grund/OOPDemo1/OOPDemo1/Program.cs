// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace OOPDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceGame dc = new DiceGame(100);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dc.RollDice());
            }

        }
    }
}
