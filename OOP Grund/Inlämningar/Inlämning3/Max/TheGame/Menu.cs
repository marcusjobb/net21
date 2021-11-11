using System;

namespace TheGame
{
    class Menu  //Menus
    {
        public static void StartMenu()
        {
            Box.Simple(new string[] { "Greetings, bold adventurer! Let us not linger. State thy name and I shall maketh so thyne adventure begins!" });

            Player.stats.Name = Console.ReadLine();
            string text = $"│ Well then, {Player.stats.Name}. I shall transport thee to the realm of the Slime King! │";
            int length = text.Length;

            Box.Roof(length);
            Pretty.TextWithColor($"│ Well then, {Player.stats.Name}. I shall transport thee to the realm of the ", "Green", "Slime King", "! │\n");
            Box.Floor(length);

            Dialogue.PressSpace();
            Console.Clear();
            Box.Simple(new string[] { "You awake just outside of a small village, eager to begin your quest..." });
            Dialogue.PressSpace();
            Console.Clear();
        }

        public static void MainMenu()
        {
            while (true)
            {

                Pretty.MainMenuBox();

                var command = Console.ReadKey();
                switch (command.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Encounters.EncounterDecider();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Menu.StatsMenu();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Dialogue.Greeting();
                        ShopMenu();
                        break;
                    default:
                        Console.Clear();
                        MainMenu();
                        break;
                }
            }
        }

        public static void ShopMenu()
        {
            bool gotChadXin = false;
            if (Check.Inventory()[3] == 1) gotChadXin = true;

            Pretty.ShopBox();

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Check.Purchase("Herb", 30);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Check.Purchase("Potion", 60);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Check.Purchase("Mega Potion", 90);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    if (gotChadXin == false) Check.Purchase("Chad-Xīn", 400);
                    else ShopMenu();
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    ShopMenu();
                    break;
            }
        }

        static bool showingStatus = true;
        public static void StatsMenu()
        {
            if (Menu.showingStatus == true)
            {       
                Pretty.StatusBox();
            }
            else Pretty.InventoryBox();

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Pretty.StatusBox();
                    showingStatus = true;
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    Pretty.InventoryBox();
                    showingStatus = false;
                    break;
                default:
                    if (showingStatus == true)
                    {
                        Console.Clear();
                        Pretty.StatusBox();
                    }
                    else
                    {
                        Console.Clear();
                        Pretty.InventoryBox();
                        showingStatus = false;
                    }
                    break;
            }
        }

        public static void BattleMenu()
        {
            Pretty.BattleMenuBox();

            Pretty.HealthBox();

            Check.HealthAmount();
            
            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("You strike!");
                    Battle.Strike();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    HealMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Check.Escape();
                    break;
                default:
                    Console.Clear();
                    BattleMenu();
                    break;
            }
        }

        public static void HealMenu()
        {
            Pretty.HealOptionsBox();

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    if (Check.CanUse("Herb")) Battle.Heal("Herb");
                    else HealMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                   if (Check.CanUse("Potion")) Battle.Heal("Potion");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                   if (Check.CanUse("Mega Potion")) Battle.Heal("Mega Potion");
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    BattleMenu();
                    break;
                default:
                    Console.Clear();
                    HealMenu();
                    break;
            }
        }
    }
}
