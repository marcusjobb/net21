using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF_Genealogy.Display.DisplayHelper;

namespace EF_Genealogy.Utils
{
    public static class UserExperience
    {
        public static void PressKeyToContinue()
        {
            WriteLineColour("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PressEnterToContinue()
        {
            WriteLineColour("Press [Enter] to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static bool AskForAChoice()
        {
            WriteLineColour("Press [1] or \"Y\" for \"yes\". Press [Enter] to continue.");
            var userChoice = Console.ReadLine().ToUpper(); ;
            if (userChoice.ToString() == "1" || userChoice == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShortPause(int pauseInt = 100)
        {
            System.Threading.Thread.Sleep(pauseInt);
        }
    }
}
