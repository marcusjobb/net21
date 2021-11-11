using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.DisplayMethods.Display;
using static TheGame.GameAssets.MonsterStrings;
using static TheGame.GameAssets.ArtAssets;

namespace TheGame.Characters
{
    /// <summary>
    /// This class is meant to be a Spooky Scary Skeleton monster. It's meant to be a slightly tougher foe.
    /// </summary>
    public class SpookyScarySkeleton : BaseMonster
    {
        public override string Name { get; set; } = "Spooky Scary Skeleton";
        public override int HP { get; set; }
        public override int HPMax { get; set; } = 10;
        public override int Experience { get; set; }
        public override string Art { get; set; }

        public SpookyScarySkeleton()
        {
            this.HP = this.HPMax;
            this.Gold = Game.RandomGenerator.Next(10, 201);
            this.Art = monsterSpookyScarySkeletonArt;
        }
        internal override void MonsterGreeting()
        {
            CenterWriteLine(MonsterGreetingSpookySkeleton());
        }

        internal override void DisplayMonsterArt()
        {
            Console.WriteLine(this.Art);
        }

        internal override void AttackMessage(int attackValue)
        {
            CenterWriteLineColour($"{this.Name} makes a swift attack for {attackValue} points of damage. ", ConsoleColor.DarkRed);
            CenterWriteLine(MonsterGreetingSpookySkeleton());
        }

        internal override void UpdateMonsterStats(Player player)
        {
            // TOOD: better scaling.
            var hpInterval = Game.RandomGenerator.Next(this.HPMax + (player.Level * 2), this.HPMax + (player.Level * 8));
            this.HPMax = hpInterval;
            this.HP = HPMax;

            this.minDamage = Game.RandomGenerator.Next(1, player.Level + 5);
            this.maxDamage = Game.RandomGenerator.Next(player.Level + 6, player.Level + 13);
            this.Experience += player.Level * 50;
            if (this.IsDead)
            {
                this.Gold = Game.RandomGenerator.Next(10, 150);
                this.IsDead = false;
            }

        }

    }


}
