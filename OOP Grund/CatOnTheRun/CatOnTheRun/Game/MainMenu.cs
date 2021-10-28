// -----------------------------------------------------------------------------------------------
//  MainMenu.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CatOnTheRun.GUI;

    internal class MainMenu
    {
        internal int Show(params string[] items)
        {
            var menu = new MenuDisplayer(items);
            menu.Title = "Welcome to the game";
            menu.Display();
            return menu.ChosenItem;
        }
    }

    internal class InGameMenu
    {
        internal void Show()
        {

        }
    }

    internal class ShopMenu
    {
        internal void Show()
        {

        }
    }

}
