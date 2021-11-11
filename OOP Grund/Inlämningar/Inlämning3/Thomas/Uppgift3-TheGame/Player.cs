// -----------------------------------------------------------------------------------------------
//  Player.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using Newtonsoft.Json;
    using POCO;
    using System;
    using static Helpers.PrintHelpers;
    using static POCO.Equipment;


    internal class Player : Character
    {
        public int Level { get; set; } = 0;
        internal int Xp { get; private set; } = 0;

        internal double XpToNextLevel { get; private set; } = 1;
        internal Weapon EquippedWeapon { get; private set; } = Fists;
        internal Armor EquippedArmor { get; private set; } = BirthdaySuit;
        internal bool Dead { get; private set; } = false;
        internal delegate void Scene();
        internal Scene DeathScene;

        internal Player()
        {
            Alias = "You";
            LevelUp(++Level);
            CurrentHealth = MaxHealth;
            msg.Hits = EquippedWeapon.FlavourTexts;
            msg.Blocks = EquippedArmor.FlavourTexts;
            DeathScene = new Scene(PlayerDeath);
        }

        private void LevelUp(int newLevel)
        {
            XpToNextLevel = Math.Ceiling(XpToNextLevel * 1.5);
            Xp = 0;
            Offense= Offense==17?Offense=17:++Offense;
            Defense = Defense==17?Defense = 17:++Defense;
            MaxHealth += 50;
            Damage = 10 + (newLevel * 5) + EquippedWeapon.Damage;
            Toughness = 10 + (newLevel * 4) + EquippedArmor.Protection;
            if (Level > 1)
            {
                string[] lvlUp =
                {
                    "DING!",
                    $"{"You leveled up!",-23} {"New Level:", -15}{Level, 4}",
                    $"{"Xp to next level:", -18}{XpToNextLevel, 5} {"New maxhealth:", -15}{MaxHealth, 4}",
                    $"{"Offense:", -18}{Offense,5} {"Defense:", -15}{Defense, 4}",
                    $"{"Damage:", -18}{Damage, 5} {"Toughness:", -15}{Toughness, 4}"
                };
                BorderPrint(lvlUp);
            }
        }
        internal void Loot((int gold, int xp) loot)
        {
            Gold += loot.gold;
            Xp += loot.xp;
            if (Xp >= XpToNextLevel) LevelUp(++Level);
            else
            {
                System.Console.WriteLine($"\nYou gain {loot.xp} XP and {loot.gold} gold. Current health: {CurrentHealth} / {MaxHealth} HP.");
                ThinBorderPrint($"You are level {Level}, have {Xp} XP out of {XpToNextLevel} needed for next level and {Gold} gold.");
            }

        }
        internal void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
            Damage = 10 + (Level * 5) + weapon.Damage;
            msg.Hits = weapon.FlavourTexts;
        }
        internal void EquipArmor(Armor armor)
        {
            EquippedArmor = armor;
            Toughness = 10 + (Level * 4) + armor.Protection;
            msg.Blocks = armor.FlavourTexts;
        }
        internal int Purse() => Gold;
        internal void Pay(int price) => Gold -= price;
        internal void ShowStats()
        {
            string[] stats =
            {
                $"Name:".PadRight(8)+$"{Name,25}",
                $"Level:".PadRight(8)+$"{Level,25}",
                "XP:".PadRight(8)+$"{Xp} / {XpToNextLevel}".PadLeft(25),
                "Health:".PadRight(8)+$"{CurrentHealth} / {MaxHealth}".PadLeft(25),
                $"Gold:".PadRight(8)+$"{Gold,25}",
                $"Weapon:".PadRight(8)+$"{EquippedWeapon.Name,25}",
                $"Armor:".PadRight(8)+$"{EquippedArmor.Name,25}"
            };
            BorderPrint(stats);
        }
        internal override void Die()
        {
            DeathScene();
            Dead = true;
        }

        public Player Clone()
        {
            var clone = JsonConvert.SerializeObject(this);
            Console.WriteLine(clone);
            Player copy = JsonConvert.DeserializeObject<Player>(clone);

            return copy;
        }
        
        private void PlayerDeath()
        {
            //ascii art from:https://ascii.co.uk/
            Console.WriteLine(@"                            ,--.
                           {    }
                           K,   }
                          /  ~Y`
                     ,   /   /
                    {_'-K.__/
                      `/-.__L._
                      /  ' /`\_}
                     /  ' /
             ____   /  ' /
      ,-'~~~~    ~~/  ' /_
    ,'             ``~~~  ',
   (                        Y
  {                         I
 {      -                    `,
 |       ',                   )
 |        |   ,..__      __. Y
 |    .,_./  Y ' / ^Y   J   )|
 \           |' /   |   |   ||
  \          L_/    . _ (_,.'(
   \,   ,      ^^""' / |      )
     \_  \          /,L]     /
       '-_~-,       ` `   ./`
          `'{_            )
              ^^\..___,.--`");
            BorderPrint($"You fall to the ground, dead.");
        }
    }
}