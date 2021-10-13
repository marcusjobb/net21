using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_ContactList.HelperMethods
{
    public class UserExperience
    {

        /// <summary>
        /// Simple method to inform the user to press a button to continue. Also clears the console.
        /// </summary>
        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
