using System;

namespace TheGame
{
    class Pretty //Making things look better 
    {
        public static void TextWithColor(string text, string color, string coloredtText, string moreText)
        {
            Console.Write(text);

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

            Console.Write(coloredtText);

            Console.ResetColor();

            Console.Write(moreText);
        }

        public static void HealthBox()
        {
            //very ugly method but it works. Its' more difficult because of TextWithColor and
            //becaue of the divider that divide the player and the enemy. 

            int playerHP = Player.stats.HP;
            int playerMaxHP = Player.stats.MaxHP;
            string player = Player.stats.Name;
            string enemy = "";
            int enemyHP = 0;
            int enemyMaxHP = 0;

            if (Check.Boss() == false) { enemy = "Slime"; enemyHP = Slime.stats.HP; enemyMaxHP = Slime.stats.MaxHP; }
            else if (Check.Boss() == true) { enemy = "King Slime"; enemyHP = KingSlime.stats.HP; enemyMaxHP = KingSlime.stats.MaxHP; }

            
            string allText = $"│ {player} HP[{playerHP}/{playerMaxHP}]    │    {enemy} HP[{enemyHP}/{enemyMaxHP}]      │";
            int numberOfChars = allText.Length;

            int t = 0;
            Console.Write("┌");
            for (int i = 0; i < numberOfChars; i++)
            {
                char symbol = allText[i];

                if (symbol.ToString() == "│")
                {
                    t++;
                    if (t == 2) Console.Write("┬");
                }
                else Console.Write("─");
            }
            Console.WriteLine("┐");

            if (playerHP > 10)
            {
                if (enemyHP >10)
                {
                    Console.Write($"│ {player} HP[{playerHP}/{playerMaxHP}]    ");
                    TextWithColor("│    ", "Green", $"{enemy}", $" HP[{ enemyHP}/{ enemyMaxHP}]      │\n");
                }
                else if (enemyHP <=10)
                {
                    Console.Write($"│ {player} HP[{playerHP}/{playerMaxHP}]    ");

                    TextWithColor("│    ", "Green", $"{enemy}", "");
                    TextWithColor(" HP[", "Red", $"{enemyHP}", $"/{ enemyMaxHP}]      │\n");
                }
            }

            else 
            {
                if (enemyHP > 10)
                {
                    TextWithColor($"│ {player} HP[", "Red", $"{playerHP}", $"/{playerMaxHP}]    ");

                    TextWithColor("│    ", "Green", $"{enemy}", $" HP[{ enemyHP}/{ enemyMaxHP}]      │\n");
                }
                else if (enemyHP <=10)
                {
                    TextWithColor($"│ {player} HP[", "Red", $"{playerHP}", $"/{playerMaxHP}]    ");

                    TextWithColor("│    ", "Green", $"{enemy}", "");
                    TextWithColor(" HP[", "Red", $"{ enemyHP}", $"/{ enemyMaxHP}]      │\n");
                }
            }


                int t2 = 0;
            Console.Write("└");
            for (int i = 0; i < numberOfChars; i++)
            {
                char symbol = allText[i];

                if (symbol.ToString() == "│")
                {
                    t2++;
                    if (t2 == 2) Console.Write("┴");
                }
                else Console.Write("─");
            }
            Console.WriteLine("┘");
        }

        public static void MainMenuBox()
        {
                Box.Simple(new string[] {$"     What do you want to do, {Player.stats.Name}?",
                                          "[1]  Venture forth into the unknown",
                                          "[2]  Check your status",
                                          "[3]  Go shopping" });
        }

        public static void BattleMenuBox()
        {
            Box.Simple(new string[] {$"     What should you do now, {Player.stats.Name}?",
                                      "[1]  Strike!",
                                      "[2]  Use potion",
                                      "[3]  Attempt to flee" });
        }

        public static void HealOptionsBox()
        {
            int[] amount = Check.Inventory();

                 int length = "┌──────────────────────────────┐".Length;
            Console.WriteLine("┌───┬──────────────────────────┐");
            Check.SpaceToAdd($"│ 1 │ Herb:         [{amount[0]}]", length);
            Check.SpaceToAdd($"│ 2 │ Potion:       [{amount[1]}]", length);
            Check.SpaceToAdd($"│ 3 │ Mega Potion:  [{amount[2]}]", length);
            Console.WriteLine("├───┴──────────────────────────┤\n" +
                              "│  Press Backspace to go back  │\n" +
                              "└──────────────────────────────┘\n");
        }


        public static void StatusBox()
        {
                 int length = "├──────────┴───────────────────┐".Length;

            Console.WriteLine("┌──────────┬───────────┐");
                TextWithColor("│  ", "Yellow", "STATUS", "  │ INVENTORY │\n");
            Console.WriteLine("├──────────┴───────────┴───────┐");
            Check.SpaceToAdd($"│ Level:        [{Player.stats.LVL}]", length);
            Check.SpaceToAdd($"│ Exp:          [{Player.stats.EXP}]", length);
            Check.SpaceToAdd($"│ Health:       [{Player.stats.HP}/{Player.stats.MaxHP}]", length);
            Check.SpaceToAdd($"│ Attack:       [{Player.stats.ATK}]", length);
            Check.SpaceToAdd($"│ Defence:      [{Player.stats.ATK}]", length);
            Console.WriteLine("├──────────────────────────────┴──────────────────────────────────────┐\n" +
                              "│ Use the arrow keys to switch between the status and inventory menus │\n" +
                              "├──────────────────────────────┬──────────────────────────────────────┘\n" +
                              "│  Press Backspace to go back  │\n" +
                              "└──────────────────────────────┘\n");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    InventoryBox();
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    Menu.MainMenu();
                    break;
                default:  Console.Clear(); StatusBox(); break;
            }
        }

        public static void InventoryBox()
        {
            int[] amount = Check.Inventory();
            int length = "├───────────┴──────────────────┐".Length;

            Console.WriteLine("┌──────────┬───────────┐");
                TextWithColor("│  STATUS  │ ","Yellow", "INVENTORY"," │\n");
            Console.WriteLine("├──────────┴───────────┴───────┐");
            Check.SpaceToAdd($"│ Gold:         [{Player.stats.Gold}]", length);
            Check.SpaceToAdd($"│ Herb:         [{amount[0]}]", length);
            Check.SpaceToAdd($"│ Potion:       [{amount[1]}]", length);
            Check.SpaceToAdd($"│ Mega Potion:  [{amount[2]}]", length);
            if (amount[3] == 1) Check.SpaceToAdd($"│ The Chad-Xīn hammer", length);
            Console.WriteLine("├──────────────────────────────┴──────────────────────────────────────┐\n" +
                              "│ Use the arrow keys to switch between the status and inventory menus │\n" +
                              "├──────────────────────────────┬──────────────────────────────────────┘\n" +
                              "│  Press Backspace to go back  │\n" +
                              "└──────────────────────────────┘\n");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Pretty.StatusBox();
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    Menu.MainMenu();
                    break;
                default: Console.Clear(); InventoryBox(); break;
            }
        }
        public static void ShopBox()
        {
            bool gotChadXin = false;
            if (Check.Inventory()[3] == 1) gotChadXin = true;
          
                 int length = "├──────────┴─────────────────────────────────┐".Length;
            Console.WriteLine("┌────────────┬─────────────────┐");
               TextWithColor("│    ", "Yellow", "SHOP", $"    │"); Check.SpaceToAdd($"    GOLD: {Player.stats.Gold}", 18);
            Console.WriteLine("├───┬────────┴─────────────────┴─────────────┐");
            Check.SpaceToAdd($"│ 1 │ Buy Herb for 30 gold", length);
            Check.SpaceToAdd($"│ 2 │ Buy Potion for 60 gold.", length);
            Check.SpaceToAdd($"│ 3 │ Buy Mega Potion for 90 gold.", length);
            if (gotChadXin == false) Check.SpaceToAdd($"│ 4 │ Buy the Chad-Xīn hammer for 400 gold.", length);
            Console.WriteLine("├───┴──────────────────────────┬─────────────┘\n" +
                              "│  Press Backspace to go back  │\n" +
                              "└──────────────────────────────┘\n");
            }
        }
    }

