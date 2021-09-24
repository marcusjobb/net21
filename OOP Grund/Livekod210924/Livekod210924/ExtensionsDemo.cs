using Livekod210924.Extensions;
using System;

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