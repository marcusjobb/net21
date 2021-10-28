// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun
{
    using CatOnTheRun.Game;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var theGame = new TheGame();
            theGame.Start();
        }
    }
}
