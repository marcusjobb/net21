// -----------------------------------------------------------------------------------------------
//  Menu.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using System;
    using System.Collections.Generic;

    internal class Menu
    {

        #region Private Fields

        private string bottomLine = "";
        private static readonly ConsoleColor currentBackground = Console.BackgroundColor;
        private static readonly ConsoleColor currentForeground = Console.ForegroundColor;
        private int headerLines = 0;
        private readonly string HelpText = " Arrow keys to navigate, Enter to select.";
        private int infoLines = 0;
        private int menuwidth = 0;
        private string midLine = "";
        private string topLine = "";

        #endregion Private Fields

        #region internal Constructors

        internal Menu(List<string> menuItems, int headerLines)
        {
            SetupMenu(this, menuItems, headerLines, 0);
        }

        internal Menu(List<string> menuItems, int headerLines, int infoLines)
        {
            SetupMenu(this, menuItems, headerLines, infoLines);
        }

        internal Menu(List<string> menuItems)
        {
            SetupMenu(this, menuItems, 1, 0);
        }

        #endregion internal Constructors

        #region internal Properties

        internal List<string> MenuItems { get; set; }

        #endregion internal Properties

        #region Private Properties

        private int HeaderLines { get => headerLines; set => headerLines = value >= MenuItems.Count ? 0 : value; }
        private int InfoLines { get => infoLines; set => infoLines = value + HeaderLines >= MenuItems.Count ? 0 : value; }
        private int StartSelected => HeaderLines + InfoLines;

        #endregion Private Properties

        #region internal Methods

        internal void UpdateMenuItem(string update, int index)
        {
            MenuItems[index] = update;
            SetupPrintables(this);
        }

        internal string UseMenu()
        {
            if (MenuItems.Count == 0) MenuItems.Add("Auto added item because of empy menu, check your code.");
            return DoMenu(this);
        }

        #endregion internal Methods

        #region Private Methods

        private static string DoMenu(Menu menu)
        {
            var highlightItem = menu.StartSelected;
            var userChoice = "";

            SetColors();
            Console.Clear();

            do
            {
                UpdateMenu(menu, highlightItem);
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow or ConsoleKey.UpArrow:
                        if (highlightItem == menu.StartSelected) highlightItem = menu.MenuItems.Count - 1;
                        else highlightItem--;
                        break;

                    case ConsoleKey.RightArrow or ConsoleKey.DownArrow:
                        if (highlightItem == menu.MenuItems.Count - 1) highlightItem = menu.StartSelected;
                        else highlightItem++;
                        break;

                    case ConsoleKey.Enter:
                        userChoice = menu.MenuItems[highlightItem];
                        break;

                    default:
                        break;
                }
            } while (userChoice == "");
            Console.ResetColor();
            Console.Clear();
            return userChoice;
        }
        private static void InvertColors()
        {
            Console.ForegroundColor = currentBackground;
            Console.BackgroundColor = currentForeground;
        }

        private static void SetColors()
        {
            Console.ForegroundColor = currentForeground;
            Console.BackgroundColor = currentBackground;
        }

        private static void SetupMenu(Menu menu, List<string> menuItems, int headerLines, int infoLines)
        {
            menu.MenuItems = menuItems;
            menu.HeaderLines = headerLines;
            menu.InfoLines = infoLines;
            SetupPrintables(menu);
        }

        private static void SetupPrintables(Menu menu)
        {
            menu.menuwidth = menu.HelpText.Length;
            foreach (var item in menu.MenuItems)
            {
                if (item.Length > menu.menuwidth) menu.menuwidth = item.Length;
            }

            menu.topLine = "╔" + new string('═', menu.menuwidth) + "╗";
            menu.midLine = "╟" + new string('─', menu.menuwidth) + "╢";
            menu.bottomLine = "╚" + new string('═', menu.menuwidth) + "╝";
        }

        private static void UpdateMenu(Menu menu, int highlightItem)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            Console.WriteLine(menu.topLine);

            for (var row = 0; row < menu.MenuItems.Count; row++)
            {
                if (row == highlightItem)
                {
                    Console.Write("║");
                    InvertColors();
                    Console.Write(menu.MenuItems[row].PadRight(menu.menuwidth));
                    SetColors();
                    Console.WriteLine("║");
                }
                else
                {
                    Console.WriteLine($"║" + menu.MenuItems[row].PadRight(menu.menuwidth) + "║");
                    if (row == menu.HeaderLines - 1 || row == menu.HeaderLines + menu.InfoLines - 1) Console.WriteLine(menu.midLine);
                }
            }
            Console.WriteLine(menu.bottomLine);
            Console.WriteLine(menu.HelpText);
        }

        #endregion Private Methods
    }
}