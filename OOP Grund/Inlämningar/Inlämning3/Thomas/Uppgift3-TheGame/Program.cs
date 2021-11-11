// -----------------------------------------------------------------------------------------------
//  Program.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    public class Program
    {
        public Game game;
        public static void Main()
        {
            int percentEncounterChance = 6;
            Game game = new(percentEncounterChance);
            game.Start();
        }
    }
}
