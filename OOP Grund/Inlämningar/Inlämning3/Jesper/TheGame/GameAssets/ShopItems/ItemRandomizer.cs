using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameStructure.ShopItems
{
    public class ItemRandomizer
    {
        /// <summary>
        /// A ShopItem is created by having a method which returns a randomized item from the chosen ShopItem child classes.
        /// </summary>
        internal ShopItem RandomItem = RandomizeItem();

        internal static ShopItem RandomizeItem()
        {
            var randomNumber = Game.RandomGenerator.Next(1, 101);
            if (randomNumber == 1)
                return new TheOneRing();
            else if (randomNumber > 1 && randomNumber <= 25)
                return new AmuletOfPower();
            else if (randomNumber > 1 && randomNumber <= 50)
                return new AmuletOfToughness();
            else if (randomNumber > 1 && randomNumber <= 75)
                return new RingOfPower();
            else
                return new RingOfToughness();
        }
    }
}
