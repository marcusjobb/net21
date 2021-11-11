using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game_
{
    public class Player
    {
        public Player(string name)
        {
            Level = 1;
            Exp = 0;
            Hp = 200;
            Strenght = 10;
            Name = name;
        }

        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Strenght { get; set; }

        public void Print()
        {
            Console.WriteLine("Name     :" + Name);
            Console.WriteLine("Exp      :" + Exp);
            Console.WriteLine("Level    :" + Level);
            Console.WriteLine("Hp       :" + Hp);
            Console.WriteLine("Strenght :" + Strenght);
        }
    }
}
