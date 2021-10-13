using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_ContactList.HelperMethods
{
    public class DisplayHelper
    {
        /// <summary>
        /// Sets the colours.
        /// </summary>
        public static void Colours()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        /// <summary>
        /// Method to print the parameter text as a header. The header consists of a solid line above the text, with a two-line border to the left of the text.
        /// </summary>
        /// <param name="text"></param>
        public static void MenuHeader(string text)
        {
            int width = text.Length;
            string top = " ─" + new string('─', width + 5);
            string left = "│ ";
            Console.WriteLine(top + "\n" + left + text + "\n" + left);
        }
        /// <summary>
        /// Prints a menu item with a single border to the left of the text
        /// </summary>
        /// <param name="text"></param>
        public static void MenuItem(string text)
        { 
            string left = "│ ";
            Console.WriteLine(left + text);
        }
        public static void MenuItemBottom(string text)
        {
            string left = "│ ";
            Console.WriteLine(left + text + "\n" + left);
        }
        /// <summary>
        /// Prints a "F - Contacts" ASCII image meant as a logo for the "F"-Chat app.
        /// </summary>
        public static void MainMenuHeader()
        {
            string MainMenuLogo = @"
│  __         __                  
│ |_    __   /   _  _ |_ _   _|_  _ 
│ |          \__(_)| )|_(_|(_ |_ _) 
│";
            int width = MainMenuLogo.Length/3;
            string top = " ─" + new string('─', width + 5);
            Console.WriteLine(top + MainMenuLogo);
        }
        /// <summary>
        /// Prints the "company logo" when the user exits the program.
        /// </summary>
        public static void ExitScreen()
        {
            string exitMessage = @"

                                                                                  
                     _/_/_/  _/                    _/                          _/    _/           
                  _/        _/_/_/      _/_/_/  _/_/_/_/                      _/    _/  _/_/_/    
                 _/        _/    _/  _/    _/    _/          _/_/_/_/_/      _/    _/  _/    _/   
                _/        _/    _/  _/    _/    _/                          _/    _/  _/    _/    
                 _/_/_/  _/    _/    _/_/_/      _/_/                        _/_/    _/_/_/       
                                                                                    _/            
                                                                                   _/             
            
                                                                                    ";
            Console.WriteLine(exitMessage);
        }
    }
}
