using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livekod210924.Extensions
{
    static class IEnummerableExtension
    {
        public static void PrintArray(this IEnumerable<string> vs)
        {
            foreach (var row in vs)
            {
                Console.WriteLine(row);
            }
        }
    }
}
