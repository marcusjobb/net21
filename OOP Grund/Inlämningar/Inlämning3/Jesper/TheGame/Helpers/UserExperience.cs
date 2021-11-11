using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheGame.DisplayMethods.Display;
namespace TheGame.Helpers
{
    /// <summary>
    /// Simple methods to save some repetitive code.
    /// </summary>
    public class UserExperience
    {

        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
            Console.Clear();
        }


        public static void CenterPressEnterToContinue()
        {
            CenterWriteLine("Press [Enter] to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PressEnterCombat()
        {
            CenterWriteLine("Press [Enter] to continue");
            Console.ReadLine();
        }

        public static void PressEnterCombatSameLine()
        {
            CenterWrite("Press [Enter] to continue");
            Console.ReadLine();
        }

    }
}
