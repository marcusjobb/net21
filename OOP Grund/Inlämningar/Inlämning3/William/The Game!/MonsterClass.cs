using System;
using System.Collections.Generic;

namespace The_Game
{
    class MonsterClass
    {

        public static Monster monster = new();


        public static void GenerateWeakMonster()
        {
            monster.Name = "Goblin";
            monster.HP = 20;
            monster.Strength = 4 + (1 * monster.Level);
            monster.ExpDrop = 80 + (20 * monster.Level);
        }

        public static void GenerateNormalMonster()
        {
            monster.Name = "Uruk-hai";
            monster.HP = 20;
            monster.Strength = 4 + (1 * monster.Level);
            monster.ExpDrop = 80 + (20 * monster.Level);
        }
        
        public static void GenerateStrongMonster()
        {
            monster.Name = "Troll";
            monster.HP = 20;
            monster.Strength = 4 + (1 * monster.Level);
            monster.ExpDrop = 80 + (20 * monster.Level);
        }


    }
}
