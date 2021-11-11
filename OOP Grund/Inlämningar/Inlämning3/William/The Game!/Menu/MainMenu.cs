using System;
using static The_Game.HelperClass;

namespace The_Game
{
    class MainMenu
    {
        public void mainMenu()
        {
            Write("Welcome to THE GAME!");
            PlayerClass.PlayerStart();
            while (true)
            {
                if (PlayerClass.player.Level == 10)
                    break;

                Write("What do you want to do?");
                Write("1: Adventure");
                Write("2: Show stats");
                Write("3: Exit");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Adventure adventure = new();
                    adventure.AdventureStart();
                    if (PlayerClass.player.HP <= 0)
                    {
                        adventure.PlayerDead();
                        break;
                    }
                    else 
                        adventure.MonsterDead();
                }

                if (input == "2")
                    PlayerClass.ShowPlayerStats();
                if (input == "3")
                    break;
            }
            Write("Better luck next time!");
        }
    }
}
