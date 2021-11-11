using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.DisplayMethods.Display;
namespace TheGame.Helpers
{

    public class StringHelpers
    {

        /// <summary>
        /// Writes out a string, and returns an answer via Console.ReadLine.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string QuestionAndAnswer(string input)
        {
            CenterWriteLine(input);
            var answer = Console.ReadLine();
            return answer;
        }
        public static string QuestionAndAnswerPosition(string input, int row, int column)
        {
            CenterWriteLine(input);
            CursorPosition(row, column);
            var answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// Returns the longest string from a list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetLongestListItem(List<string> list)
        {
            // Longest item stores the currently longest item. The loop iterates through each item and assigns them to this variable if it's longer than the previous item.
            var longestItem = "";
            foreach (var item in list)
            {
                if (item.Length > longestItem.Length)
                {
                    longestItem = item;
                }
            }
            return longestItem;
        }
    }
}
