using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3
{
    class Program
    {
        public static Player player1 = new Player(); // New instance of Player.
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            TextAndStory.GameName();

            TextAndStory.IntroText();

            Battles.FirstBattle();

            while (mainLoop && player1.mods < 10)
            {
                Shop.LoadShop(player1);
                Battles.RandomBattle();
            }

            TextAndStory.VictoryScreen();
        }
    }
}
