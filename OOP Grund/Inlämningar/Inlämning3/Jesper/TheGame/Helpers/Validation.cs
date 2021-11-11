using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.DisplayMethods.Display;

namespace TheGame.Helpers
{
    public class Validation
    {

        /// <summary>
        /// Simple validation to make sure the players name isn't longer than a certain amount of characters, decided by the tooLong variable. Just in case.
        /// </summary>
        /// <returns></returns>
        public static string ValidatedName()
        {
            int tooManyLetters = 30;
            string userName;
            do
            {
                CenterWriteLine("Enter your name: ");
                CursorPosition(19, 52);
                userName = Console.ReadLine();
                if(userName.Length >= tooManyLetters)
                    CenterWriteLine($"Your name is too long. It cannot exceed {tooManyLetters} characters. Try again.");
            } while (userName.Length >= tooManyLetters);
            return userName.Trim();
        }
    }
}
