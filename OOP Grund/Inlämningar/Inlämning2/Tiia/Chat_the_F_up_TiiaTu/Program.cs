using System;
using System.Threading;

namespace Chat_the_F_up_TiiaTu
{
    
    class Program
    {
        static void Main()
        {
            while (true)
            {
                HelperClass.Menu();
                Console.Write("Enter number: ");
                int.TryParse(Console.ReadLine(), out int menuChoise);
                ContactList.CheckAction(menuChoise);
            }
        }
    }
}

      

