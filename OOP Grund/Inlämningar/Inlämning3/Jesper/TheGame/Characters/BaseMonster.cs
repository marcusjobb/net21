using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.GameAssets;
using static TheGame.DisplayMethods.Display;
using static TheGame.GameAssets.MonsterStrings;
using static TheGame.GameAssets.ArtAssets;

namespace TheGame
{
    /// <summary>
    /// The BaseMonsters are supposed to be slightly weaker and less rewarding than the other monsters. Lets the player gain some experience for less health loss.
    /// </summary>
    public class BaseMonster
    {
        
        public virtual string Name { get; set; } = "";
        public virtual int HP { get; set; }
        public virtual int HPMax { get; set; } = 10;
        public virtual int Experience { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }
        public virtual int Gold { get; set; }
        public bool IsDead { get; set; } = false;
        public virtual string Art { get; set; } = "";

        public BaseMonster()
        {
            this.HP = this.HPMax;
            this.Gold = Game.RandomGenerator.Next(10, 201);
            this.Art = genericMonsters[Game.RandomGenerator.Next(0, genericMonsters.Length)]; // The BaseMonster class gets randomized monster art, because it's supposed to be generic.
        }
        
        internal int Attack()
        {
            int attackValue = Game.RandomGenerator.Next(this.minDamage, this.maxDamage);
            AttackMessage(attackValue);
            return attackValue;
        }

        // Monster hp reduced by incoming damage. If the hitpoints goes below zero, sets it to zero. To avoid having negative HP when dying.
        internal void TakeDamage(int incomingDamage)
        {
            this.HP -= incomingDamage;
            if (this.HP < 0)
            {
                this.HP = 0;
            }
            CheckIfFatal();

        }
        internal int GiveGold()
        {
            return this.Gold;
        }
        internal void CheckIfFatal()
        {
           if (this.HP <= 0)
            {
                CenterWriteLine($"{this.Name} {MonsterDiedText()}");
                this.IsDead = true;
            }
        }
        #region Virtual methods
        // Virtual methods which can be changed by subclass.
        internal virtual void MonsterGreeting()
        {
            CenterWriteLine(MonsterGreetingGeneric());
        }

        internal virtual void DisplayMonsterArt()
        {
            Console.WriteLine(this.Art);
        }

        internal virtual void AttackMessage(int attackValue)
        {
            
            CenterWriteLineColour($"{this.Name} makes a swift attack for {attackValue} points of damage.", ConsoleColor.DarkRed);
            CenterWriteLine(RandomHitMessageText());

        }

        /// <summary>
        /// Method to be able to scale relevant monster stats according to the player level. As the player increases in level, the monsters gets slightly tougher.
        /// Updates HP to MaxHp.
        /// If the monster is dead, reanimates it (How very fitting..) This way we can fight an infinite amount of monsters using the same constructed monsters from the monster array.
        /// Gold gets respawned into the monsters pocket as well.
        /// This method almost works as a constructor for the already newly constructed monsters, so maybe there's a better way of doing this.
        /// </summary>
        /// <param name="player"></param>
        internal virtual void UpdateMonsterStats(Player player)
        {
            // TOOD: better scaling.
            var hpInterval = Game.RandomGenerator.Next(this.HPMax + (player.Level * 2), this.HPMax + (player.Level * 4));
            this.HPMax = hpInterval;
            this.HP = HPMax;
            this.minDamage = Game.RandomGenerator.Next(1, player.Level + 5);
            this.maxDamage = Game.RandomGenerator.Next(player.Level + 6, player.Level + 10);
            this.Experience += player.Level * 25;
            if (this.IsDead)
            {
                this.Gold = Game.RandomGenerator.Next(10, 125);
                this.IsDead = false;
            }

        }
        #endregion
    }
}
