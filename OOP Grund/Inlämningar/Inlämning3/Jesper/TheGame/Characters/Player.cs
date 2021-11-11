using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.GameAssets.ArtAssets;
using static TheGame.DisplayMethods.Display;
using static TheGame.GameAssets.StoryStrings;
using static TheGame.Helpers.StringHelpers;

namespace TheGame
{
    internal class Player
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0;
        public int ExpMax { get; set; } = 100;

        public int HP { get; set; }
        public int HPMax { get; set; } = 100;
        public int Toughness { get; set; } = 1;
        public int Strength { get; set; } = 2;
        public bool IsDead { get; set; } = false;
        public int Gold { get; set; }

        // Constructor just updates the HP to the maxHP.
        public Player()
        {
            this.HP = HPMax;
        }

        /// <summary>
        /// The player attack value is randomized between the current Strenght value, and Strenght value times two +3..
        /// </summary>
        /// <returns></returns>
        internal int Attack()
        {
            var damage = Game.RandomGenerator.Next(Strength + 2, Strength * 2 + 3);
            AttackMessage();
            CenterWriteLineColour($"You attack for {damage} points of damage!", ConsoleColor.DarkGreen);
            return damage;
        }

        internal void AttackMessage()
        {
            CenterWriteLine(PlayerAttackText());
        }

        /// <summary>
        /// Incoming damage gets reduced by the players toughness before it reduces player health. If the player has less than 0 hp, sets it to 0 hp.
        /// </summary>
        /// <param name="incomingDamage"></param>
        internal void TakeDamage(int incomingDamage)
        {
            incomingDamage -= this.Toughness;
            if (incomingDamage < 0)
                incomingDamage = 0;
            this.HP -= incomingDamage;
            if (this.HP < 0)
                this.HP = 0;
            CenterWriteColour($"You took {incomingDamage} points of damage.", ConsoleColor.DarkRed);
            CheckIfFatal();
            
        }

        internal void CheckIfFatal()
        {
            if (this.HP <= 0)
            {
                CenterWriteLineColour("You died!", ConsoleColor.Red);
                this.IsDead = true;
            }
        }
        /// <summary>
        /// Method for the player level up. The level and maximum hitpoints gets increased. The new levelup threshold increases by 50 experience for each level.
        /// Player gets healed to full upon reaching a new level.
        /// </summary>
        internal void LevelUp()
        {
            this.Level += 1;
            this.HPMax += 5;
            this.HP = HPMax;
            this.ExpMax = this.Exp += 50;
            this.Exp = 0;
            WriteLineColour(levelUpArt, ConsoleColor.Yellow);
            CenterWriteLineColour($"Ding ding, you leveled up to level [{this.Level}]! You feel reinvigorated!", ConsoleColor.Yellow);
        }

        // TODO: Make it so the leftover experience carries over after a level up? 
        /// <summary>
        /// Gives the user experience, checks if it reaches the threshold for a levelup.
        /// </summary>
        /// <param name="exp"></param>
        internal void GetExp(int exp)
        {
            this.Exp += exp;
            CenterWriteLineColour($"You gained {exp} EXP. You now have {this.Exp} / {this.ExpMax} EXP.", ConsoleColor.Yellow);
            if (this.Exp >= this.ExpMax)
            {
                this.LevelUp();
            }
        }
        
        /// <summary>
        /// Gets gold and adds it to the player stats.
        /// </summary>
        /// <param name="gold"></param>
        internal void GetGold(int gold)
        {
            CenterWriteLineColour($"You looted {gold} gold from the monster.", ConsoleColor.DarkYellow);
            this.Gold += gold;
        }

        internal void GiveGold(int goldLost)
        {
            CenterWriteLine($"You parted with {goldLost} pieces of gold. ");
            this.Gold -= goldLost;
        }

        /// <summary>
        /// The player info is stored in a list to be able to be centered nicely using already existing methods. Might not be optimal.
        /// </summary>
        internal void DisplayStats()
        {
            List<string> attributeList = new();
            WriteLineColour(playerInfoScroll, ConsoleColor.Yellow);
            attributeList.Add($"{this.Name}");
            attributeList.Add("");
            attributeList.Add($"Level: [{this.Level}]");
            attributeList.Add($"Experience: [{this.Exp} / {this.ExpMax}]");
            attributeList.Add("");
            attributeList.Add($"Hitpoints: [{this.HP} / {this.HPMax}]");
            attributeList.Add("Attributes:");
            attributeList.Add($"Strength - [{this.Strength}]");
            attributeList.Add($"Toughness - [{this.Toughness}]");
            attributeList.Add("");
            attributeList.Add($"Gold: [{this.Gold}]");
            MiddleWriteLines(attributeList);
        }
    }

}