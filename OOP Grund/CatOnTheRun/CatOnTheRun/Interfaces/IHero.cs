// -----------------------------------------------------------------------------------------------
//  IHero.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Interfaces
{
    internal interface IHero: IWarrior
    {
        int Level { get; set; }
        int DefaultXP { get; set; }
        int DefaultHP { get; set; }
        int DefaultAttack { get; set; }
        int DefaultDefense { get; set; }
        int DefaultCoins { get; set; }
        void LevelUp();
        void UseItem(IPotion potion);
        void UseItem(IShield shield);
        void UseItem(IWeapon weapon);
        IStory GetChapter(int chapter);
    }
}
