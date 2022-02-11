using GeometricFormsTDD.Core.Interface;
using System;


namespace GeometricFormsTDD.Core
{
    internal class CircleForm : InterfaceForm
    {
        public CircleForm()
        {
        }

        public float Radius { get; set; }

        //internal float GetCirclePerimeter(float radius)
        //{
        //    return 2 * (float)Math.PI * radius;
        //}

        //internal float GetCircleArea(float radius)
        //{
        //    return (float)Math.PI * radius * radius;
        //}

        public float GetPerimeter()
        {
            return 2 * (float)Math.PI * Radius;
        }

        public float GetArea()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}