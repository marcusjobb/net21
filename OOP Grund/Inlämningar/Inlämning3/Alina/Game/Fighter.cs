using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Fighter
    {

        public string Alias { get; }
        public int Attack { get; set; } = 50;

        public int Strength
        {
            get
            {
                int strength = 0;
                foreach (var item in Items)
                {
                    strength += item.Strength;
                }

                return strength;
            }
        }

        public int Defense
        {
            get
            {
                int defense = 0;
                foreach (var item in Items)
                {
                    defense += item.Toughness;
                }

                return defense;
            }
        }

        public int GoldPieces { get; set; } = 100;
        public int XP { get; set; } = 0;

        private List<int> LevelXP = new()
        {
            0,
            2,
            4,
            6,
            8,
            10,
            12,
            14,
            16,
            18,
            20
        };

        public int Level
        {
            get
            {
                for (int i = 0; i < LevelXP.Count; ++i)
                {
                    if (XP < LevelXP[i])
                        return i;
                }

                return LevelXP.Count;
            }
        }

        public int MaxHP { get; } = 50;
        public int HP { get; set; } = 50;
        public bool IsAlive { get => HP > 0; }

        public List<Item> Items = new();


        public Fighter(string alias)
        {
            Alias = alias;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Alias: " + Alias);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("GoldPieces: " + GoldPieces);
            Console.WriteLine("XP: " + XP);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Tougness: " + Defense);

            if (Items.Any())
            {
                Console.WriteLine("Items:");
                foreach (var item in Items)
                {
                    Console.WriteLine($"Name: {item.Name}");
                }
            } else
            {
                Console.WriteLine("Items: You don't have any items");
            }
        }
    }
}
























