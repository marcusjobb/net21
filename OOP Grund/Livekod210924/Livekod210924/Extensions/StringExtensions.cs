// -----------------------------------------------------------------------------------------------
//  StringExtensions.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Livekod210924.Extensions
{
    // Krav för extensions
    // 1 - Statisk klass
    // 2 - Statisk metod
    // 3 - Första parametern har nyckelordet this

    static class StringExtensions
    {
        /// <summary>
        /// Omvandlar tal från sträng till integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns>0 om fel, annars nummerisk värde</returns>
        public static int ToInt(this string input)
        {
            int number;
            int.TryParse(input, out number);
            return number;
        }
        /// <summary>
        /// Omvandlar tal från sträng till double
        /// </summary>
        /// <param name="input"></param>
        /// <returns>0 om fel, annars nummerisk värde</returns>
        public static double ToDouble(this string input)
        {
            double number;
            double.TryParse(input, out number);
            return number;
        }

    }
}
