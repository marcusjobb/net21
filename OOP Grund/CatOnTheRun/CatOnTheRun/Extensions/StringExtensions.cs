// -----------------------------------------------------------------------------------------------
//  StringExtensions.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class StringExtensions
    {
        internal static int Toint(this string input)
        {
            if (int.TryParse(input, out var result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
