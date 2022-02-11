using GeometricFormsTDD.Core.Interface;
using System;

namespace GeometricFormsTDD.Core
{
    internal class RightTriangleForm : InterfaceForm
    {
        public RightTriangleForm()
        {
        }

        public float Base { get; set; }
        public float Height { get; set; }

        public float GetHypotenuse()
        {
             return (float)Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2));
            
        }

        public float GetPerimeter()
        {
            return Base + Height + GetHypotenuse();
        }

        public float GetArea()
        {
            return ((Base * Height) / 2);
        }

       
        
    }
    
}