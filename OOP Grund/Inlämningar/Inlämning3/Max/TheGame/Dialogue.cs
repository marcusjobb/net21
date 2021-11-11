using System;

namespace TheGame
{
    class Dialogue //Dialogue and dialogue helper
    {
        public static void PressSpace()
        {
            var keypress = ConsoleKey.A;
            Console.WriteLine("[Press space to continue]");
            do
            {
                keypress = Console.ReadKey().Key;
                Console.SetCursorPosition(0, Console.CursorTop);
                ClearLine();
            } while (keypress != ConsoleKey.Spacebar);
        }

        public static void PressAny()
        {
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            ClearLine();
        }

        public static void ClearLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static int TimesVisited = 0;
        static public void Greeting()
        {
            string shopGreeting = "";

            if (TimesVisited == 0)
            {
                shopGreeting = "Welcome, traveler. I haven't seen you around. What can I offer you?";
            }
            else if (TimesVisited == 1 || TimesVisited == 2)
            {
                shopGreeting = "Welcome back, traveler. What may I offer you this time?";
            }
            else if (TimesVisited == 3)
            {
                shopGreeting = "You again? You're almost a regular around here now! Here's what I can offer you.";
            }
            else if (TimesVisited > 3)
            {
                shopGreeting = $"Ah, {Player.stats.Name}! Welcome back. What can I do for you, friend?";
            }
            TimesVisited++;

            Box.Simple(new string[] { shopGreeting });
        }

        public static void StrikeText(string striker, int damage, int hp)
        {
            if (striker == "Player")
            {
                Console.WriteLine($"Your attack does {damage} damage! ");
            }
            else if (striker == "Slime")
            {
                Pretty.TextWithColor("The ", "Green", "slime's", $" attack delt {damage} damage!\n");
            }
            else if (striker == "Slime King")
            {
                Pretty.TextWithColor("The ", "Green", "Slime King's", $" attack delt {damage} damage!\n");
            }
        }

        public static void VictorySlime()
        {
            Pretty.TextWithColor("The ", "Green", "slime", " has been defeated!\n");
            BattleAnimation.SlimeDead();
            Pretty.TextWithColor("You grab a piece of the ", "Green", "slime", " and eat it. \n" +
                "It fills you with strength (20 HP to be exact)! But it's kind of gross.\n");
            Player.stats.HP = Player.stats.HP + 20;

            Check.ExpGet();
            PressAny();
            Console.Clear();

            if (Check.DiceRoll() > 2)
            {
                Console.WriteLine("There was some gold stuck in it's goo so you wash it off and put it in your pockets");
                Check.GoldGet();
                PressAny();
                Console.Clear();
            }
            
            Menu.MainMenu();
        }

        public static void VictoryKing()
        {
            Pretty.TextWithColor("The ", "Green", "Slime King", " has been defeated!\n");
            BattleAnimation.KingDead();
            Pretty.TextWithColor("You grab a piece of the ", "Green", "Slime King", " and eat it. \n" +
                "It fills you with unmeasurable strength! But it's still kind of gross...\n");

            Box.Simple(new string[] { $"You gained one billion experience points!" });
            Box.Simple(new string[] { $"You leveled up to level 9999 or whatever! You won the game!" });
            Player.stats.LVL = 9999;

            EndScreen animation = new EndScreen();
            animation.Delay = 300;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                animation.Turn(sequenceCode: 0);
                Console.ResetColor();
            }
        }

        public static void GameOver()
        {
            Pretty.TextWithColor("", "Red", "You are dead", "\n");
            if (Check.Boss() == false) BattleAnimation.PlayerDeadVsSlime();
            else BattleAnimation.PlayerDeadVsKing();
            Pretty.TextWithColor("", "Red", "Game Over", "\n");
            Dialogue.PressAny();
            Environment.Exit(1);
        }

    }
}
