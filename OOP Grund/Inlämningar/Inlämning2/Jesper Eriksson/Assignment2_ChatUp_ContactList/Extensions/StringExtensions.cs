using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatUp_ContactList.HelperMethods;

namespace ChatUp_ContactList.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Makes the first letter in the attatched string capitalised, and trims trailing space.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CapitalisedNTrimmed(this string input)
        {
            input = input.Trim();
            // Uses the validation for IsEmpty to see whether the input is empty or not, to avoid errors.
            if (!Validate.IsEmpty(input))
            {
                var firstLetter = input.FirstLetter().ToUpper(); 
                var restOfLetters = input.Substring(1).ToLower();
                return firstLetter + restOfLetters;
            }
            else
                return input;
           
        }

        /// <summary>
        /// Retrieves the first letter of the string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstLetter(this string input)
        {
            if (!Validate.IsEmpty(input))
            {
                string firstLetter = input.Substring(0, 1);
                return firstLetter;
            }
            else
                return input;
        }
        /// <summary>
        /// Converts the string to an int.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ToInt(this string input)
        {
            int.TryParse(input, out int inputInt);
            return inputInt;
        }

    }
}
