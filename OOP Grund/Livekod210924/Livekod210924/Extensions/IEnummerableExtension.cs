// -----------------------------------------------------------------------------------------------
//  IEnummerableExtension.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Livekod210924.Extensions
{
    static class IEnummerableExtension
    {
        /// <summary>
        /// Skriver ut alla värden i en array eller lista
        /// </summary>
        /// <param name="vs">array eller lista</param>
        public static void PrintArray(this IEnumerable<string> vs)
        {
            foreach (var row in vs)
            {
                Console.WriteLine(row);
            }
        }
    }
}
