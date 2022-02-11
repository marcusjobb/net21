using System;

namespace JT_TDD_Inlämning1
{
    public class Circle : GeometricThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Length of circle radius</param>
        public Circle(float radius)
        {
            if (radius > 0)
            {
                this.Width = radius;
                this.Height = radius;
            }
            else
            {
                this.Width = 0;
                this.Height = 0;
            }
        }

        /// <summary>
        /// Calculates the area of a circle by multiplying radius*radius*π.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return Width * Height * (float)Math.PI;
        }

        /// <summary>
        /// Calculates the perimeter of a circle by multiplying 2*π*radius.
        /// </summary>
        /// <returns></returns>
        public override float Perimeter()
        {
            return 2 * (float)Math.PI * Width;
        }
    }
}
