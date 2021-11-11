using System;

namespace TheGame_JosefinPersson
{
    class Boss : Monster                                                                                                                                                           
    {
        public Boss(int exp, int hp, int strength, int defense, int gold, string attackPhrase, string deathPhrase)
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
