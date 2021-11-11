using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameStructure.ShopItems
{
    public class RingOfPower : ShopItem
    {
        public override string Name { get; set; } = "";
        public override string StatType { get; set; } = "Strength";
        public override int StatValue { get; set; }
        public override int GoldCost { get; set; }


        public RingOfPower()
        {
            this.Name = GetName();
            this.StatValue = GetValue();
            this.GoldCost = GetCost();
        }

        internal string GetName()
        {
            return ItemNames.RandomRingName();
        }

        internal override int GetValue()
        {
            return Game.RandomGenerator.Next(1, 4);
        }

        internal override int GetCost()
        {
            return Game.RandomGenerator.Next(100, 300);
        }
    }
}
