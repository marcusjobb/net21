using System;

namespace JT_TDD_Inlämning1
{
    public class Triangle : GeometricThing //rätvinkliga, likbenta, liksidiga
    {
        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        public float Side { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="tbase">Length of triangle base or adjacent side..</param>
        /// <param name="side">Length of default side or hypotenuse.</param>
        /// <param name="height">Length of triangle height or opposite side.</param>
        public Triangle(float tbase, float side, float height)
        {
            if (tbase > 0 && side > 0 && height > 0)
            {
                this.Width = tbase;
                this.Side = side;
                this.Height = height;
            }
            else
            {
                this.Width = 0;
                this.Side = 0;
                this.Height = 0;
                Console.WriteLine("The sides of a triangle must be greater than zero!");
            }
        }

        /// <summary>
        /// Calculates the area of a triangle by multiplying the height times the base divided by 2.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return (Width * Height) / 2;
        }

        /// <summary>
        /// Calculates the perimeter of a triangle by adding each side.
        /// </summary>
        /// <returns></returns>
        public override float Perimeter()
        {
            return Side + Width + Height;
        }
    }
}
