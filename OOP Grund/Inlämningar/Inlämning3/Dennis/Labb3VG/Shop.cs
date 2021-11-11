using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3
{
    public class Shop
    {
        static int armorMod;
        static int weaponMod;
        static int difMod;

        public static void LoadShop(Player p)
        {
            armorMod = p.armor;
            weaponMod = p.weapon;
            difMod = p.mods;

            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;

            while (true)
            {
                potionP = 30 + 10 * p.mods;
                armorP = 100 * (p.armor+1);
                weaponP = 100 * (p.weapon);
                difP = 200 + 100 * p.mods;

                Console.Clear();
                Console.WriteLine($"Your coins: {p.coins}:-");
                Console.WriteLine("+========[ SHOP ]========+         +=====[ YOUR  STATS ]=====+");
                Console.WriteLine($" (P)otion [+1]      {potionP}:-              Current Health: {p.health}");
                Console.WriteLine($" (W)eapon [+1 att]  {weaponP}:-             Weapon Strenght: {p.weapon}");
                Console.WriteLine($" (A)rmor  [+1 def]  {armorP}:-             Armor Toughness: {p.armor}");
                Console.WriteLine($" (N)ext Dungeon     {difP}:-             Potions: {p.potion}");
                Console.WriteLine($"                                      Current dungeon: {p.mods}");
                Console.WriteLine($" (S)earch Next Fight...            +=========================+");
                Console.WriteLine($"+========================+         |      Your level: {p.level}      | ");
                Console.Write("                                   |");
                Player.ProgressBar("+", " ", ((decimal)p.xp / (decimal)p.GetLevelUp()),25);
                Console.WriteLine("|");
                Console.WriteLine("                                   +=========================+");

                string input = Console.ReadLine().ToLower();
                if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionP, p);
                }
                else if(input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorP, p);
                }
                else if (input == "n" || input == "next dungeon")
                {
                    TryBuy("dif", difP, p);
                }
                else if (input == "s" || input == "search next fight")
                {
                    break;
                }
            }
        }

        static void TryBuy(string item, int cost, Player p)
        {
            if (p.coins >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weapon++;
                else if (item == "armor")
                    p.armor++;
                else if (item == "dif")
                    p.mods++;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("you do not have enought gold.");
                Console.ReadKey();
            }
        }
    }
}
