 using System ;
 using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;

namespace TheGame001
{
    public class Consumable : Item, IItem
    {
        public int HpBonus { get; set; }

        public int DamageReductionBonus { get; set; }
        public int Damagebonus { get; set; }
        public int ToHitBonus { get; set; }

        public int Duration { get; set; }
    }
}





