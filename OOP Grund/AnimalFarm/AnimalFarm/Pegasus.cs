// -----------------------------------------------------------------------------------------------
//  Pegasus.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
