using System;
using System.Collections.Generic;

namespace TheGame
{
    public class SpecificMonster : Monster //inheritance of Monster
    {
        public static void SpecialEncounter()
        {
            Combat(false, "", 0, 0);
            
        }
    }
}