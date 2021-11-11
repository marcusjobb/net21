using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameStructure.ShopItems
{
    public class AmuletOfToughness : ShopItem
    {
        public override string Name { get; set; } = "";
        public override string StatType { get; set; } = "Toughness";
        public override int StatValue { get; set; }
        public override int GoldCost { get; set; }


        public AmuletOfToughness()
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
                return Game.RandomGenerator.Next(600, 900);
        }
    }
}
