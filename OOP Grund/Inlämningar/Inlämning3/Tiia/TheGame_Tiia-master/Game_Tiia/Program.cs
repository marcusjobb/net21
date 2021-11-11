using System;

namespace Game_Tiia
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.StartScreen();
            Menu.MainHeader();

            Player player = new Player(); //instansierar en spelare
            AskForName(player);

            while (player.Hp > 0)
            {
                Menu.MainMenu();
                int menuChoise = UserInput();

                switch (menuChoise)
                {
                    case 1: AdventureTime.WhileOnAdventure(player); break;
                    case 2: ShowDetails(player.Name, player.Level, player.Exp, player.Hp, player.Gold, player.Strenght, player.Toughness); break;
                    case 3: Shop.ShopItems(player); break;
                    case 4: Console.WriteLine("Thank you for playing!"); Environment.Exit(0); break;

                    default: break;
                }
            }

            if (player.Level > 10)
            {
                PlayerWins();
            }
        }

        private static string AskForName(Player player)
        {
            Console.Write("\nWelcome traveler! What should we call you? ");
            Visual.ChangeToCyan();
            player.Name = Console.ReadLine().ToString();
            Console.ResetColor();
            return player.Name;
        }

        private static int UserInput()
        {
            int menuChoise = 0;
            Visual.ChangeToCyan();
            var input = int.TryParse(Console.ReadLine(), out menuChoise);
            Console.ResetColor();
            return menuChoise;
        }

        private static void ShowDetails(string username, int level, int exp, int hp, int gold, int strenght, int toughness)
        {
            Visual.ChangeToMagenta();
            Console.WriteLine("═════════════════════════");
            Console.ResetColor();
            Console.WriteLine($"Name:       {username}");
            Console.WriteLine($"Level:      {level}");
            Console.WriteLine($"HP:         {hp}/200");
            Console.WriteLine($"Exp:        {exp}/100");
            Console.WriteLine($"Gold:       {gold}");
            Console.WriteLine($"Strenght:   {strenght}");
            Console.WriteLine($"Toughness:  {toughness}");
            Visual.ChangeToMagenta();
            Console.WriteLine("═════════════════════════");
            Console.ResetColor();
            Visual.ChangeToCyan();
            Console.WriteLine("Press any key to go back to MENU");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
        private static void PlayerWins()
        {
            
        }
    }
}
