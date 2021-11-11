using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.GameStructure.ShopItems;


namespace TheGame.GameStructure
{
    /// <summary>
    /// Class for all the possible items the merchant can sell. Each item has a StatType to make it easier to increase the right player attribute,
    /// and a value which decides how much the attribute should be increased by.
    /// </summary>
    public class ShopItem
    {
        public virtual string Name { get; set; }
        public virtual string StatType { get; set; }
        public virtual int StatValue { get; set; }
        public virtual int GoldCost { get; set; }


        internal virtual int GetValue()
        {
            return Game.RandomGenerator.Next(1, 10);
        }

        internal virtual int GetCost()
        {
            return Game.RandomGenerator.Next(101, 400);
        }
    }
}
