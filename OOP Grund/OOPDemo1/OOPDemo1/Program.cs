// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
