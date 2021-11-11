using System;
using System.Threading;

namespace Game_Tiia
{
    class AdventureTime
    {
        public static void WhileOnAdventure(Player player)
        {
            WelcomeToForest();

            while (true) //loop för äventyret
            {
                Visual.WanderingAround();
                int monsterOrNot = Randomizer();

                switch (monsterOrNot)
                {
                    case 1: NoMonsters(); break;
                    case 2: MeetShaman(player); break;
                    case 5: MeetTravelers(player); break;
                    case 7: RestTime(player); break;
                    default: MonsterEncounter(player); Check.CheckLevel(player); break;
                }

                string input = Check.DoYouWantToContinue(); //ger en möjlighet att avbryta äventyret

                if (input == "y") continue;
                else if (input == "n") break;
                else Message("Enter 'y' or 'n' "); Console.ReadLine(); Console.Clear();
            }
            Console.Clear();
        }

        private static void WelcomeToForest() //Början av äventyret
        {
            Message("You stand on the edge of the old, dark and spine-chilling forest. \nDreadful monsters are lurking in every corner waiting for the right moment to gobble up innocent travelers... \nDo you have the courage to enter?");
            Console.ReadLine();
            Console.Write("And so begins the adventure...");
        }

        private static int Randomizer() //genererar ett nummer mellan 1 och 10 som används för att utgöra vilket monster man träffar
        {
            Random rand = new Random();
            var monsterOrNot = rand.Next(1, 11);
            return monsterOrNot;
        }

        private static void NoMonsters() //case 1
        {
            Message("It's so quiet and peaceful... a little bit too quiet maybe, but no monsters on sight lyckily.. \nEnjoy while you can!");
        }

        private static void MonsterEncounter(Player player) //spelaren träffar olika monster beroende på nivån denna befinner sig i
        {
            int level = player.Level;

            if (level < 3)
            {
                Monster monster1 = new();
                monster1.Name = "Goblin";
                monster1.Hp = 50;
                monster1.ExpGiven = 60;
                Message($"You stumble across an old and crumpy-looking {monster1.Name}! He looks kind of hungry...  Good luck!\n ");
                Fight.AttackMonster(player, monster1);
            }
            else if (level <= 6)
            {
                Monster monster2 = new();
                monster2.Name = "Troll";
                monster2.Hp = 75;
                monster2.ExpGiven = 50;
                Message($"While strolling in the woods you suddenly hear steps behind you... \nYou turn around and see an extremely hideous {monster2.Name} charging straight towards you! ");
                Fight.AttackMonster(player, monster2);
            }
            else if (level <= 8)
            {
                Monster monster3 = new();
                monster3.Name = "Orc";
                monster3.Hp = 105;
                monster3.ExpGiven = 75;
                Message($"It starts to rain and you seek for a better cover. \nWhile running around you happen to cross paths with an orc on a hunt.. \n..Here we go again! ");
                Fight.AttackMonster(player, monster3);
            }
            else if (level < 10)
            {
                Monster bossMonster = new();
                bossMonster.Name = "Giant";
                bossMonster.Hp = 150;
                bossMonster.ExpGiven = 95;
                Message($"Out of nowhere you arrive to an open field in the middle of the forest. \nThere is no trees but one old crooked oak reaching towards the skies.");
                Check.PressEnter();
                Message($"You approach the oak and admire it's beauty... When suddenly you see movement in the corner of your eye! \nBefore you know it there is a huge {bossMonster.Name} staring right back at you!");
                Message("I don't think it wants to chat...");
                Fight.AttackMonster(player, bossMonster);
            }
        }

        private static void MeetTravelers(Player player) //case 5
        {
            Message("\nOh look! You meet another travelers that turns out to be extremely friendly! \nYou chat with them and regain some of your powers!");
            Thread.Sleep(500);
            Console.WriteLine("In exchange for some food, they give you a peace of GOLD!");
            player.Gold++;
            player.Hp += 10;

            Check.ShowStats(player);
        }

        private static void RestTime(Player player) //case 7
        {
            Message("You start to feel exhausted and decide stop and rest for a while. \nSomething caughts your attention.. ");
            Check.PressEnter();
            Message("Sounds like running water! You proceed to check where it's coming from and find a small stream of water.");
            Check.PressEnter();
            Message("You take a sip from the stream and gain 25 hp! ");
            player.Hp += 25;
        }

        public static void MeetShaman(Player player)
        {


            Console.WriteLine("Suddenly the forest gets much thicker and you start to get weird vibes...");
            Check.PressEnter();
            Console.Write("The ground starts to shake and you start to hear loud noises..");
            Console.WriteLine("just like drumbeats");
            Check.PressEnter();
            Console.WriteLine("You walk towards the sound and find a lonely Shaman dansing around the fire with his drum..");
            Console.WriteLine("What do you choose to do?");
            Menu.FightMenu();

            var userChoise = 0;
            int.TryParse(Console.ReadLine(), out userChoise);

            switch (userChoise)
            {
                case 1: RunAwayFromShaman(); break;
                case 2: ApproachShaman(); break;
                case 3: AttackShaman(player); break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }

        private static void RunAwayFromShaman()
        {
            Console.Clear();
            Console.WriteLine("You choose to run away and continue the adventure");
            Visual.WanderingAround();
        }

        private static void ApproachShaman()
        {
            Console.Clear();
            Visual.CyanText("As you start to approach the Shaman, he all of a sudden drops his drum, \nturns around and stares at you with his deep black eyes! ");
            Visual.CyanText("He signs you to come closer..");
            Visual.PointPoint();
            Check.PressEnter();
            Visual.MagentaText("You feel shivers go down your spine and think all the alternative ways to escape");
            Check.PressEnter();
            Visual.CyanText("As you come closer you can see that he is fairly irritated after you walked in and interrupted his.. \n..whatever he was doing.. some ritual I guess?");
            Check.PressEnter();
            Visual.CyanText("BUT.. he shows his gratitude towards you, that you didn't decide to attack him... and steal his gold ");
            Check.PressEnter();

            Visual.MagentaText("You wonder how the heck he knew that and feel bad for even thinking about that...");
            Check.PressEnter();
            Visual.MagentaText("You don't want to irritate him any more so you decide to give him 2 pieces of gold");
            Check.PressEnter();
            Visual.CyanText("He thanks you and offers to cast a toughness spell over you (+ 1 toughness)");
            Check.PressEnter();
            Visual.MagentaText("You accept the spell and get 1 toughness point! Then you go off to continue your adventure after this rather..\n..weird.. encounter");
            Visual.WanderingAround();
        }

        private static void AttackShaman(Player player)
        {
            Visual.CyanText("You're one daring adventurer... you choose to attack the Shaman");
            Check.PressEnter();
            Visual.CyanText("You grab your sword and get ready for the attack...");
            Visual.PointPoint();
            Console.WriteLine("###sjddl...---<<lkof??39r***#kawfe8ww/#)...");
            Visual.PointPoint();
            Console.Write("&#93b0#)R#%Äa>>g _what_ ÄW-r<w _is_ aA)(wf  _happening?_ wr93q");
            Visual.PointPoint();
            Console.Clear();
            Visual.MagentaText("... WHAT on earth was THAT?? You look around ");
            Visual.PointPoint();
            Visual.CyanText("Somehow you have gotten back to the beginning of the forest.. BUT HOW?");

            Visual.MagentaText("Then it hits you... maybe you shouldn't have tried to attack the Shaman...");
            Check.PressEnter();

            Visual.CyanText("Now you have lost all your exp.. oops :/ ");
            player.Exp = 0;
        }

       

        private static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
