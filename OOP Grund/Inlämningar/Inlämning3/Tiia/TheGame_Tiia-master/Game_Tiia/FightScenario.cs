using System;
using System.Threading;

namespace Game_Tiia
{
    internal class FightScenario
    {
        //----------------------första scenario------------------------------------------------------
        public static void BasicFight(Player player, Monster monster, int damageGiven, int damageGiven2, int damageTaken, int damageTaken2)
        {
            var damageToPlayer = (damageTaken - player.Toughness);
            var moreDamageToPlayer = (damageTaken2 - player.Toughness);
            var damageToMonster = (damageGiven + player.Strenght);
            var moreDamageToMonster = (damageGiven2 + player.Strenght);

            while (monster.Hp >= 0)
            {
                Check.PressEnter();

                Visual.MagentaText($"\tAAAH! The monster rages towards you and hits you the shoulder! You lose {damageToPlayer} hp");
                player.Hp -= damageToPlayer;
                Check.PressEnter();

                Visual.CyanText($"\n\tYou swing your sword and cut {monster.Name} in the stomach! That can't have felt good... \n\tThe monster loses {damageToMonster} hp");
                monster.Hp -= damageToMonster;
                Check.PressEnter();

                Visual.MagentaText($"\tNevermind.. You might have underestimated the situation and get a sharp punch to the head! You lose {moreDamageToPlayer} hp");
                player.Hp -= moreDamageToPlayer;
                Check.PressEnter();

                Visual.CyanText($"\tYou survive the hit, make a skillfull maneuver round the monster and get in a good stab to the back. \n\tThe monster lets out a nasty screeck and loses {moreDamageToMonster} hp ");
                monster.Hp -= moreDamageToMonster;
                Check.PressEnter();

                Console.Clear();

                Visual.MagentaText("\tWhile the monster is down on the ground, you jump over it to finish the fight");
                Check.PressEnter();
                Visual.MagentaText("\tBut it turns around at the exact same moment and kicks you hard so that you fly high up to the air!");
                Check.PressEnter();
                Visual.MagentaText($"\tThe power of the kick makes you to drop your sword..");
                Check.PressEnter();
                Visual.CyanText($"\t..Which, for your luck, happens to land blade down straight into {monster.Name}s foot!");
                Check.PressEnter();
                Visual.CyanText($"\tYou lose {damageToPlayer} hp and the monster {damageToMonster} hp");
                player.Hp -= damageToPlayer;
                monster.Hp -= damageToMonster;

                
                Check.ShowHp(player, monster);

                if (monster.Hp <= 0)
                {
                    monster.Hp = 0;
                    Check.MonsterKilled(monster);
                    player.Exp += monster.ExpGiven;
                    Monster.DropGold(player, monster);
                    Check.ShowStats(player);
                    break;
                }
                else if (player.Hp <= 0)
                {
                    player.Hp = 0;
                    Check.GameOver(player);
                }

            }
            return;
        }

        //-------------------------andra scenario----------------------------------------------------------
        public static void LongerFight(Player player, Monster monster, int damageGiven, int damageGiven2, int damageTaken, int damageTaken2)
        {
            var damageToPlayer = (damageTaken - player.Toughness);
            var damageToMonster = (damageGiven + player.Strenght);
            var moreDamageToMonster = (damageGiven2 + player.Strenght);
            var moreDamageToPlayer = (damageTaken2 - player.Toughness);

            while (monster.Hp >= 0)
            {
                Console.WriteLine("Here we go again..");
                
                Check.PressEnter();
                Visual.MagentaText($"\tYou draw your sword and run towards {monster.Name}.. but you miss!");
                Check.PressEnter();

                Visual.CyanText($"\tThis seems to give the monster even more energy and before you realise it,");
                Visual.CyanText("\tyou get punched right in to the chest!");
                Check.PressEnter();

                Visual.MagentaText($"\tThe punch catches you complitely off guard and thrusts you to the ground,");
                Visual.MagentaText($"\tYou lose {damageToPlayer} hp");
                player.Hp -= damageToPlayer;
                Check.PressEnter();

                Visual.CyanText($"\tBefore you have time to get up {monster.Name} lifts you up to the air,");
                Check.PressEnter();
                Visual.CyanText("\tspins you around and tosses you like a ragdoll towards a huge rock..");
                Visual.MagentaText($"You lose {moreDamageToPlayer} hp!");
                player.Hp -= moreDamageToPlayer;

                Check.PressEnter();
                Visual.MagentaText("\tThings are not looking that good for you, buddy..");
                Check.PressEnter();

                Visual.CyanText("\tYou suddenly get a slight chance to escape if you start to run now!!");
                Visual.CyanText("\tDo you want to use the opportunity? y/n");

                var userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    RunAway(player, monster);
                    Visual.WanderingAround();
                    return;
                }
                else if (userInput == "n")
                {
                    ContinueFight(monster, player, damageToPlayer, damageToMonster, moreDamageToMonster);
                    Check.PressEnter();
                }

                Check.ShowHp(player, monster);
                
                if (monster.Hp <= 0)
                {
                    monster.Hp = 0;
                    Check.MonsterKilled(monster);
                    player.Exp += monster.ExpGiven;
                    Monster.DropGold(player, monster);
                    Check.ShowStats(player);
                    break;
                }
                else if (player.Hp <= 0)
                {
                    player.Hp = 0;
                    Check.GameOver(player);
                }
            }
            return;
        }

        private static void ContinueFight(Monster monster, Player player, int damageToPlayer, int damageToMonster, int moreDamageToMonster) //efter scenario 2 om spelaren väljer att fortsätta
        {
            Visual.MagentaText($"\tThere's no escaping now! Even though your whole body is on fire,");
            Visual.MagentaText($"\tYou take few surprisingly quick steps and swing your sword towards {monster.Name} and succeed in hitting it!");
            Check.PressEnter();

            Visual.MagentaText($"\t{monster.Name} loses {damageToMonster} hp!");
            monster.Hp -= damageToMonster;
            Check.PressEnter();

            Visual.CyanText($"\tNow you got some new energy hit the monster to the leg! It howls of pain and loses {moreDamageToMonster} hp!");
            monster.Hp -= moreDamageToMonster;
            Check.PressEnter();

            Visual.MagentaText("\tThe monster rages towards you but loses it's balance! Still somehow it manages to hit you!");
            Visual.MagentaText($"\tYou lose {damageToPlayer} hp");
            player.Hp -= damageToPlayer;

            Visual.CyanText("\tBefore the monster gets up, you get your chance to give a powerful hit!");
            Visual.CyanText($"\tThe monster loses {moreDamageToMonster*2} hp!");
            monster.Hp -= moreDamageToMonster;
             
        }

        private static void RunAway(Player player, Monster monster) //efter scenario 2 om spelaren väljer att fly
        {
            Visual.MagentaText("\tYou start to run away like your life depends on it...  ");
            Check.PressEnter();

            Visual.CyanText($"\tAfter a looong and exhausting escape you finally seem to have lost {monster.Name} chasing you");
            Check.PressEnter();

            Visual.MagentaText("\tOh damn! While you were sprinting like crazy you seem to have dropped your bag of gold :(");

            Visual.MagentaText("\tTotally 10 gold peaces has been lost!");
            var goldDropped = 10;
            player.Gold -= goldDropped;
            Check.PressEnter();

            Visual.CyanText("\tBut it's too risky to go back now.. So you decide to continue the adventure.");
            Check.PressEnter();
        }
     
    }   
}