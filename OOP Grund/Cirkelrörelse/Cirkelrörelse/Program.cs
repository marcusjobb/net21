using System;
using System.Collections.Generic;
using System.Threading;

namespace Cirkelrörelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            // circle related
            const double angleMovement = .08; // current angle movement
            const double maxAngle = 2 * Math.PI;
            const int ZoomX = 25; // resizing the circle
            const int ZoomY = 10; // resizing the circle
            int maxX = Console.WindowWidth - 1;
            int maxY = Console.WindowHeight - 1;
            double angle = 0; // current angle
            double x = 0; // variable definition
            double y = 0;// variable definition
            Queue<int> xMemory = new Queue<int>();
            Queue<int> yMemory = new Queue<int>();
            int trail = 12; // how many balls will be drawn before deleting
            for (int i = 0; i < trail; i++)
            {
                xMemory.Enqueue(0);
                yMemory.Enqueue(0);
            }
            // Window related
            int middleX = Console.WindowWidth / 2;  // positionen to make sure the circle is centered
            int middleY = Console.WindowHeight / 2; // positionen to make sure the circle is centered

            while (true)
            {
                Console.SetCursorPosition(xMemory.Dequeue(), yMemory.Dequeue());
                Console.Write(" ");
                xMemory.Enqueue((int)x);
                yMemory.Enqueue((int)y);
                angle += angleMovement;
                if (angle > maxAngle) angle = 0;
                x = middleX + Math.Cos(angle) * ZoomX;
                y = middleY + Math.Sin(angle) * ZoomY;
                if (x < 0) x = 0;
                if (x > maxX) x = maxX;
                if (y < 0) y = 0;
                if (y > maxY) x = maxY;
                Console.SetCursorPosition((int)x, (int)y);
                Console.WriteLine("O");
                Thread.Sleep(50);
            }


        }
    }
}
