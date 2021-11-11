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
    /// Class for the suspisciously named mouse-like monster. Overrides some properties and methods of the base monster class so it can be customized.
    /// </summary>
    public class SurprisedElectricRodent : BaseMonster
    {
        public override string Name { get; set; } = "Surprised Electric Mouse";
        public override int HP { get; set; }
        public override int HPMax { get; set; } = 10;
        public override int Experience { get; set; }
        public override string Art { get; set; }

        public SurprisedElectricRodent()
        {
            this.HP = this.HPMax;
            this.Gold = Game.RandomGenerator.Next(10, 201);
            this.Art = monsterSurprisedMouseArt;
        }

        internal override void MonsterGreeting()
        {
            CenterWriteLine(MonsterGreetingTotallyNotPikachu());
        }

        internal override void DisplayMonsterArt()
        {
            Console.WriteLine(this.Art);
        }

        internal override void AttackMessage(int attackValue)
        {
            CenterWriteLine(MonsterAttackElectricMouse());
            CenterWriteLineColour($"{this.Name} attacked you for {attackValue} points of damage.", ConsoleColor.DarkRed);
        }

        internal override void UpdateMonsterStats(Player player)
        {
            // TOOD: better scaling.
            var hpInterval = Game.RandomGenerator.Next(this.HPMax + (player.Level * 2), this.HPMax + (player.Level * 8));
            this.HPMax = hpInterval;
            this.HP = HPMax;

            this.minDamage = Game.RandomGenerator.Next(1, player.Level + 5);
            this.maxDamage = Game.RandomGenerator.Next(player.Level +6, player.Level + 11);
            this.Experience += player.Level * 75;
            if (this.IsDead)
            {
                this.Gold = Game.RandomGenerator.Next(50, 200);
                this.IsDead = false;
            }

        }

    }
}
