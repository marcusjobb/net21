using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game_
{
    public abstract class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Strenght { get; set; }
        public int Exp {get; set;}

        public void Print()
        {
            Console.WriteLine("A wild Monster appears its a angry " + Name);
        }
    }

    public class Werwolf : Monster
    {
        public Werwolf()
        {
            Name = "Werewolf";
            Hp = 150;
            Strenght = 7;
            Exp = 37;
        }
    }

    public class Zombie : Monster
    {
        public Zombie()
        {
            Name = "Zombie";
            Hp = 200;
            Strenght = 7;
            Exp = 60;
        }
    }

    public class Vampire : Monster
    {
        public Vampire()
        {
            Name = "Vampire";
            Hp = 150;
            Strenght = 9;
            Exp = 45;
        }
    }

        public class Gremlin : Monster
        {
            public Gremlin()
            {
                Name = "Gremlin";
                Hp = 60;
                Strenght = 8;
                Exp = 15;

            }
        }
}
