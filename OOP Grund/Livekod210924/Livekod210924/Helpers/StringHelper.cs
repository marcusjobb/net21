using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livekod210924.Helpers
{
    static class StringHelper
    {
        public static void PrintArray(IEnumerable<string> vs)
        {
            foreach (var row in vs)
            {
                Console.WriteLine(row);
            }
        }
    }
}
