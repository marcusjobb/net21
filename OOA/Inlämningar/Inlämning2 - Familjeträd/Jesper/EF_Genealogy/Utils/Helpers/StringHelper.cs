using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Utils.Helpers
{
    public static class StringHelper
    {


        public static string CapitalizeAndTrim(string text)
        {
            if (text.Length != 0)
            {
                var capitalizedFirstLetter = text.Substring(0, 1).ToUpper();
                var restOfLetters = text.Substring(1);
                return capitalizedFirstLetter + restOfLetters.Trim();
            }
            else
            {
                return text;
            }
        }
    }
}
