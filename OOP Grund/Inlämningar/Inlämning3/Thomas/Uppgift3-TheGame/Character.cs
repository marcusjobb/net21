// -----------------------------------------------------------------------------------------------
//  Character.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using POCO;
    using System;
    using static Helpers.PrintHelpers;

    internal class Character
    {
        protected CombatMessages msg = new();
        internal string Name { get; set; } = "";
        internal virtual string Alias { get; set; } = "";
        public int MaxHealth { get; set; } = 100;
        public int CurrentHealth { get; set; } = 100;
        public int Offense { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Damage { get; set; } = 25;
        public int Toughness { get; set; } = 10;
        internal int Gold { get; set; } = 0;
        internal bool Alive { get; set; } = true;


        protected static Random rng = new();

        internal virtual bool TakeDamage(int damage,bool playerActing)
        {
            (string msg, int blocked) result = DoRoll(false, Defense, Toughness);

            damage = damage - result.blocked < 0 ? 0 : damage - result.blocked;
            CurrentHealth -= damage;

            if (playerActing) Console.ForegroundColor = ConsoleColor.Green;
            else Console.ForegroundColor = ConsoleColor.Red;
            DramaticPrint($"{Alias} {result.msg} {result.blocked} damage");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Alias} {(playerActing?"take": "takes")} {damage} points of damage ({CurrentHealth}/{MaxHealth})");
            SetColors();
            Console.WriteLine();

            if (CurrentHealth <= 0)
            {
                Alive = false;
                Die();
            }

            return Alive;
        }
        private (string, int) DoRoll(bool attacking, int skillToCheck, int associatedValue)
        {
            var flavourText = attacking ? msg.Hits : msg.Blocks;
            (string message, int value) result;

            var roll = rng.Next(1, 21);

            if (roll <= skillToCheck)
            {
                if (roll == 1) result.value = associatedValue * 2;
                else result.value = associatedValue;
                result.message = result.value == associatedValue ? flavourText[0] : flavourText[1];
            }
            else
            {
                if (roll == 20) result.value = 0;
                else result.value = associatedValue / 2;
                result.message = result.value == 0 ? flavourText[3] : flavourText[2];
            }
            return result;
        }

        internal virtual int Attack(bool playerActing)
        {
            (var flavourText, var damage) = DoRoll(true, Offense, Damage);
            if (playerActing) Console.ForegroundColor = ConsoleColor.Green;
            else Console.ForegroundColor = ConsoleColor.Red;
            DramaticPrint($"{Alias} {flavourText} {damage} points of damage");
            SetColors();
            return damage;
        }
        internal virtual void Die() => BorderPrint($"{Name} falls over, dead.");


    }
}