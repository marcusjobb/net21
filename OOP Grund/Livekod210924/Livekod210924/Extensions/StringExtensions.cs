using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livekod210924.Extensions
{
    // Krav för extensions
    // 1 - Statisk klass
    // 2 - Statisk metod
    // 3 - Första parametern har nyckelordet this

    static class StringExtensions
    {
        public static int ToInt(this string input)
        {
            int number;
            int.TryParse(input, out number);
            return number;
        }
        public static double ToDouble(this string input)
        {
            double number;
            double.TryParse(input, out number);
            return number;
        }

    }
}
