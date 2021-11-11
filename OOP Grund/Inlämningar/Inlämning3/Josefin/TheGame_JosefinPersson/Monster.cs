using System;

namespace TheGame_JosefinPersson
{
    class Monster    
    {                                                                                                                                                                                                                                                                                                                                  
        public int Exp { get; set; }
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }
        public string AttackPhrase { get; set; }
        public string DeathPhrase { get; set; }

        public Monster()
        {
            //tom constructor
        }
        public Monster(int exp, int hp, int strength, int defense, int gold, string attackPhrase, string deathPhrase)
        {
            this.Exp = exp;
            this.Hp = hp;
            this.Strength = strength;
            this.Defense = defense;
            this.Gold = gold;
            this.AttackPhrase = attackPhrase;
            this.DeathPhrase = deathPhrase;
        }
    }
}

