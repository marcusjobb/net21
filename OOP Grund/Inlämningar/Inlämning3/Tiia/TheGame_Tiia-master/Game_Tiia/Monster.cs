using System;

namespace Game_Tiia
{
    class Monster : IEntity
    {
        public string Name { get; set; } = "";
        public int Hp { get; set; } = 0;
        public int ExpGiven { get; set; } = 0;

        public static void DropGold(Player player, Monster monster) //monstret tappar guld ibland
        {
            Random rnd = new Random();
            var dropGold = rnd.Next(1, 11);

            Console.WriteLine($"Lucky you! The monster has dropped {dropGold} peaces of GOLD!");
            Player.GetGold(player, dropGold);
        }
    }
}


