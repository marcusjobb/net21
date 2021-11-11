using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

using MonoSquares.Physics;

namespace MonoSquares.Graphics
{
    class Camera : Game
    {
        public GraphicsDevice Device;
        public SpriteBatch Scene;
        public List<IGraphics> Bodies = new List<IGraphics>();

        protected float zoom; // Camera Zoom
        public Matrix transform; // Matrix Transform
        public Vector2 pos; // Camera Position
        protected float rotation; // Camera Rotation

        public IPhysics Following;

        public float Zoom
        {
            get { return zoom; }
            set { zoom = value; if (zoom < 0.1f) zoom = 0.1f; }
        }

        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public void Move(Vector2 amount)
        {
            pos += amount;
        }

        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        public Camera()
        {
            zoom = 1.0f;
            rotation = 0.0f;
            pos = Vector2.Zero;

            Following = null;
        }
        public void FollowEntity()
        {
            if (Following != null)
            {
                pos.X = Following.Body.X;
                pos.Y = Following.Body.Y;
            }
        }
        public void BindObject(IGraphics obj)
        {
            Bodies.Add(obj);
        }

        public void LoadTextures(ContentManager content)
        {
            foreach (var body in Bodies)
            {
                body.Texture = content.Load<Texture2D>(body.TexturePath);

                //Debug.WriteLine($"Loaded: {body.TexturePath}");

            }
        }

        public void Update()
        {
            Scene.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend, null, null, null, null, GetTransformation(Device));

            foreach (var graphic in Bodies)
            {
                if (graphic != null)
                {
                    Scene.Draw(graphic.Texture, graphic.Body, Color.White);
                }

            }

            FollowEntity();

            Scene.End();
        }

        public Matrix GetTransformation(GraphicsDevice graphicsDevice)
        {
            int ViewportWidth = graphicsDevice.Viewport.Width;
            int ViewportHeight = graphicsDevice.Viewport.Height;

            transform =       // Thanks to o KB o for this solution
              Matrix.CreateTranslation(new Vector3(-pos.X, -pos.Y, 0)) *
                                         Matrix.CreateRotationZ(Rotation) *
                                         Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) *
                                         Matrix.CreateTranslation(new Vector3(ViewportWidth * 0.5f, ViewportHeight * 0.5f, 0));
            return transform;
        }

    }
}
