using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assignment1.Helpers
{
    public class UserExperience
    {
        public static void PressKeyToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
