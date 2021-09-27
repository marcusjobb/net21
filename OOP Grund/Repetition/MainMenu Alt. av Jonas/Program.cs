using System;
using System.Threading;

namespace MainMenu
{
    internal static class Program
    {
        private static void Main()
        {

            CarteDuJour carte = new CarteDuJour();

            carte.AddOption("Filet Mignon");
            carte.AddOption("Homard a la Amoricaine");
            carte.AddOption("Just a tiny mint wafer, Monsieur");
            carte.Title = "Welcome to RoboGarcon (Use arrow keys to select, <ENTER> to choose)  ";

            //int choice = carte.ALaCarte();
            while (true)
            {
                int choice = 5;
                int max = carte.GetLength();
                carte.ShowMenu();
                //Thread.Sleep(5500);
                //int choice = carte.LetUserChoose();
                choice = carte.LetUserChoose();
                if (choice < max)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You chose " + carte.GetOption(choice));
                    break;
                }
            }
            Console.ReadLine();          
        }
    }
    

}
