using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Utils.UserInput
{
    public static class Validation
    {        
        public static bool ValidatedNameString(string name)
        {
            if (name.Length == 0)
                return false;
            else if (name.Contains("@$={[]}£$€\""))
                return false;
            else
                return true;
        }
    }
}
