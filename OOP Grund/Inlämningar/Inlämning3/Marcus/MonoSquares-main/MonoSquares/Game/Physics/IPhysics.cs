using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

enum PhysicsTypes
{
    NonThinking = 0,
    Thinking = 1
}

namespace MonoSquares.Physics
{
    interface IPhysics
    {
        public Rectangle Body { get; set; }
        public Vector2 tempVelocity { get; set; }
        public Vector2 Velocity { get; set; }

        public float Acceleration { get; set; }
        public float MaxSpeed { get; set; }
        public float Friction { get; set; }
        public bool IsSolid { get; set; }
        public bool Collided { get; set; }
        public int PhysicsType { get; set; }
        public virtual void OnTouch(object entity1, object entity2, EventArgs e) { }
        public virtual void OnThink(object entity1, EventArgs e) { }

    }
}
