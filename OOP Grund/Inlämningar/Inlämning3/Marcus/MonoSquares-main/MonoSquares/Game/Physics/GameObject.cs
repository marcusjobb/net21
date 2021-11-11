using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoSquares.Graphics;

namespace MonoSquares.Physics
{
    class GameObject : IGraphics, IPhysics
    {
        public Rectangle Body { get; set; }
        public Texture2D Texture { get; set; }
        public string TexturePath { get; set; }

        public Vector2 tempVelocity { get; set; }
        public Vector2 Velocity { get; set; }
        public Vector2 Position { get; set; }

        public float Acceleration { get; set; }
        public float MaxSpeed { get; set; }
        public float Friction { get; set; }
        public bool IsSolid { get; set; }
        public bool Collided { get; set; }

        public int PhysicsType { get; set; }
        public bool showScore { get; set; } = false;

        protected virtual void OnTouch(object entity1, object entity2, EventArgs e) { }
        protected virtual void OnThink(object entity1, EventArgs e) { }
    }
}
