// -----------------------------------------------------------------------------------------------
//  IHero.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Interfaces
{
    using CatOnTheRun.Enums;

    internal interface IWarrior
    {
        IWeapon Weapon { get; set; }
        IShield Shield { get; set; }
        string Name { get; set; }
        int XP { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Coins { get; set; }
        void Die();
        void DoAttack();
        void GetHit();
        IStory GetStory(StoryEvent story);
    }

}
