using System.Collections.Generic;

//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;

namespace TheGame001
{
    //   internal interface IConsumable : IItem
    //      {
    ///       int HpBonus { get; set; }
    //        int DamageReductionBonus { get; set; }
    //        int Damagebonus { get; set; }
    //       int ToHitBonus { get; set; }
    //       int Expires
    //  }

    public interface IShopper
    {
        public string Name { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Item> WantsToBuy { get; set; }
        public List<Item> WantsToSell { get; set; }
        public int Gold { get; set; }

        public int[] Position { get; set; }
    }




}





