// -----------------------------------------------------------------------------------------------
//  LoopBack.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    internal class LoopBack
    {
        internal void Start()
        {
            //          123456 = array length
            //          012345 = array position
            var name = "Magika";
            for (int n = name.Length - 1; n >= 0; n--)
            {
                Console.Write(name[n]);
            }

            // En for-sats är egentligen tre kommandon i ett, precis som en While
            // En räknare, ett villkor och inkrementering av räknaren
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