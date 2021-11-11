using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameStructure.ShopItems
{
    /// <summary>
    /// Returns a random name for the various item types. In hindsight, since there are no "item slots", the names don't have to be specific to amulets or rings, they could all just be items.
    /// </summary>
    public class ItemNames
    {
        public static string RandomNeckwearName()
        {
            string[] amuletNames = {
            "Amulet of Power",
            "Amulet of Doom",
            "Pendant of Skulls",
            "Collar of Cerberus",
            "Inconspicious Silver Necklace",
            "Scarf of comfyness",
            "An old piece of string",
            "A sturdy Herring, covered in shrubbery"
            };
            return amuletNames[Game.RandomGenerator.Next(0, amuletNames.Length)];
        }

        public static string RandomRingName()
        {
            string[] ringNames = {
            "Ring of Power",
            "Ring of Doom",
            "A ring with a large skull on it",
            "Ring of Wild Magic",
            "Silver Band",
            "A rubberband, it'd look nice on your finger",
            "Thingie for a fingie"
            };
            return ringNames[Game.RandomGenerator.Next(0, ringNames.Length)];
        }

    }
}
