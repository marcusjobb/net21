// -----------------------------------------------------------------------------------------------
//  Program.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
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
