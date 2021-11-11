using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace MonoSquares.Physics.GameObjects
{
    class Player : GameObject , ILiving
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public Player()
        {
            Acceleration = 0.8f;
            MaxSpeed = 2.0f;
            Friction = 0.90f;
            PhysicsType = (int)PhysicsTypes.Thinking;
            IsSolid = true;
            Damage = 3;
            Health = 1000;
        }

        protected override void OnTouch(object entity1, object entity2, EventArgs e)
        {
            Player ent1 = (Player)entity1;
            Monster ent2 = (Monster)entity2;

            if (ent2.PhysicsType == 1)
            {
                Health -= ent2.Damage;

                Debug.WriteLine($"Health: {ent1.Health}");

                Debug.WriteLine($"Health: {ent2.Health}");
            }


                
        }
    }

 
}
