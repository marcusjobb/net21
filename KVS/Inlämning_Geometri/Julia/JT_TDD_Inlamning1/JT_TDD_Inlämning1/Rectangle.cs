using System;

namespace JT_TDD_Inlämning1
{
    public class Rectangle : GeometricThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">Length of rectangle width.</param>
        /// <param name="height">Length of rectangle height.</param>
        public Rectangle(float width, float height)
        {
            if (width > 0 && height > 0)
            {
                this.Width = width;
                this.Height = height;
            }
            else
            {
                this.Width = 0;
                this.Height = 0;
                Console.WriteLine("The sides of a rectangle must be greater than zero!");
            }
        }

        /// <summary>
        /// Calculates the area of a rectangle by multiplying the width times the height.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return Width * Height;
        }

        /// <summary>
        /// Calculates the perimeter of a rectangle by adding each side.
        /// </summary>
        /// <returns></returns>
        public override float Perimeter()
        {
            return 2*(Width+Height);
        }
    }
}
