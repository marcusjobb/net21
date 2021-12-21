// -----------------------------------------------------------------------------------------------
//  IFigure.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Livekod210924.Geometry
{
    public interface IFigure
    {
        double Area { get; }
        double Circumference { get; }
    }
}