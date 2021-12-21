// -----------------------------------------------------------------------------------------------
//  Output.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ClassReplacement
{
    using System;
    internal class Output
    {
        public virtual void Print(string text) // virtual = är tillåtet att överlagra
        {
            Console.WriteLine(text);
        }
        public void Box(string text)
        {
            string top = "+" + new string('-', text.Length) + "+";
            string msg = "|" + text + "|";

            Print(top);
            Print(msg);
            Print(top);
        }
    }
}