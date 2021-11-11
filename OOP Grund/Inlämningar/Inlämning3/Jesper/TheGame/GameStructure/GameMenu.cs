using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.Helpers.UserExperience;
using static TheGame.DisplayMethods.Display;
using static TheGame.GameAssets.ArtAssets;


namespace TheGame
{
    public class GameMenu
    {
        /// <summary>
        /// Uses the GameMenu constructor to show the splashscreen when the GameMenu is called. Might not be a proper way of doing things but it works.
        /// </summary>
        public GameMenu()
        {
            GameAssets.Splashscreen.Show();
        }
        /// <summary>
        /// An outer menu to the game. If the user selects the New Game option, the "real" game is initialized.
        /// </summary>
        public void StartMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.CursorVisible = false;
                WriteColour(gameTitle,ConsoleColor.Yellow);
                List<string> newGameMenu = new List<string> {
                    "[1] New Game",
                    "[2] Visit the Graveyard",
                    "[3] Visit the Hall of Heroes",
                    "[4] Exit Game" };
                CursorPosition(0, 0);
                WriteLineColour(menuCandles, ConsoleColor.Yellow);
                MiddleWriteLines(newGameMenu);
                CursorPosition(18, 47);
                int.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        Game newGame = new();
                        newGame.Start();
                        break;
                    case 2:
                        // Displays all the previous players who died (in a session) by looping through a list.
                        Console.Clear();
                        WriteLineColour(graveyardText, ConsoleColor.DarkGray);
                        CenterWriteLine("Here lies the fallen.\n");
                        foreach (var player in Game.fallenPlayers)
                        {
                            CenterWriteLine($"{player.Name}. Level [{player.Level}].\n");
                        }
                        CenterPressEnterToContinue();
                        break;
                    case 3:
                        // Displays all the players who successfully reached level 10 and won the game.
                        Console.Clear();
                        WriteLineColour(hallOfHeroesText, ConsoleColor.Yellow);
                        CenterWriteLine("Monuments raised to the Victorious Few.\n");
                        foreach (var player in Game.victoryPlayers)
                        {
                            CenterWriteLine($"{player.Name}. Attributes: [{player.Strength} strength. {player.Toughness} toughness.].\n");
                        }
                        CenterPressEnterToContinue();
                        break;
                    case 4:
                        Console.Clear();
                        GameAssets.Splashscreen.Show();
                        showMenu = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
