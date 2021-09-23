namespace ClassReplacement
{
    using System;
    using System.IO;
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