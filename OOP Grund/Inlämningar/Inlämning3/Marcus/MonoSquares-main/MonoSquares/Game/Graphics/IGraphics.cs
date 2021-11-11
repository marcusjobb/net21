using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoSquares.Graphics
{
    interface IGraphics
    {
        public Rectangle Body { get; set; }
        public Texture2D Texture { get; set; }
        public String TexturePath { get; set; }
    }
}
