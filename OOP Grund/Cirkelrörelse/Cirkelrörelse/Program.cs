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
            const int ZoomY =  10; // resizing the circle
            int maxX = Console.WindowWidth - 1;
            int maxY = Console.WindowHeight - 1;
            double angle = 0; // current angle
            double x = 0; // variable definition
            double y = 0;// variable definition
            Queue<int> xMemory = new Queue<int>(); // Generate memory of X
            Queue<int> yMemory = new Queue<int>(); // Generate memory of Y
            int trail = 12; // how many balls will be drawn before deleting
            for (int i = 0; i < trail; i++)
            {
                xMemory.Enqueue(0); // Generate an empty queue where all positions are 0,0
                yMemory.Enqueue(0); // Generate an empty queue where all positions are 0,0
            }
            // Window related
            int middleX = Console.WindowWidth / 2;  // positionen to make sure the circle is centered
            int middleY = Console.WindowHeight / 2; // positionen to make sure the circle is centered

            while (true)
            {
                Console.SetCursorPosition(xMemory.Dequeue(), yMemory.Dequeue()); // Set cursor to memory position
                Console.Write(" "); // Delete ball
                xMemory.Enqueue((int)x); // Add current position to list
                yMemory.Enqueue((int)y); // Add current position to list

                angle += angleMovement; // Make the ball move
                if (angle > maxAngle) angle = 0; // If the angle has move a whole circle start from 0 again
                x = middleX + Math.Cos(angle) * ZoomX; // Use Cosine to make the ball stay in a circle and enlarge the size of the circle
                y = middleY + Math.Sin(angle) * ZoomY; // Use Sine to make the ball stay in a circle and enlarge the size of the circle
                
                if (x < 0) x = 0; // Make sure the ball is within the screens boundaries
                if (x > maxX) x = maxX;
                if (y < 0) y = 0;
                if (y > maxY) x = maxY;
                Console.SetCursorPosition((int)x, (int)y); // Place the cursor
                Console.WriteLine("O"); // Draw a ball
                Thread.Sleep(50); // Wait 
            }
        }
    }
}
