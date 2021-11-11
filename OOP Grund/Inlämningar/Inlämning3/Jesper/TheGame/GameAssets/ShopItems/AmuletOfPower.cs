using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.GameStructure.ShopItems;

namespace TheGame.GameStructure
{
    /// <summary>
    /// An Amulet item which inherits from ShopItem. Amulets are weaker than rings, yet more expensive.
    /// </summary>
    public class AmuletOfPower : ShopItem
    {
        public override string Name { get; set; } = "";
        public override string StatType { get; set; } = "Strength";
        public override int StatValue { get; set; }
        public override int GoldCost { get; set; }


        public AmuletOfPower()
        {
            this.Name = GetName();
            this.StatValue = GetValue();
            this.GoldCost = GetCost();
        }

        internal string GetName()
        {
            return ItemNames.RandomNeckwearName();
        }

        internal override int GetValue()
        {
            return Game.RandomGenerator.Next(1, 7);
        }

        internal override int GetCost()
        {
            if (this.StatValue < 3)
                return Game.RandomGenerator.Next(100, 250);
            else if (this.StatValue >= 3 && this.StatValue <= 5)
                return Game.RandomGenerator.Next(250, 500);
            else
                return Game.RandomGenerator.Next(700, 900);
        }
    }

    
}
