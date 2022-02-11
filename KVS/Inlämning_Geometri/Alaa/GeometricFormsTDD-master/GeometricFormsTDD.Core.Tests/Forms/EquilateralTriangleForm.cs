using GeometricFormsTDD.Core.Interface;
using System;


namespace GeometricFormsTDD.Core
{
    internal class EquilateralTriangleForm : InterfaceForm
    {
        public EquilateralTriangleForm()
        {
        }

        public float Side { get; set; }

        public float GetPerimeter()
        {
            return Side * 3;
        }

        public float GetArea()
        {
            return (float)((Math.Sqrt(3)/ 4) * Math.Pow(Side, 2));
        }
    }
}