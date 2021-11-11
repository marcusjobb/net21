using System;

namespace Game_Tiia
{
    public class Player : IEntity
    {
        public string Name { get; set; } = "";
        public int Hp { get; set; } = 200;
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0;
        public int Strenght { get; set; } = 5;
        public int Toughness { get; set; } = 0;
        public int Gold { get; set; } = 20;

        public static void GetGold(Player player, int amountGold)
        {
            player.Gold+=amountGold;
        }
    }
}


