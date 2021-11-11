using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    
    class PlayerClass
    {

        public static Player player = new Player();

        public static void PlayerStart()
        {
            string name = HelperClass.WriteAndInput("Skriv in ditt namn: ");
            player.Name = name;
            player.Level = 1;
            PlayerStats();
        }
        public static void PlayerStats()
        {
            player.HP = 80 + (20 * player.Level);
            player.Strength = 3 + (2 * player.Level);
            player.Exp = 0;
            player.LevelUp = 170 + (30 * player.Level);
        }

        public static void LevelUpCheck()
        {
            if (player.Exp >= player.LevelUp)
            {
                player.Level++;
                PlayerStats();
                HelperClass.Write($"Level {player.Level}!");
            }
        }

        public static void ShowPlayerStats()
        {
            Console.Clear();
            Console.WriteLine("+-------------------+");
            Console.WriteLine($"| Name:     {player.Name} ");
            Console.WriteLine($"| Level:    {player.Level}");
            Console.WriteLine($"| HP:       {player.HP}   ");
            Console.WriteLine($"| Strength: {player.Strength} ");
            Console.WriteLine($"| Exp:      {player.Exp}/{player.LevelUp} ");
            Console.WriteLine("+-------------------+");
        }

    }
}
