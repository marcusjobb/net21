// -----------------------------------------------------------------------------------------------
//  IShield.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Interfaces
{

    using CatOnTheRun.Enums;

    internal interface IStatsable
    {
        int Stats_Used { get; set; }
    }

    internal interface IShield : IStatsable, ISellable
    {
        Shield Shield { get; set; }
        int Defense { get; set; }
    }

}
