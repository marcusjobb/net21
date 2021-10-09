// -----------------------------------------------------------------------------------------------
//  Pegasus.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace AnimalFarm
{

    class Pegasus : Horse, IHasWings
    {
        bool Neigh = true;
        public int Wings { get; set; }
        //public Centaur()
        //{
        //    Colour = "White";
        //}
    }
}
