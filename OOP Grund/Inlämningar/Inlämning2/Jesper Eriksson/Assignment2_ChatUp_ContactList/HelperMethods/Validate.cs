using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_ContactList.HelperMethods
{
    public static class Validate
    {
        /// <summary>
        /// Returns true if the user has entered a string which contains numbers. Goes through each character one by one to see if it is a number.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool StringNoNumber(string inputText)
        {
            bool containsNumber = false;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsNumber(inputText[i]))
                {
                    containsNumber = true;
                }                
            }
            return containsNumber;
        }

        /// <summary>
        /// Returns true if the user leaves the input field blank.
        /// (A bool which contains a bool might be redundant..)
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool IsEmpty(string inputText)
        {
            bool isEmpty = string.IsNullOrWhiteSpace(inputText);
            return isEmpty;
        }

        /// <summary>
        /// If the user has not entered an email which contains "@" and a "." somewhere, it is not likely to be a valid email adress.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool EMail(string inputText)
        {
            bool notLikelyEmail = false;
            if (!inputText.Contains('.') && !inputText.Contains('@'))
            {
                notLikelyEmail = true;
            }
            return notLikelyEmail;
        }
        /// <summary>
        /// Checks if the user is younger than 18 or older than 120. Can be used to allow a certain age-span to be validated.
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public static bool AgeSpan(DateTime dateOfBirth)
        {
            int notAMinor = DateTime.Now.Year - 18;
            int tooOldToBe = DateTime.Now.Year - 120;
            if (dateOfBirth.Year < tooOldToBe || dateOfBirth.Year > notAMinor)
                return false;
            else
                return true;
        }
    }
}
