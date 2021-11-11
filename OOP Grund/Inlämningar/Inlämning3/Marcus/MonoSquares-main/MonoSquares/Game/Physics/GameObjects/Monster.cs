using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MonoSquares.Physics.GameObjects
{
    class Monster : GameObject, ILiving
    {
        public PhysicsEngine Engine;
        public int Health { get; set; }
        public int Damage { get; set; }


        public Monster()
        {
            Acceleration = 0.5f;
            MaxSpeed = 1.0f;
            Friction = 0.95f;
            PhysicsType = (int)PhysicsTypes.Thinking;
            IsSolid = true;
            Damage = 1;
            Health = 100;
        }
        
        protected override void OnTouch(object entity1, object entity2, EventArgs e)
        {
            Monster ent1 = (Monster)entity1;
            Player ent2 = (Player)entity2;

            if (ent2.PhysicsType == 1)
            {
                Health -= ent2.Damage;

            }

           
        }

        public Task Control()
        {
            Random rnd = new Random();
            Engine.AdditativeImpact(this, 5, rnd.Next(0, 7));

            return Task.CompletedTask;
        }
    }
}
