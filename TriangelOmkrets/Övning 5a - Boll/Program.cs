using System;

namespace Övning_5a___Boll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bollens position
            int bollX = 10;
            int bollY = 10;

            // Bollens riktning / hastighet
            int bollXH = -1;
            int bollYH = 1;

            // Skärmgränser
            int maxX = 119;
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
                Console.WriteLine("O");
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(bollX, bollY);
                Console.WriteLine(" ");

            }


        }
    }
}
