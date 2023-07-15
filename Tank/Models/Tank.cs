namespace Tank
{
    internal class Tank : Sprite
    {
        public Input Controls;
        private Keys lastKey;
        private Keys currentKey;
        
        public static readonly float speed = 32f;
        private bool f = false;
        
        public Bullet bullet = new Bullet();

        public Tank(Texture2D texture) : base(texture,3,1,0.1f) 
        {
            
        }


        
        public Tank(Texture2D texture, float x, float y,Keys L,Keys R,Keys U, Keys D, Keys F) : base(texture,3,1,0.1f)
        {
            position.X = x;
            position.Y = y;
            body.X = (int)position.X;
            body.Y = (int)position.Y;
            Controls = new Input()
            {
                Left = L,
                Right = R,
                Up = U,
                Down = D,
                Fire = F
            };
            lastKey = Controls.Right;
        }
        
        private void Move()
        {
            if(Keyboard.GetState().IsKeyDown(Controls.Left))
            {
                currentKey = Controls.Left;

            }
            if(Keyboard.GetState().IsKeyDown(Controls.Right))
            {
                currentKey = Controls.Right;
            }
            if(Keyboard.GetState().IsKeyDown(Controls.Up))
            {
                currentKey = Controls.Up;
            }
            if( Keyboard.GetState().IsKeyDown(Controls.Down)) 
            {
                currentKey = Controls.Down;
            }
            if (Keyboard.GetState().IsKeyDown(Controls.Fire) && bullet.velocity == Vector2.Zero && bullet.exp.reload)
            {
                bullet.exp.reload = false;
                bullet.dir = lastKey;
                f = true;
            }
        }

        public override void Update()
        {
            Move();
            velocity = Vector2.Zero;
            if(currentKey==Controls.Left)
            {
                velocity.X = -speed;
                lastKey = currentKey;
            }
            if(currentKey ==Controls.Right)
            {
                velocity.X = speed;
                lastKey = currentKey;
            }
            if(currentKey==Controls.Up)
            {
                velocity.Y = -speed;
                lastKey = currentKey;
            }
            if(currentKey==Controls.Down)
            {
                velocity.Y = speed;
                lastKey = currentKey;
            }
            if(currentKey == Controls.Left || currentKey == Controls.Right || currentKey == Controls.Up || currentKey == Controls.Down)
            {
                base.Start();
            }
            else
            {
                base.Stop();
            }
            base.Update();
            if(f)
            {
                if(lastKey==Controls.Left)
                {
                    bullet.Set(position.X - bullet.width, (position.Y + height/2) - 3);
                }
                else if(lastKey==Controls.Right) 
                {
                    bullet.Set(position.X + width, (position.Y + height / 2) -3);
                }
                else if(lastKey==Controls.Up)
                {
                    bullet.Set(position.X + width / 2 -3, position.Y - bullet.height);
                }
                else if(lastKey==Controls.Down)
                {
                    bullet.Set(position.X + width / 2 -3, position.Y + height);
                }
            }
            bullet.Update(lastKey, f, this);
            if (f) f = false;
            
            
            currentKey = 0;
        }

        public override void Draw()
        {
            bullet.Draw(this);
            if (lastKey == Controls.Left)
            {
                Globals.SpriteBatch.Draw(texture,new Vector2(position.X + width, position.Y), sourceRectangles[frame],Color.White,1.57f,Vector2.Zero,1f,SpriteEffects.FlipVertically,1f);
            }
            else if(lastKey == Controls.Right)
            {
                Globals.SpriteBatch.Draw(texture, new Vector2(position.X,position.Y+height), sourceRectangles[frame], Color.White, -1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
            }
            else if(lastKey == Controls.Down)
            {
                Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
            }
            else if(lastKey == Controls.Up)
            {
                Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 1f);
            }
        }

    }
}
