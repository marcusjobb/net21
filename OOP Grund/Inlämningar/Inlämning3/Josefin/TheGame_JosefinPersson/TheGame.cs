using System;
using System.Threading;    // Thread.Sleep();

namespace TheGame_JosefinPersson
{
    class TheGame
    {
        // deklarerar att det ska finnas 3 olika monster i the game
        public Boss boss { get; set; }                                                                                                                                                             
        public Monster mediumMonster { get; set; }
        public Monster miniMonster { get; set; }

        public void GoAdventuring(Player hero)
        {
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("....");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(".....");
            Thread.Sleep(500);
            Console.Clear();

            Random rnd = new Random();
            int chance = rnd.Next(1, 101);

            if (chance < 10) // hittar gräs
            {
                Console.WriteLine("There are no monsters here, only grass...");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else if (chance == 11)  // ökar HP
            {
                Console.WriteLine("You found the MEGA RARE Health Berry!");
                Console.WriteLine("Nam nam! You gained 100 HP...");
                hero.Hp += 100;
                Console.WriteLine("Your HP is now: " + hero.Hp);
            }
            else // möter monster
            {
                Console.WriteLine("RAAAAWR!");
                Console.WriteLine("Oh...!");
                Console.WriteLine("You found a MONSTER, now you have to defeat it to survive!");
                Thread.Sleep(3000);

                if (hero.Level >= 8)
                {
                    Console.WriteLine("BOSS TIME! A huge monster with fangs and bat wings stands before you... Goood luck!");
                    Thread.Sleep(3000);

                    boss = new Boss(100, 200, 13, 12, 500, "Mohaha! I will DESTROY you!!!", "Farewell cruel world...uuuughh...");

                    Fight(hero, boss);
                }
                else if (hero.Level >= 4)
                {
                    Console.WriteLine("A monster of terror stands before you, it's holding a weapon made of HUMAN BONES...!");
                    Thread.Sleep(3000);

                    mediumMonster = new Monster(80, 100, 10, 8, 300, "Rawr! Ready to meet your maker?", "UGH, ouch! It hurts to die...");

                    Fight(hero, mediumMonster);
                }
                else
                {
                    Console.WriteLine("...Hello, I'm down here...!");
                    Console.WriteLine("Naaw, a tiny baby mini monster has come to say hello! Or is it here to KILL you...?!");
                    Thread.Sleep(3000);

                    miniMonster = new Monster(60, 80, 6, 4, 200, "Wanna play with me?", "My mama will hunt you down... *cries*");

                    Fight(hero, miniMonster);
                }

                if (hero.Level == 10)
                {
                    Console.WriteLine("     ~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                    Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                    Console.WriteLine("                               CONGRATUALTIONS, YOU WIN THE GAME!!!");
                    Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                    Console.WriteLine("     ~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                    Thread.Sleep(3000);
                }
            }
        }

        public void Fight(Player hero, Monster monster)
        {
            while (monster.Hp > 0 && hero.Hp > 0) // om BÅDE hero och monster LEVER
            {

                if (hero.Hp > 0) // om hero lever, hero attaack
                {
                    Random rnd = new Random();
                    int fightRnd = rnd.Next(10, 21);

                    Console.WriteLine("Hero HP: " + hero.Hp + " Monster HP: " + monster.Hp);
                    Thread.Sleep(2000);
                    Console.WriteLine("Hero attacks...");
                    Console.WriteLine(hero.AttackPhrase);
                    Thread.Sleep(3000);
                    monster.Hp -= ((hero.Strength * fightRnd) - monster.Defense);   
                    if (monster.Hp < 0)
                    {
                        monster.Hp = 0;
                    }
                    Console.WriteLine("Monster HP goes down to " + monster.Hp);
                    Thread.Sleep(2000);

                    if (monster.Hp <= 0) // om monstret dör
                    {
                        Console.WriteLine(monster.DeathPhrase);
                        Thread.Sleep(3000);
                        Console.WriteLine("YOU SLAYED THE MONSTER! You gained " + monster.Gold + " Gold and " + monster.Exp + " Exp!");
                        hero.Exp += monster.Exp;
                        hero.Gold += monster.Gold;
                        Console.WriteLine("HP: " + hero.Hp + " Gold: " + hero.Gold + " Exp: " + hero.Exp + " /100");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        if (hero.Exp >= 100) // LEVEL UP
                        {
                            Console.Clear();
                            hero.Level++;
                            Console.WriteLine("Level up!");
                            hero.Exp = 0;
                            hero.Strength++;
                            hero.Defense++;
                            hero.Hp += 50;
                            Thread.Sleep(2000);
                            Console.WriteLine("Updated stats:");
                            hero.ShowStats();
                            Thread.Sleep(3000);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                    }
                }

                if (monster.Hp > 0) // om monstret lever, monster attack
                {
                    Random rnd = new Random();
                    int fightRnd = rnd.Next(10, 21);

                    Thread.Sleep(2000);
                    Console.WriteLine("Hero HP: " + hero.Hp + " Monster HP: " + monster.Hp);
                    Thread.Sleep(2000);
                    Console.WriteLine("Monster attacks...");
                    Console.WriteLine(monster.AttackPhrase);
                    Thread.Sleep(3000);
                    hero.Hp -= ((monster.Strength * fightRnd) - hero.Defense); 
                    if(hero.Hp < 0)
                    {
                        hero.Hp = 0;
                    }
                    Console.WriteLine("Hero HP goes down to " + hero.Hp);
                    Thread.Sleep(1000);

                    if (hero.Hp <= 0) // om hero dör
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine(hero.DeathPhrase);
                        Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                        Console.WriteLine("------------------------------------------------GAME OVER!-------------------------------------------------------------");
                        Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                    }
                }
            } 
        } 
    }
} 

