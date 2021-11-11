using System;

namespace TheGame
{
    class Battle //Methods for battle
    {
        public static bool playerTurn = true;

        public static void SlimeTurn()
        {
            if (playerTurn == false && Check.Boss() == false)
            {
                Pretty.TextWithColor("The ", "Green", "slime", " lunges at you!\n");
                Strike();
            }          
        }

        public static void KingSlimeTurn()
        {
            if (playerTurn == false && Check.Boss() == true)
            {
                Pretty.TextWithColor("The ", "Green", "Slime King", " wobbles at you!\n");
                Strike();
            }
        }

        public static void Strike()
        {
            var stat = Check.WhoIsStrikingWho();
            int atk = stat.Item1[0];
            int def = stat.Item1[1];
            int hp = stat.Item1[2];
            string striker = stat.Item2;

            int strikePower = Check.DiceRoll() + atk + 5; // +5 is to make it so both you and the enemy makes more hits
            int damage = strikePower - def;

            if (damage < 1) Console.WriteLine("That did no damage.");
            else
            {
                hp = hp - damage;

                if (playerTurn == true && Check.Boss() == false)
                {
                    Slime.stats.HP = hp;
                    BattleAnimation.PlayerStrikeSlime();
                }
                else if (playerTurn == true && Check.Boss() == true)
                {
                    KingSlime.stats.HP = hp;
                    BattleAnimation.PlayerStrikeKing();
                }
                else
                {
                    Player.stats.HP = hp;
                    if (Check.Boss() == false) BattleAnimation.SlimeStrike();
                    else if (Check.Boss() == true) BattleAnimation.KingStrike();                
                }              
                Dialogue.StrikeText(striker, damage, hp);
                Dialogue.PressAny();
                Console.Clear();
            }

           

            if (Player.stats.HP <= 0)
            {
                Dialogue.GameOver();
            }
            else
            {
                if (Check.Boss() == false)
                {
                    if (Slime.stats.HP > 0)
                    {
                        playerTurn = !playerTurn;
                        SlimeTurn();
                        Console.Clear();
                        Menu.BattleMenu();
                    }
                    else if (Slime.stats.HP <= 0) Dialogue.VictorySlime();
                }
                else if (Check.Boss() == true)
                {
                    if (KingSlime.stats.HP > 0)
                    {
                        playerTurn = !playerTurn;
                        KingSlimeTurn();
                        Console.Clear();
                        Menu.BattleMenu();
                    }
                    else if (KingSlime.stats.HP <= 0) Dialogue.VictoryKing();
                }
            }
        }

        public static void Heal(string item)
        {
            int healthGained = 0;
            if (item == "Herb") healthGained = 15;
            if (item == "Potion") healthGained = 20;
            if (item == "Mega Potion") healthGained = 30;

            Player.stats.HP = Player.stats.HP + healthGained;
            Console.WriteLine($"You gained {healthGained} health");

            playerTurn = !playerTurn;

            SlimeTurn();
            Menu.BattleMenu();
        }
    }
}
