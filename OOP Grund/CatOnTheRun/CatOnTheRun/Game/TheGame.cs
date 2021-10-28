// -----------------------------------------------------------------------------------------------
//  Game.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Game
{
    using System;

    using CatOnTheRun.Enums;
    using CatOnTheRun.GUI;
using Figgle;

    internal class TheGame
    {
        internal void Start()
        {
            while (true)
            {
                var menu = new MainMenu();
                MainMenuChoices choice = (MainMenuChoices)menu.Show("New game", "About the game", "Leave this game");
                switch (choice)
                {
                    case MainMenuChoices.Start:
                        NewGame();
                        break;
                    case MainMenuChoices.About:
                        About();
                        break;
                    case MainMenuChoices.Quit:
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Quit()
        {
            Console.Clear();
            NiceText.ShowStory("Byeeee","I hope you enjoyed the game...");
            Console.WriteLine();
            Environment.Exit(0);
        }
    private void About()
        {
            Console.Clear();
            NiceText.ShowStory("About the game",
@"I decided to write a cute game instead of a scary one,
and nothing is more cuter than a kitten!");
            Console.WriteLine();
            Helpers.Input.Pause();
        }

        private void NewGame()
        {
            Console.WriteLine(FiggleFonts.Chunky.Render("The Game"));
            Helpers.Input.Pause();


            // var result = text.Result; //Get every Single line

            //NiceText.ShowStory("Identification required" "Please enter the name of the kitten!");
        }
    }
}
