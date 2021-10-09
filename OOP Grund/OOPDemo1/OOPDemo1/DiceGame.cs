// -----------------------------------------------------------------------------------------------
//  DiceGame.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace OOPDemo1 // hus
{
    internal class DiceGame // rum
    {
        int value;
        int max = 6;
        // constructor - det första som körs när man instansierar en klass
        public DiceGame(int max)
        {
            this.max = max;
        }
        public DiceGame()
        {
            max = 6; // vanlig T6
        }

        public int RollDice()
        {
            Random rnd = new Random();
            value = rnd.Next(1, max + 1);
            return value;
        }
    }
}