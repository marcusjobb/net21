using System;
using System.Collections.Generic;

namespace TheGame
{
    public class Entity //entities. Not sure if done efficiently but it works
    {

        public string Name { get; set; }

        public int LVL { get; set; } = 1;

        public int MaxHP { get; set; } = 50;

        private int hp = 50;

        public int HP
        {
            get => hp;
            set
            {
                if (value > MaxHP) value = MaxHP;
                else if (value < 0) value = 0;
                hp = value;
            }
        }

        public int ATK { get; set; } = Check.DiceRoll();
        public int DEF { get; set; } = Check.DiceRoll();
    }

    public class Player : Entity
    {
        public int EXP { get; set; } = 0;
        public int Gold { get; set; } = 100;
        static public Player stats = new Player();
        static public List<string> Items = new List<string> { "Herb", "Herb", "Herb", "Herb" };


    }

    public class Slime : Entity
    {
        public static int StatRange()
        {
            Random rnd = new Random();
            int stat = rnd.Next(-4, 4);
            return stat;
        }
        static public Slime stats = new Slime();
    }

    public class KingSlime : Entity
    {
        static public Slime stats = new Slime();
    }
}
