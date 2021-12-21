// -----------------------------------------------------------------------------------------------
//  Position.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{
    using System;
    internal class Position : IEquatable<Position>
    {
        internal int X { get; set; }
        internal int Y { get; set; }

        internal Position(Position pos)
        {
            X = pos.X;
            Y = pos.Y;
        }
        internal Position() { }
        internal void SetTo(Position pos)
        {
            X = pos.X;
            Y = pos.Y;
        }

        public bool Equals(Position other)
        {
            var equal = false;
            if (other != null)
                if (X == other.X && Y == other.Y) equal = true;
            return equal;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Position) return false;
            return Equals(obj as Position);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
