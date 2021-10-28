// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Helpers
{
    using System;

    internal class OneLineMessage
    {
        private string message;

        public OneLineMessage(string message) => this.message = message;
        int pos = 0;
        
        internal void Show()
        {
            pos = Console.CursorTop;
            Console.WriteLine(message);
            Console.CursorTop=pos;
        }

        internal void Delete()
        {
            Console.CursorTop = pos;
            Console.WriteLine(new string(' ', Console.WindowWidth));
            Console.CursorTop = pos;
        }
    }
}