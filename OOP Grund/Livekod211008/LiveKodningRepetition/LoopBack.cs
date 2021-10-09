// -----------------------------------------------------------------------------------------------
//  LoopBack.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    internal class LoopBack
    {
        public LoopBack()
        {
        }

        internal void Start()
        {
            //          123456 = array length
            //          012345 = array position
            var name = "Magika";
            for (int n = name.Length - 1; n >= 0; n--)
            {
                Console.Write(name[n]);
            }

            for (
                int i = 0;
                i <= name.Length;
                i++
                )
            {
                Console.Write(name[i]);
            }
        }
    }
}