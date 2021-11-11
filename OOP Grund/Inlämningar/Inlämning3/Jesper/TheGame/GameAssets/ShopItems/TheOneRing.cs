using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameStructure.ShopItems
{
    public class TheOneRing : ShopItem
    {
        public override string Name { get; set; } = "The One Ring";
        public override string StatType { get; set; } = "Strength and Toughness";
        public override int StatValue { get; set; } = 100;
        public override int GoldCost { get; set; } = 1000;
    }
}
