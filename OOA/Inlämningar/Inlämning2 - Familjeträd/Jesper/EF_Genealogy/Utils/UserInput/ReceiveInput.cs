using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Genealogy.Utils.Helpers;

namespace EF_Genealogy.Utils.UserInput
{
    public static class ReceiveInput
    {
        public static int ReceiveInt()
        {
            int.TryParse(Console.ReadLine(), out int menuchoice);
            return menuchoice;
        }

        public static string ReceiveNameString()
        {
            var name = Console.ReadLine();
            var formattedName = StringHelper.CapitalizeAndTrim(name);
            return formattedName;
        }
    }
}
