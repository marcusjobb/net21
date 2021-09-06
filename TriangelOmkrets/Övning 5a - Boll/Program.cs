using System;

namespace Övning_5a___Boll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            // Bollens position
            int bollX = 10;
            int bollY = 10;

            // Bollens riktning / hastighet
            int bollXH = -1;
            int bollYH = 1;

            // Skärmgränser
            int maxX = 110;
            int maxY = 24;
            int minX = 1;
            int minY = 1;
            while (true)
            {

                bollX += bollXH;
                bollY += bollYH;

                if (bollX>=maxX)
                {
                    bollXH = -bollXH;
                }
                if (bollY >= maxY)
                {
                    bollYH = -bollYH;
                }

                if (bollY < minY)
                {
                    bollYH = -bollYH;
                }

                if (bollX < minX)
                {
                    bollXH = -bollXH;
                }

                Console.SetCursorPosition(bollX, bollY);
                Console.WriteLine(".---.");
                Console.SetCursorPosition(bollX, bollY+1);
                Console.WriteLine("'---'");
                System.Threading.Thread.Sleep(50);
                Console.SetCursorPosition(bollX, bollY);
                Console.WriteLine("     ");
                Console.SetCursorPosition(bollX, bollY+1);
                Console.WriteLine("     ");
            }


        }
    }
}
