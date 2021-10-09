// -----------------------------------------------------------------------------------------------
//  ExtensionsDemo.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

using Livekod210924.Extensions;

namespace Livekod210924
{
    internal class ExtensionsDemo
    {
        internal void Start()
        {

            string input = "14";
            int number = input.ToInt();
            double dNumber = input.ToDouble();

            Console.WriteLine(number);

        }
    }
}