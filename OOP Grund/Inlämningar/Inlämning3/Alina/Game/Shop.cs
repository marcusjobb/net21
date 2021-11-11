using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Shop
    {
        private readonly List<Item> Items = new()
        {
            new Item("Strength amulett", 20, 10, 0),
            new Item("Toughness amulett", 35, 0, 10),
            new Item("Strength 2 amulett", 100, 20, 0)
        };

        public List<Item> GetItems() {
            return Items;
        }

        public bool CanBuy(int itemIndex, int goldpieces)
        {
            return Items[itemIndex - 1].Price <= goldpieces;
        }

        public Item Buy(int itemIndex)
        {
            var item = Items[itemIndex - 1];
            Items.RemoveAt(itemIndex - 1);

            return item;
        }
    }
}
