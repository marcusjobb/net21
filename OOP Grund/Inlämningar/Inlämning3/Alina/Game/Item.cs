namespace Game
{
    class Item
    {
        public Item(string name, int price, int strength, int toughness)
        {
            Name = name;
            Price = price;
            Strength = strength;
            Toughness = toughness;
        }

        public string Name { get; }
        public int Price { get; }

        public int Strength { get;  }

        public int Toughness { get; }
    }
}
