using System;
using System.Threading;

namespace MainMenu
{
    public class CarteDuJour : Menu
   //public class CarteDuJour 
    {
        int choice;

        public override void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.CursorVisible = false;
            int max = MenuOptions.Count;

            for (int i = 0; i < max; i++)
            {


                if (i == choice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i] );
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i] );
                }

                Console.ForegroundColor = ConsoleColor.White;
                 Console.BackgroundColor = ConsoleColor.Black;
            }


        }

        public override int LetUserChoose()
        {
            int max = MenuOptions.Count;
            

                //choice = 2;

                ConsoleKey readKey = Console.ReadKey().Key;
                //Thread.Sleep(50);
                if (readKey == ConsoleKey.DownArrow)
                {
                    choice++;
                    choice = choice % max;

                }

                else if (readKey == ConsoleKey.UpArrow)
                {
                    if (choice == 0)
                    {
                        choice = max - 1;
                    }
                    else
                    {
                        choice--;
                    }
                }
                else

                if (readKey == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return choice;
                }
               
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("noneOFtheAbove");
            return max + 1;
        }

        public override string GetOption(int choice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            string returnMe = MenuOptions[choice];
            returnMe = returnMe.ToUpper();
            return returnMe;
        }
        public int GetLength ()
        {
            int length= MenuOptions.Count;
            return length;
        }
    }
    

}
