using System;
using System.Collections.Generic;

namespace TheGame
{
    class Check //Methods for checking and deciding various things
    {
        public static int DiceRoll()
        {
            Random roll = new Random();
            int result = roll.Next(1, 7);
            return result;
        }

        public static int NegativeStat(int stat)
        {
            if (stat <= 0) stat = 1;
            return stat;
        }

        public static bool Boss()
        {
            bool boss = false;
            if (Player.stats.LVL == 9) boss = true;

            return boss;
        }

        public static (List<int>, string) WhoIsStrikingWho()
        {
            int atk = 0;
            int def = 0;
            int hp = 0;
            string striker = "";

            var stats = new List<int>();

            if (Battle.playerTurn == true)
            {
                atk = Player.stats.ATK + Player.stats.LVL*4;  //the player.lvl*4 is for balancing. You want the player to win lol
                if (Check.Inventory()[3] == 1) atk = 1337;
                striker = "Player";

                if (Boss() == false)
                {
                    def = Slime.stats.DEF;
                    hp = Slime.stats.HP;
                }
                else if (Boss() == true)
                {
                    def = KingSlime.stats.DEF;
                    hp = KingSlime.stats.HP;
                }
            }
            else if (Battle.playerTurn == false)
            {
                if (Boss() == false)
                {
                    atk = Slime.stats.ATK;
                    striker = "Slime";
                }
                else if (Boss() == true)
                {
                    atk = Slime.stats.ATK;
                    striker = "Slime King";
                }
                def = Player.stats.DEF;
                hp = Player.stats.HP;
            }
            stats.Add(atk);
            stats.Add(def);
            stats.Add(hp);

            return (stats, striker);
        }

        public static void GoldGet()
        {
            int goldGet = Check.DiceRoll() + 3 * 20;
            Player.stats.Gold = Player.stats.Gold + goldGet;

            Box.Simple(new string[] { $"{goldGet} gold was added to your inventory!" });
        }

        public static void ExpGet()
        {
            int exp = Player.stats.EXP;
            exp = (Slime.stats.LVL + DiceRoll()) * (DiceRoll() + 5);
            Player.stats.EXP = Player.stats.EXP + exp;

            Box.Simple(new string[] { $"You gained {exp} experience points!" });

            Level();
        }

        public static void Level()
        {
            int exp = Player.stats.EXP;
            int LvlUpCheck = Player.stats.LVL;
            int level = Player.stats.LVL;
            int expNeeded = level * 100;

            if (exp >= expNeeded)
            {
                Player.stats.LVL = level + 1;
                level++;
                Player.stats.ATK = Player.stats.ATK + DiceRoll();
                Player.stats.DEF = Player.stats.DEF + DiceRoll();
                Player.stats.MaxHP = Player.stats.MaxHP + DiceRoll();
                Player.stats.HP = Player.stats.MaxHP;
            }
            if (LvlUpCheck != level) Box.Simple(new string[] { $"You leveled up to level {level}!" });
        }

        public static void Purchase(string item, int price)
        {
            int gold = Player.stats.Gold;

            if (gold >= price)
            {
                Box.Simple(new string[] {$"Do you want to buy {item}?",
                "[Press space for Yes, any other key for no]"});

                var command = Console.ReadKey().Key;
                if (command == ConsoleKey.Spacebar)
                {
                    Dialogue.ClearLine();
                    Player.stats.Gold = Player.stats.Gold - price;
                    Player.Items.Add(item);
                    Menu.ShopMenu();
                }
            }
            else
            {
                Box.Simple(new string[] { "You cannot afford that." });
                Menu.ShopMenu();
            }
        }

        public static int[] Inventory()
        {
            int herb = 0;
            int potion = 0;
            int megaPotion = 0;
            int chadXin = 0;

            foreach (var item in Player.Items)
            {
                if (item == "Herb")
                {
                    herb++;
                }

                if (item == "Potion")
                {
                    potion++;
                }

                if (item == "Mega Potion")
                {
                    megaPotion++;
                }

                if (item == "Chad-Xīn")
                {
                    chadXin = 1;
                }
            }

            int[] amounts = new int[] { herb, potion, megaPotion, chadXin };

            return amounts;
        }

        public static void SpaceToAdd(string text, int length) //For helping with boxbuilding
        {
            int spaces = length - text.Length - 1;

            Console.Write(text);
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("│");
        }

        public static void HealthAmount()
        {
            if (Player.stats.HP > 10)
            {
                if (Check.Boss() == false)
                {
                    if (Slime.stats.HP > 10) BattleAnimation.IdleVsSlime();
                    else if (Slime.stats.HP <= 10) BattleAnimation.SlimeLow();
                }
                if (Check.Boss() == true)
                {
                    if (Slime.stats.HP > 10) BattleAnimation.IdleVsKing();
                    else if (Slime.stats.HP <= 10) BattleAnimation.KingLow();
                }
            }
            else if (Player.stats.HP <= 10)
            {
                if (Check.Boss() == false)
                {
                    if (Slime.stats.HP > 10) BattleAnimation.PlayerLowVsSlime();
                    else if (Slime.stats.HP <= 10) BattleAnimation.PlayerAndSlimeLow();
                }

                if (Check.Boss() == true)
                {
                    if (Slime.stats.HP > 10) BattleAnimation.PlayerLowVsKing();
                    else if (Slime.stats.HP <= 10) BattleAnimation.PlayerAndKingLow();
                }
            }
        }

        public static bool CanUse(string item)
        {
            bool canUse = false;

            if (Player.Items.Contains(item))
            {
                Player.Items.Remove(item);
                canUse = true;
            }
            return canUse;
        }

        public static void Escape()
        {
            if (DiceRoll() > 3)
            {
                Box.Simple(new string[] {"You managed to escape..."});
                Menu.MainMenu();
            }
            else
            {
                Box.Simple(new string[] { "You failed your escape" });
                Battle.playerTurn = false;
                Battle.SlimeTurn();

            }
        }
    }
}
