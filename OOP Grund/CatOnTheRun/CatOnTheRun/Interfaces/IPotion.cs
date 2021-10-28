// -----------------------------------------------------------------------------------------------
//  IPotion.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Interfaces
{
    internal interface IPotion : IStatsable, ISellable
    {
        public int Value { get; set; }
    }
}
