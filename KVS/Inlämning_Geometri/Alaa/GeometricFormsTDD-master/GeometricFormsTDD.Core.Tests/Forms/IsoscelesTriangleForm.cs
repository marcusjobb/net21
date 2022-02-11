using GeometricFormsTDD.Core.Interface;
using System;

namespace GeometricFormsTDD.Core
{
    internal class IsoscelesTriangleForm : InterfaceForm
    {
        public IsoscelesTriangleForm()
        {
        }

        public float Side { get; set; }
        public float Base { get; set; }

        public float GetPerimeter()
        {
            return Base + (Side * 2);
        }

        public float GetArea()
        {
            //return (float)(Math.Sqrt((Side * Side) - (Base * Base)) * Base/2);
            return (float)(Math.Sqrt(Math.Pow(Side, 2) - (Math.Pow(Base, 2)/4)) * Base / 2);
        }
    }
}