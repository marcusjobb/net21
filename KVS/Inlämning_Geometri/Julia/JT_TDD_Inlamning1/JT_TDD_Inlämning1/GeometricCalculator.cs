using System;

namespace JT_TDD_Inlämning1
{
    public static class GeometricCalculator
    {
        /// <summary>
        /// Calculates the area of given shape.
        /// </summary>
        /// <param name="thing">Type of geometric shape.</param>
        /// <returns></returns>
        public static float GetArea(GeometricThing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }
            return thing.Area();
        }

        /// <summary>
        /// Calculates the perimeter of given shape.
        /// </summary>
        /// <param name="thing">Type of geometric shape.</param>
        /// <returns></returns>
        public static float GetPerimeter(GeometricThing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }
            return thing.Perimeter();
        }

        /// <summary>
        /// Calculates the total perimeter of given shapes.
        /// </summary>
        /// <param name="thing">Type of geometric shapes.</param>
        /// <returns></returns>
        public static float GetPerimeter(GeometricThing[] thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            float perimeter = 0;
            foreach (var shape in thing)
            {
                perimeter += shape.Perimeter();
            }

            return perimeter;
        }
    }
}
