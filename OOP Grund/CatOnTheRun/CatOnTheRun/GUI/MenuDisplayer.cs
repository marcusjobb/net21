// -----------------------------------------------------------------------------------------------
//  MenuDisplayer.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MenuDisplayer
    {
        public int MinValue { get; set; } = 1;
        public int MaxValue { get; set; } = 999;
        public List<MenuItem> Items { get; set; } = new();
        public string Title { get; set; }
        public int ChosenItem { get; set; } = 0;
        public MenuDisplayer() { }
        public MenuDisplayer(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Items.Add(new MenuItem { Enabled = !item.StartsWith('§'), Text = item.Replace("§", "") });
            }
        }
        public MenuDisplayer(List<MenuItem> items)
        {
            Items = items;
        }

        public void Display()
        {
            Console.Clear();
            NiceText.Title(Title);
            PrintMenuItems();

            ChosenItem = GetInput();
        }

        private void PrintMenuItems()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var num = (i + 1).ToString().PadLeft(3);
                if (Items[i].Enabled)
                    Console.ResetColor();
                else
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{num} {Items[i].Text}");
            }
        }

        private int GetInput()
        {
            int choice;
            int pos = Console.CursorTop;
            do
            {
                choice = 0;
                Console.CursorTop = pos;
                while (choice < 1 || choice > Items.Count)
                {
                    choice = Helpers.Input.GetInt(1, Items.Count);
                }
                choice--;
            } while (!Items[choice].Enabled);
            return choice;
        }
    }

    internal class MenuItem
    {
        public string Text { get; set; }
        public bool Enabled { get; set; } = true;
        public override string ToString() => Text;
    }
}
