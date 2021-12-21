// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Threading;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 24);
            Console.SetBufferSize(100, 24);

            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            int plusX = 1;
            int plusY = 1;
            while (true)
            {
                // Snabbare än try catch
                if (x > 98 || x < 1) plusX = -plusX;
                if (y > 22 || y < 1) plusY = -plusY;

                x += plusX;
                y += plusY;

                //try
                //{
                Console.CursorLeft = x;
                //}
                //catch
                //{
                //plusX = -plusX;
                //}

                //try
                //{
                Console.CursorTop = y;
                //}
                //catch
                //{
                //plusY = -plusY;
                //}
                Console.Write("O");
                Thread.Sleep(1);
            }
        }
    }
}
