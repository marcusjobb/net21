using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Helpers;

namespace TheGame.DisplayMethods
{
    public class Display
    {
        /// <summary>
        /// Writes a centered line, by dividing the console width in two, dividing the text in two, and then sets the
        /// cursor position at the console center minus one half of whatever is to be centered. Then prints.
        /// </summary>
        /// <param name="text"></param>
        #region WriteCentered
        public static void CenterWriteLine(string text)
        {
            //*If the text exceeds the console windowwidth -n (for good measure), writes it normally, otherwise centers text. Might have fixed the crashing.
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - textInHalf;
                Console.WriteLine(text);
            }
        }

        // Out of range error on rows, even with a small string?
        public static void MiddleWriteLine(string text)
        {

            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var consoleMiddle = Console.WindowHeight / 2;

            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - (text.Length / 2);
                //Console.CursorTop = consoleMiddle - textInMiddle; -- responsible for crashing probably?
                Console.CursorTop = consoleMiddle;
                Console.WriteLine(text);
            }
        }

        public static void AnimateTextMiddle(string text)
        {
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var consoleMiddle = Console.WindowHeight / 2;

            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - (text.Length / 2);
                //Console.CursorTop = consoleMiddle - textInMiddle; -- responsible for crashing probably?
                Console.CursorTop = consoleMiddle;
                Console.WriteLine(text);
            }
        }
        public static void CenterWrite(string text)
        {
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            Console.CursorLeft = consoleCenter - textInHalf;
            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - textInHalf;
                Console.WriteLine(text);
            }
        }
        //-------------------------- -----------------------------------------------------------
        #endregion
        #region MiddleConsole
        /// <summary>
        /// Writes in the middle of the console. Centers the items in a list in the middle of the console. 
        /// </summary>
        /// <param name="menuRow"></param>
        public static void MiddleWriteLines(List<string> menuRow)
        {
            // This method needs a list or some other collection of strings to be order to get the relative positions of all the strings.
            // It didn't work well with single strings using normal "Console.WriteLine but in the middle of the screen", since the separate strings had no information about each other.
            var longestItem = StringHelpers.GetLongestListItem(menuRow);
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var consoleMiddle = Console.WindowHeight / 2;
            var textInMiddle = menuRow.Count / 2;
            for (int i = 0; i < menuRow.Count; i++)
            {
                if (menuRow[i].Length >= maxStringLength - 2)
                    Console.WriteLine(menuRow[i]);
                else
                {
                    // Divides the longest list item by 2, and subtracts it from the console center position. This way the menu will be 
                    // centered around the centerpoint of the longest item (hopefully).
                    Console.CursorLeft = consoleCenter - (longestItem.Length / 2);
                    Console.CursorTop = consoleMiddle + i - textInMiddle;
                    Console.WriteLine(menuRow[i]);
                }
            }

        }
        #endregion
        //--------------------------------------------------------------------------------------

        #region Colour
        /// <summary>
        /// Extension to make it easier to change the text colour. Sets the console colour to the chosen parameter values.
        /// If no value is chosen for the background colour, it defaults to black (since the default is black).
        /// Bug: If the user resizes the console window, the background colour will overflow the entire line.
        /// WriteLine.
        /// </summary>
        /// <param name="text">Text to colour</param>
        /// <param name="foregroundColour"></param>
        /// <param name="backgroundColour"></param>
        public static void WriteLineColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Extension to make it easier to change the text colour. Sets the console colour to the chosen parameter values.
        /// If no value is chosen for the background colour, it defaults to black (since the default is black).
        /// Write.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColour"></param>
        /// <param name="backgroundColour"></param>
        public static void CenterWriteColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - textInHalf;
                Console.WriteLine(text);
            }
            Console.ResetColor();
        }

        public static void CenterWriteLineColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            if (text.Length >= maxStringLength - 2)
                Console.WriteLine(text);
            else
            {
                Console.CursorLeft = consoleCenter - textInHalf;
                Console.WriteLine(text);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Extension to make it easier to change the text colour. Sets the console colour to the chosen parameter values.
        /// If no value is chosen for the background colour, it defaults to black (since the default is black).
        /// Write.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColour"></param>
        /// <param name="backgroundColour"></param>
        public static void WriteColour(string text, ConsoleColor foregroundColour, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            Console.Write(text);
            Console.ResetColor();
        }
        ///-------------------------------------------------------------------------------------------
        #endregion


        /// <summary>
        /// Animates the chosen string one letter at a time. The writing speed can be passed along as a parameter to speed certain things up, has default value of 50 ms.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="animationTime"></param>
        public static void AnimateText(string text, int animationTime = 50)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(animationTime);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Animates the text in the center (column wise) of the screen.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="animationTime"></param>
        public static void AnimateTextCenter(string text, int animationTime = 50)
        {
            var maxStringLength = Console.WindowWidth;
            var consoleCenter = Console.WindowWidth / 2;
            var textInHalf = text.Length / 2;
            if (text.Length >= maxStringLength - 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    System.Threading.Thread.Sleep(animationTime);
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    // Each written letter gets written, then the next gets written with +1 column distance.
                    Console.CursorLeft = consoleCenter + i - textInHalf;
                    Console.Write(text[i]);
                    System.Threading.Thread.Sleep(animationTime);
                }
            }
            Console.WriteLine();
        }
        ///-------------------------------------------------------------------------------------------

        #region AddPadding
        /// <summary>
        /// Automatically adds spaces as padding and therefore "colouring" to the HP bar. There's probably a much more elegant way of doing this.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        internal static string GetPadding(Player player)
        {
            // Get the amount of letters in the name, add to the padding.
            var paddingCount = 0;
            for (int i = 0; i < player.Name.Length; i++)
            {
                paddingCount++;
            }
            // Convert the current hp and max hp numbers to strings.
            var hpString = player.HP.ToString();
            var hpmaxString = player.HPMax.ToString();
            // Store the amount of HP numbers in healthCharacters
            var healthCharacters = hpString.Length + hpmaxString.Length;

            // Subtracts the necessary characters from the padding amount.
            paddingCount -= 8; // To make room for "HP:" + spaces
            // Subtract the hp numbers from the padding amount.
            paddingCount -= healthCharacters;
            // Divide by two so it can be an even amount on the left and right side.
            paddingCount /= 2;
            // Add the correct amount of spaces
            var padding = " ";
            for (int i = 0; i < paddingCount; i++)
            {
                padding += " ";
            }
            return padding;
        }
        /// <summary>
        /// Automatically adds spaces and therefore "colouring" to the HP bar. There's probably a much more elegant way of doing this.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        internal static string GetPadding(BaseMonster monster)
        {
            var paddingCount = 0;
            for (int i = 0; i < monster.Name.Length; i++)
            {
                paddingCount++;
            }
            var hpString = monster.HP.ToString();
            var hpmaxString = monster.HPMax.ToString();
            var healthCharacters = hpString.Length + hpmaxString.Length;
            paddingCount -= 8;
            paddingCount -= healthCharacters;
            paddingCount /= 2;
            var padding = " ";
            for (int i = 0; i < paddingCount; i++)
            {
                padding += " ";
            }
            return padding;
        }
        ///-------------------------------------------------------------------------------------------
        #endregion
        /// <summary>
        /// Sets the cursor position through a metod instead, saves a whole line of code.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        internal static void CursorPosition(int row, int column)
        {
            Console.CursorTop = row;
            Console.CursorLeft = column;
        }
    }
}
