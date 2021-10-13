using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_ContactList.HelperMethods
{
    public class StringHelpers
    {
        /// <summary>
        /// Asks a question, returns the users answer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string QuestionAndAnswer(string input)
        {
            Console.WriteLine(input);
            var answer = Console.ReadLine();
            return answer;
        }
        /// <summary>
        /// Asks a question using Write instead of WriteLine, returns the users answer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string QuestionAndAnswerSameLine(string input)
        {
            Console.Write(input);
            var answer = Console.ReadLine();
            Console.WriteLine();
            return answer;
        }
    }
}
