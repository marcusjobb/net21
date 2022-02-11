using System;

namespace JT_TDD_Inlämning1
{
    public class Square : GeometricThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">Length of square side.</param>
        public Square(float side)
        {
            if (side > 0)
            {
                this.Width = side;
                this.Height = side;
            }
            else
            {
                this.Width = 0;
                this.Height = 0;
                Console.WriteLine("The sides of a square must be greater than zero!");
            }
        }

        /// <summary>
        /// Calculates the area of a square by multiplying the width times the height.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return Width * Height;
        }

        /// <summary>
        /// Calculates the perimeter of a square by adding each side.
        /// </summary>
        /// <returns></returns>
        public override float Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
