using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assignment1.Helpers
{
    public class DisplayHelper
    {
        internal static void SetColours()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

        internal static void AnimatedText(string text, int sleepTime)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(sleepTime);
            }

        }

        // Adds a bottom border to the parameter text. Checks the lenght of the string and adds border element for each string character.
        internal static void ClearAndPresent(string text)
        {
            var border = "";
            for (int i = 0; i < text.Length; i++)
            {
                border += "─";
            }
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine(border);
            Console.WriteLine();
        }

        // Prints a box around the parameter text.
        internal static void PrintBox(string text)
        {
            var line = "";
            var textBorder = text.Length;
            for (int i = 0; i < text.Length; i++)
            {
                line += "─";
            }
            Console.WriteLine($"┌{line}┐");
            Console.WriteLine($"│{text}│");
            Console.WriteLine($"└{line}┘");

        }
    }
}
