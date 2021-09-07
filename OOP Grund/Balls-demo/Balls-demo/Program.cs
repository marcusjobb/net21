namespace Balls_demo
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            int x = 120/2;
            int y = 28/2;
            int dirX = 1;
            int dirY = 1;
            int maxX = 119;
            int maxY = 28;
            int minX = 1;
            int minY = 1;
            int colorCounter = 0;
            int dirColor = 1;
            char symbol = '.';

            Console.CursorVisible = false;
            while (true)
            {
                x += dirX;
                y += dirY;
                if (x > maxX || x < minX)
                {
                    dirX = -dirX;
                    continue;
                }
                if (y > maxY || y < minY)
                {
                    dirY = -dirY;
                    continue;
                }
                colorCounter+=dirColor;
                if (colorCounter>2 || colorCounter<1)
                {
                    dirColor= -dirColor;
                }
                Console.ForegroundColor = (ConsoleColor)colorCounter;

                Console.SetCursorPosition(x, y); Console.Write(symbol);
                //Console.SetCursorPosition(maxX-x, y); Console.Write(' ');
                //Console.SetCursorPosition(x, maxY-y); Console.Write(' ');
                Console.SetCursorPosition(maxX-x, maxY-y); Console.Write(symbol);
                Thread.Sleep(15);
                //Console.SetCursorPosition(x, y); Console.Write(" ");
                //Console.SetCursorPosition(maxX - x, y); Console.Write(" ");
                //Console.SetCursorPosition(x, maxY - y); Console.Write(" ");
                //Console.SetCursorPosition(maxX - x, maxY - y); Console.Write(" ");
            }
        }
    }
}
