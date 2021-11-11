using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFight._player
{
    enum level { first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth }
    class player
    {
        //fields and properties
        public string plyerName { get; set; }
        public string Email { get; set; }
        public level Level { get; set; }
        public int playerHealthPoint { get; set; }
        public int playerMaxAttack { get; set; }
        public int playerMaxBlock { get; set; }
        public int playerGold { get; set; }
        public int sTrength { get; set; }
        public int touGHness { get; set; }


        public void show_Details(player ply)
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($"           -----<<<((((             {(ply.plyerName).ToUpper()}               ))))>>>-----      ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($"           -----<<<((((       Le V eL:  << {ply.Level} >>          ))))>>>-----        ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("");
            Console.WriteLine($" ..........                  HealthPoint: { ply.playerHealthPoint}                ........... ");
            Console.WriteLine("");
            Console.WriteLine($" ...       MaxAttack : {playerMaxAttack}\t\t\t MaxBlock : {playerMaxBlock}         .... ");
            Console.WriteLine("");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($"   .. Gold: {ply.playerGold}\t   ...\tStrength: {ply.sTrength}\t   ... \ttouGHness: {ply.touGHness} .. ");
            Console.WriteLine("==========================================================================");

        }

        Random rnd = new Random();

        public int playerAttack()
        {
            return rnd.Next(1, playerMaxAttack);
        }

        public int playerBlock()
        {
            return rnd.Next(1, playerMaxBlock);
        }
    }
}
