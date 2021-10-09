// -----------------------------------------------------------------------------------------------
//  IFigure.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Livekod210924.Geometry
{
    public interface IFigure
    {
        double Area { get; }
        double Circumference { get; }
    }
}