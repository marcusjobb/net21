using GeometricFormsTDD.Core.Interface;
using System;

namespace GeometricFormsTDD.Core
{
    internal class RectangleForm : InterfaceForm
    {
        public RectangleForm()
        {
        }

        public float SideA { get; set; }
        public float SideB { get; set; }

        public float GetPerimeter()
        {
            return (SideA + SideB) * 2 ;
        }

        public float GetArea()
        {
            return SideA * SideB;
        }
    }
}