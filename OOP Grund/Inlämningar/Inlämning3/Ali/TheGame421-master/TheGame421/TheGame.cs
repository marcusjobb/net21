using System;
using System.Collections.Generic;

namespace TheGame421
{
    public class TheGame
    {
        private bool Dead = false;
        private bool Exit = false;
        private int Choice = 0;
        private int Chance = 0;
        private readonly List<Player> Players = new List<Player>();
        private readonly List<SpecificMonster> Monsters = new List<SpecificMonster>();
        private readonly List<Shop> Shops = new List<Shop>();

        internal void CreateShop() //Skapar en shop
        {
            Shop TheShop = new Shop
            {
                AmuletOfStrength = true,
                AmuletOfStrengthAmount = 5,
                AmuletOfToughness = true,
                AmuletOfToughnessAmount = 5,
                Gold = 1000,
                HealingSword = true
            };
            Shops.Add(TheShop);
        }

        public void CreatePlayer() //Skapar en spelare
        {
            Player ThePlayer = new Player();
            Console.Write("Enter Player Name: ");
            ThePlayer.Name = Console.ReadLine();
            ThePlayer.Health = 100;
            ThePlayer.MaxHealth = 100;
            ThePlayer.Level = 1;
            ThePlayer.Exp = 1;
            ThePlayer.MaxExpThisLevel = 12;
            ThePlayer.Gold = 10;
            Players.Add(ThePlayer);
            Console.Clear();
        }

        public void GoAdventureChoice() // Går ut på äventyr
        {
            Random Ran = new Random();
            Chance = Ran.Next(1, 100);
            if (Chance >= 90)
            {
                Console.WriteLine("You see nothing but Grass");
                PressSomething();
            }
            else
            {
                Fight();
            }
        }

        public void PlayerAttack() // Spelaren attackerar
        {
            int damage = 0;
            Random Ran = new Random();

            if (Players[0].HealingSword.Equals(true)) // Använder ett svärd som healar dig om du har köpt det
            {
                Players[0].Damage = Players[0].MaxHealth / 5;
                Players[0].Damage = (Players[0].Strength / 10 * Players[0].Damage) + Players[0].Damage;
                damage = Ran.Next(Players[0].Damage / 2, Players[0].Damage);
                Monsters[0].Health -= damage;
                Players[0].Health += damage / 2;
                if (Players[0].Health >= Players[0].MaxHealth)
                {
                    Players[0].Health = Players[0].MaxHealth;
                }
                RedDamageText2(Players[0].Name, " Attacks ", Monsters[0].Name, " for ", damage.ToString(), " damage. Health Left: ", Monsters[0].Health.ToString(), "/", Monsters[0].MaxHealth.ToString());
                GreenHealText("Your sword heals you for ", (damage / 2).ToString(), " Health, ", Players[0].Health.ToString(), "/", Players[0].MaxHealth.ToString());
            }
            else
            {
                Players[0].Damage = Players[0].MaxHealth / 5;
                Players[0].Damage = (Players[0].Strength / 10 * Players[0].Damage) + Players[0].Damage;
                damage = Ran.Next(Players[0].Damage / 2, Players[0].Damage);
                Monsters[0].Health -= damage;
                if (Monsters[0].Health < 0)
                {
                    Monsters[0].Health = 0;
                }
                RedDamageText2(Players[0].Name, " Attacks ", Monsters[0].Name, " for ", damage.ToString(), " damage. Health Left: ", Monsters[0].Health.ToString(), "/", Monsters[0].MaxHealth.ToString());
            }
        }

        public void ShopChoice() // Shopping meny
        {
            Console.Clear();
            TextGrapics("Welcome to the shop");
            Console.WriteLine("         1. Buy items");
            Console.WriteLine("         2. Sell items");
            Console.WriteLine("         3. Exit");
            Console.Write("Enter your choice: ");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choice = 0;
                Console.Clear();
            }

            switch (Choice)
            {
                case 1:
                    BuyStuff();
                    break;

                case 2:
                    SellStuff();
                    break;

                default:
                    Choice = 3;
                    break;
            }
        }

        public void HealChoice() //Healing meny där du kan heala dig
        {
            TextGrapics("Old Priests Church");
            Console.WriteLine("1. Pay " + Players[0].Level * 4 + " Gold to heal 30-60%");
            Console.WriteLine("2. Exit");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choice = 0;
                Console.Clear();
            }
            if (Choice == 1 && Players[0].Gold >= Players[0].Level * 4)
            {
                SpendGold(Players[0].Level * 4);
                HealUp();
            }
            else
            {
                Console.WriteLine("You don't have enough gold. Go kill some monsters.");
            }
        }

        public void GameLevels() // Lite game levels som inte gör något specielt
        {
            if (Players[0].Level >= 9)
            {
                TextGrapics("Game Level: Dead Kings Dungeon");
            }
            else if (Players[0].Level >= 6)
            {
                TextGrapics("Game Level: Abandoned Castle");
            }
            else if (Players[0].Level >= 3)
            {
                TextGrapics("Game Level: Empty Gold Mine");
            }
            else
            {
                TextGrapics("Game Level: Abandoned Town");
            }
        }

        public void ShowPlayerInfo() // skriver ut lite info om spelaren på huvudmenyn
        {
            for (int i = 0; i < Players.Count; i++)
            {
                Console.WriteLine("      Name: " + Players[i].Name + "     Health: " + Players[i].Health + "/" + Players[i].MaxHealth + "     Gold: " + Players[i].Gold + "     Exp: " + Players[i].Exp + "/" + Players[i].MaxExpThisLevel + "     Level: " + Players[i].Level);
            }
        }

        public void ShowPlayerInfo2() // Skriver ut player info på val 2
        {
            Console.WriteLine("* Name: " + Players[0].Name);
            Console.WriteLine("* Level: " + Players[0].Level);
            Console.WriteLine("* Hp: " + Players[0].Health + "/" + Players[0].MaxHealth);
            Console.WriteLine("* Exp: " + Players[0].Exp + "/" + Players[0].MaxExpThisLevel);
            Console.WriteLine("* Gold: " + Players[0].Gold);
            Console.WriteLine("* Strength: " + Players[0].Strength);
            Console.WriteLine("* Toughness: " + Players[0].Toughness);

            PressSomething();
        }

        public void CreateEliteMonster(string MonsterName) // Skapar ett elite monster
        {
            SpecificMonster NewMonster = new SpecificMonster();
            Random Ran = new Random();
            NewMonster.Name = MonsterName;
            NewMonster.Health = Players[0].MaxHealth / 2;
            NewMonster.MaxHealth = NewMonster.Health;
            NewMonster.Gold = Ran.Next(Players[0].Level + 100, Players[0].Level + 200);
            NewMonster.Exp = Ran.Next(Players[0].Level + 6, Players[0].Level + 10);
            NewMonster.EliteMonster = true;
            Monsters.Add(NewMonster);
        }

        public void CreateMonster(string MonsterName) // Skapar ett vanligt monster
        {
            SpecificMonster NewMonster = new SpecificMonster();
            Random Ran = new Random();
            NewMonster.Name = MonsterName;
            NewMonster.Health = Players[0].MaxHealth / 3;
            NewMonster.MaxHealth = NewMonster.Health;
            NewMonster.Gold = Ran.Next(Players[0].Level + 25, Players[0].Level + 50);
            NewMonster.Exp = Ran.Next(Players[0].Level + 3, Players[0].Level + 7);
            NewMonster.Monster = true;
            Monsters.Add(NewMonster);
        }

        public void CreateLastBoss(string MonsterName) // Skapar en boss som man möter level 9
        {
            SpecificMonster NewMonster = new SpecificMonster();
            Random Ran = new Random();
            NewMonster.Name = MonsterName;
            NewMonster.Health = Players[0].MaxHealth * 2;
            NewMonster.MaxHealth = NewMonster.Health;
            NewMonster.LastBoss = true;
            NewMonster.Gold = Ran.Next(1000);
            NewMonster.Exp = Ran.Next(1000);
            Monsters.Add(NewMonster);
        }

        public void GraphicMeny() // Huvudmeny
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("*|                        1.    Go Adventuring                       |*");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("*|                        2.    Show details about your character    |*");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("*|                        3.    Go to Shop                           |*");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("*|                        4.    Heal                                 |*");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("*|                        5.    Exit                                 |*");
            Console.WriteLine("*|                                                                   |*");
            Console.WriteLine("***********************************************************************");
            ShowPlayerInfo();
        }

        public string SpawnMonsterOrEliteOrBoss() // Bestämer vilket monster som ska skapas.
        {
            string MorphedName = "";
            Random Ran = new Random();
            int RandomNumber = Ran.Next(1, 100);
            int RandomName = Ran.Next(1, 6);

            if (RandomNumber >= 70 && Players[0].Level >= 4 && Players[0].Level < 9)
            {
                MorphedName += "Elite ";
                MorphedName = RandomeNames(RandomName, MorphedName);
                CreateEliteMonster(MorphedName);
                Monsters[0].EliteMonster = true;
            }
            else if (Players[0].Level == 9)
            {
                MorphedName += "Boss ";
                MorphedName = RandomeNames(RandomName, MorphedName);
                CreateLastBoss(MorphedName);
            }
            else
            {
                MorphedName = RandomeNames(RandomName, MorphedName);
                CreateMonster(MorphedName);
            }

            return MorphedName;
        }

        private static string RandomeNames(int RandomName, string MorphedName) //Ger monster random namn
        {
            switch (RandomName)
            {
                case 1:
                    MorphedName += "Snake";
                    break;

                case 2:
                    MorphedName += "Skeleton";
                    break;

                case 3:
                    MorphedName += "Knight";
                    break;

                case 4:
                    MorphedName += "Soldier";
                    break;

                case 5:
                    MorphedName += "Bear";
                    break;

                case 6:
                    MorphedName += "Tiger";
                    break;

                default:
                    break;
            }

            return MorphedName;
        }

        public void Fight() // Fight helt enkelt. Dör man så resetas spelet. Blir man level 10 så vinner man.
        {
            Dead = false;
            Choice = 0;
            Console.Clear();
            Random ran = new Random();
            SpawnMonsterOrEliteOrBoss();
            GameLevels();
            Console.WriteLine(Monsters[0].Name + " Has appeared " + "with healthamount: " + Monsters[0].Health);
            while (Monsters[0].Health > 0 && Players[0].Health > 0)
            {
                if (Monsters[0].Health > 0)
                {
                    MonsterAttack();

                    if (Monsters[0].Health > 0)
                    {
                        PlayerAttack();
                    }
                    PressSomething();
                }
            }
            if (Monsters[0].Health <= 0 && Players[0].Health > 0)
            {
                GreenBGWithBlueText(Monsters[0].Name + " Has died. You won the battle");
            }
            if (Players[0].Health > 0)
            {
                Players[0].Gold += Monsters[0].Gold;
                Players[0].Exp += Monsters[0].Exp;
                ExpAndGoldText("You gained ", Monsters[0].Gold.ToString(), " gold and ", Monsters[0].Exp.ToString(), " Exp");
            }

            if (Dead = false)
            {
                LevelUp();
            }

            if (Players[0].Level == 10)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("CONGRATULATION YOU WON THE GAME");
                PressSomething();
                Players.Remove(Players[0]);
                Shops.Remove(Shops[0]);
                PlayAgainOrExit();

                Console.ResetColor();
            }

            if (Players[0].Health <= 0)
            {
                Players.Remove(Players[0]);
                Shops.Remove(Shops[0]);
                Dead = true;
                Console.Clear();
                Console.WriteLine("You died and lost the game.");
                PlayAgainOrExit();
            }
            PressSomething();
            Monsters.Remove(Monsters[0]);
        }

        private void PlayAgainOrExit()
        {
            Console.WriteLine("Do you want to play again or exit?");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1. Play again");
            Console.WriteLine("2. Exit");
            Choice = TryCatch(Choice);
            if (Choice == 1)
            {
                CreateShop();
                CreatePlayer();
            }
            else
            {
                Exit = true;
            }
        }

        public void LevelUp() // Höjer spelarens level om man har tillräckligt med exp.
        {
            if (Players[0].Exp >= Players[0].MaxExpThisLevel)
            {
                Players[0].Exp %= Players[0].MaxExpThisLevel;
                Players[0].MaxExpThisLevel += 5;
                Players[0].Level++;
                Players[0].MaxHealth += 25;
                Players[0].Health = Players[0].MaxHealth;
                WhiteBGWithBlackText("You leveled up and are now level " + Players[0].Level);
            }
        }

        private void WhiteBGWithBlackText(string Text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Text);
            Console.ResetColor();
        }

        private void GreenBGWithBlueText(string Text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Text);
            Console.ResetColor();
        }

        public void TextGrapics(string text)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*                     " + text);
            Console.WriteLine("***********************************************************");
        }

        public void BuyStuff() //Köp meny
        {
            TextGrapics("What do you want to buy?");
            if (Shops[0].AmuletOfStrength.Equals(true) && Shops[0].AmuletOfStrengthAmount >= 1)
            {
                Console.WriteLine("    1. Amulet Of Strength.  " + Shops[0].AmuletOfStrengthAmount + " Left.  Price: 100");
            }
            if (Shops[0].AmuletOfToughness.Equals(true) && Shops[0].AmuletOfToughnessAmount >= 1)
            {
                Console.WriteLine("    2. Amulet Of Toughness. " + Shops[0].AmuletOfToughnessAmount + " Left.  Price: 100");
            }

            if (Shops[0].HealingSword.Equals(true))
            {
                Console.WriteLine("    3. Healing Sword.                Price: 100");
            }
            Console.WriteLine("    4. Exit");
            Console.WriteLine("             Shop Gold: " + Shops[0].Gold);
            Console.Write("Enter item number you wanna buy: ");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choice = 0;
                Console.Clear();
            }
            if (Choice == 1 && Shops[0].AmuletOfStrength.Equals(true) && Players[0].Gold >= 100)
            {
                Shops[0].AmuletOfStrengthAmount -= 1;

                if (Shops[0].AmuletOfStrengthAmount <= 0)
                {
                    Shops[0].AmuletOfStrength = false;
                }

                Players[0].AmuletOfStrength = true;
                Players[0].AmuletOfStrengthAmount += 1;
                Players[0].Strength += 5;
                Players[0].Gold -= 100;
                Shops[0].Gold += 100;
                Console.WriteLine("You bought an Amulet Of Strength. You now do 10% more damage for each amulet you have.");
                PressSomething();
            }
            else if (Choice == 1 && Players[0].Gold < 100)
            {
                Console.WriteLine("You don't have enough gold. Go kill some monsters");
                PressSomething();
            }
            if (Choice == 2 && Shops[0].AmuletOfToughness.Equals(true) && Players[0].Gold >= 100)
            {
                Shops[0].AmuletOfToughnessAmount -= 1;

                if (Shops[0].AmuletOfToughnessAmount <= 0)
                {
                    Shops[0].AmuletOfToughness = false;
                }

                Players[0].AmuletOfToughness = true;
                Players[0].AmuletOfToughnessAmount += 1;
                Players[0].Toughness += 2;
                Players[0].Gold -= 100;
                Shops[0].Gold += 100;
                Console.WriteLine("You bought an Amulet Of Toughness. You now take 10% less damage for each amulet you have.");
                PressSomething();
            }
            else if (Choice == 2 && Players[0].Gold < 100)
            {
                Console.WriteLine("You don't have enough gold. Go kill some monsters");
                PressSomething();
            }

            if (Choice == 3 && Shops[0].HealingSword.Equals(true) && Players[0].Gold >= 100)
            {
                Shops[0].HealingSword = false;
                Players[0].HealingSword = true;
                Players[0].Gold -= 100;
                Shops[0].Gold += 100;
                Console.WriteLine("You bought the Healing Sword. You now heal 50% of the damage you do.");
                PressSomething();
            }
            else if (Choice == 3 && Players[0].Gold < 100)
            {
                Console.WriteLine("You don't have enough gold. Go kill some monsters");
                PressSomething();
            }
        }

        public void SellStuff() // Sälj meny, här finns det två amulet typer och ett svärd som healar spelaren när man gör skada.
        {
            TextGrapics("What do you want to Sell?");
            if (Players[0].AmuletOfStrength.Equals(true) && Players[0].AmuletOfStrengthAmount >= 1)
            {
                Console.WriteLine("    1. Amulet Of Strength.  " + Players[0].AmuletOfStrengthAmount + " Left.  Price: 100");
            }
            if (Players[0].AmuletOfToughness.Equals(true) && Players[0].AmuletOfToughnessAmount >= 1)
            {
                Console.WriteLine("    2. Amulet Of Toughness. " + Players[0].AmuletOfToughnessAmount + " Left.  Price: 100");
            }
            if (Players[0].HealingSword.Equals(true))
            {
                Console.WriteLine("    3. Healing Sword.                Price: 100");
            }
            Console.WriteLine("    4. Exit");
            Console.WriteLine("             Shop Gold: " + Shops[0].Gold);
            Console.Write("Enter item number you wanna Sell: ");

            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choice = 0;
                Console.Clear();
            }
            if (Choice == 1 && Players[0].AmuletOfStrength.Equals(true) && Shops[0].Gold >= 100 && Players[0].AmuletOfStrengthAmount >= 1)
            {
                Players[0].AmuletOfStrengthAmount -= 1;

                if (Players[0].AmuletOfStrengthAmount <= 0)
                {
                    Players[0].AmuletOfStrength = false;
                }

                Players[0].Strength -= 5;
                Shops[0].AmuletOfStrength = true;
                Shops[0].AmuletOfStrengthAmount += 1;
                Shops[0].Gold -= 100;
                Players[0].Gold += 100;
                Console.WriteLine("You sold an item");
                PressSomething();
            }
            else if (Choice == 1 && Players[0].AmuletOfStrength.Equals(false))
            {
                Console.WriteLine("You don't have that item");
                PressSomething();
            }
            if (Choice == 2 && Players[0].AmuletOfToughness.Equals(true) && Shops[0].Gold >= 100 && Players[0].AmuletOfToughnessAmount >= 1)
            {
                Players[0].AmuletOfToughnessAmount -= 1;

                if (Players[0].AmuletOfToughnessAmount <= 0)
                {
                    Players[0].AmuletOfToughness = false;
                }

                Players[0].Toughness -= 2;
                Shops[0].AmuletOfToughness = true;
                Shops[0].AmuletOfToughnessAmount += 1;
                Shops[0].Gold -= 100;
                Players[0].Gold += 100;
                Console.WriteLine("You sold an item");
                PressSomething();
            }
            else if (Choice == 2 && Players[0].Toughness.Equals(false))
            {
                Console.WriteLine("You don't have that item");
                PressSomething();
            }

            if (Choice == 3 && Players[0].HealingSword.Equals(true) && Shops[0].Gold >= 100)
            {
                Players[0].HealingSword = false;
                Shops[0].HealingSword = true;
                Shops[0].Gold -= 100;
                Players[0].Gold += 100;
                Console.WriteLine("You sold an item");
                PressSomething();
            }
            else if (Choice == 3 && Players[0].HealingSword.Equals(false))
            {
                Console.WriteLine("You don't have that item");
                PressSomething();
            }
        }

        public void PressSomething() // Pause i consolen
        {
            Console.WriteLine("[Enter to continue.]");
            Console.ReadKey();
        }

        public void MonsterAttack() // Attacken som alla monster använder
        {
            int damage = 0;
            Random Ran = new Random();

            if (Monsters[0].Monster.Equals(true))
            {
                Monsters[0].Damage = ((Players[0].MaxHealth / 6) + (Players[0].Level * 5) - ((Players[0].MaxHealth / 6) + (Players[0].Level * 5)) * (Players[0].Toughness / 10));
            }
            else if (Monsters[0].EliteMonster.Equals(true))
            {
                Monsters[0].Damage = ((Players[0].MaxHealth / 5) + (Players[0].Level * 6) - ((Players[0].MaxHealth / 5) + (Players[0].Level * 6)) * (Players[0].Toughness / 10));
            }
            else if (Monsters[0].LastBoss.Equals(true))
            {
                Monsters[0].Damage = ((Players[0].MaxHealth / 3) - (Players[0].MaxHealth / 3) * (Players[0].Toughness / 10));
            }
            damage = Ran.Next(Monsters[0].Damage / 3, Monsters[0].Damage);
            Players[0].Health -= damage;

            if (Players[0].Health < 0)
            {
                Players[0].Health = 0;
            }

            RedDamageText(Monsters[0].Name, " Attacks ", Players[0].Name, " for ", damage.ToString(), " damage. Health Left: ", Players[0].Health.ToString(), "/", Players[0].MaxHealth.ToString());
        }

        public int SpendGold(int GoldAmount)
        {
            if (Players[0].Gold >= GoldAmount)
            {
                Players[0].Gold -= GoldAmount;
            }
            else
            {
                Console.WriteLine("You don't have enough gold. Go kill some monsters.");
            }

            return GoldAmount;
        }

        public void HealUp() // Heala dig genom meny val 4
        {
            int HealingAmount = 0;
            Random Ran = new Random();
            HealingAmount = Ran.Next(Convert.ToInt32(Players[0].MaxHealth * 0.3), Convert.ToInt32(Players[0].MaxHealth * 0.6));
            Players[0].Health += HealingAmount;
            if (Players[0].Health >= Players[0].MaxHealth)
            {
                Players[0].Health = Players[0].MaxHealth;
            }
            GreenBGWithBlueText("You healed for: " + HealingAmount.ToString() + " health and now have " + Players[0].Health + " health");
            PressSomething();
        }

        public void RedDamageText(string PlayerName1, string Text2, string MonsterName3, string Text4, string CText5, string Text6, string CText7, string Text8, string CText9)
        {
            if (Monsters[0].Monster.Equals(true))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (Monsters[0].EliteMonster.Equals(true))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (Monsters[0].LastBoss.Equals(true))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public void RedDamageText2(string PlayerName1, string Text2, string MonsterName3, string Text4, string CText5, string Text6, string CText7, string Text8, string CText9)
        {
            if (Monsters[0].Monster.Equals(true))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (Monsters[0].EliteMonster.Equals(true))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (Monsters[0].LastBoss.Equals(true))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(PlayerName1);
                Console.ResetColor();
                Console.Write(Text2);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(MonsterName3);
                Console.ResetColor();
                Console.Write(Text4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CText5);
                Console.ResetColor();
                Console.Write(Text6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText7);
                Console.ResetColor();
                Console.Write(Text8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CText9);
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public void GreenHealText(string Text, string CText, string Text2, string CText7, string Text8, string CText9)
        {
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(CText);
            Console.ResetColor();
            Console.Write(Text2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(CText7);
            Console.ResetColor();
            Console.Write(Text8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(CText9);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void ExpAndGoldText(string Text, string CText, string Text2, string CText2, string Text3)
        {
            Console.WriteLine();
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CText);
            Console.ResetColor();
            Console.Write(Text2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(CText2);
            Console.ResetColor();
            Console.Write(Text3);
            Console.WriteLine("");
        }

        public void StartGame() // Startar spelet.
        {
            TheGame Start = new TheGame();
            int MenuChoice = 0;

            CreateShop();
            CreatePlayer();
            while (Exit == false)
            {
                Console.Clear();
                GraphicMeny();
                Console.Write("Enter Choice: ");
                MenuChoice = TryCatch(MenuChoice);
                switch (MenuChoice)
                {
                    case 1:
                        GoAdventureChoice();

                        break;

                    case 2:
                        ShowPlayerInfo2();
                        break;

                    case 3:
                        ShopChoice();
                        break;

                    case 4:
                        HealChoice();
                        break;

                    case 5:
                        Exit = true;
                        break;

                    default:
                        MenuChoice = 0;
                        break;
                }
            }
        }

        private static int TryCatch(int Choose)
        {
            try
            {
                Choose = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choose = 0;
                Console.Clear();
            }

            return Choose;
        }
    }
}