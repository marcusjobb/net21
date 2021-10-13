using System;

namespace Inlämning_2_ChatUp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MainMenu.Write("Välkommen till ChatUp");
            while (true)
            {
                MainMenu mainmenu = new MainMenu();
                mainmenu.ShowMainMenu();
            }
        }
        
    }
}
