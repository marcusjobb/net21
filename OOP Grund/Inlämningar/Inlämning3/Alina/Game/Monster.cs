using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        public string Name { get; set; }
        public int Attack { get; set; } = 50;
        public int GoldPieces { get; set; } = 1;
        public int XP { get; set; } = 5;
        public int HP { get; set; } = 50;
        public bool IsAlive { get => HP > 0; }

        public Monster(string Name, int Attack, int GoldPieces, int XP, int HP)
        {
            this.Name = Name;
            this.Attack = Attack;
            this.GoldPieces = GoldPieces;
            this.XP = XP;
            this.HP = HP;
        }


        private static readonly List<string> Names = new()
        {
            "Per",
            "Bengt",
            "Lars-Åke",
            "Göran"
        };

        public static Monster CreateRandomMonster()
        {
            var random = new Random();

            return new Monster(
                Name: Names[random.Next(0, Names.Count)],
                Attack: random.Next(1, 50),
                GoldPieces: random.Next(1, 10),
                XP: random.Next(1, 5),
                HP: random.Next(1, 20)
            );
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Attack:" + Attack);
            Console.WriteLine("Goldpieces" + GoldPieces);
            Console.WriteLine("XP:" + XP);
            Console.WriteLine("HP" + HP);
            if (IsAlive)
            {
                Console.WriteLine("It is alive!");
            }
            else
            {
                Console.WriteLine("It is dead! ");
            }


        }





    }
}
