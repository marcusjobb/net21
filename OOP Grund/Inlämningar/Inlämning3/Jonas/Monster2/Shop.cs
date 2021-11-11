using System.Collections.Generic;
//using System.Collections.Generic;

namespace TheGame001
{
    public class Shop : IShopper
        {
        public string Name { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Item> WantsToBuy { get; set; }  
        public List<Item> WantsToSell { get; set; }
        public int Gold { get; set; }
        public int[] Position { get; set; }
    }





}





