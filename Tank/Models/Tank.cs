namespace Tank
{
    internal class Tank : Sprite
    {
        private Keys lastKey = Keys.W;
        private Keys currentKey;
        public static readonly Keys left = Keys.A;
        public static readonly Keys right = Keys.D;
        public static readonly Keys up = Keys.W;
        public static readonly Keys down = Keys.S;
        public static readonly Keys fire = Keys.Space;
        public static readonly float speed = 32f;
        private bool f = false;
        
        public Bullet bullet = new Bullet();

        public Tank(Texture2D texture) : base(texture,3,1,0.1f) 
        {
            
        }
        public Tank(Texture2D texture, float x, float y) : base(texture,3,1,0.1f)
        {
            position.X = x;
            position.Y = y;
            body.X = (int)position.X;
            body.Y = (int)position.Y;
        }
        
        private void Move()
        {
            if(Keyboard.GetState().IsKeyDown(left))
            {
                currentKey = left;

            }
            if(Keyboard.GetState().IsKeyDown(right))
            {
                currentKey = right;
            }
            if(Keyboard.GetState().IsKeyDown(up))
            {
                currentKey = up;
            }
            if( Keyboard.GetState().IsKeyDown(down)) 
            {
                currentKey = down;
            }
            if (Keyboard.GetState().IsKeyDown(fire) && bullet.velocity == Vector2.Zero && bullet.exp.reload)
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
            if(currentKey==left)
            {
                velocity.X = -speed;
                lastKey = currentKey;
            }
            if(currentKey ==right)
            {
                velocity.X = speed;
                lastKey = currentKey;
            }
            if(currentKey==up)
            {
                velocity.Y = -speed;
                lastKey = currentKey;
            }
            if(currentKey==down)
            {
                velocity.Y = speed;
                lastKey = currentKey;
            }
            if(currentKey == left || currentKey == right || currentKey == up || currentKey == down)
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
                if(lastKey==left)
                {
                    bullet.Set(position.X - bullet.width, (position.Y + height/2) - 3);
                }
                else if(lastKey==right) 
                {
                    bullet.Set(position.X + width, (position.Y + height / 2) -3);
                }
                else if(lastKey==up)
                {
                    bullet.Set(position.X + width / 2 -3, position.Y - bullet.height);
                }
                else if(lastKey==down)
                {
                    bullet.Set(position.X + width / 2 -3, position.Y + height);
                }
            }
            bullet.Update(lastKey, f);
            if (f) f = false;
            
            
            currentKey = 0;
        }

        public override void Draw()
        {
            bullet.Draw();
            if (lastKey == left)
            {
                Globals.SpriteBatch.Draw(texture,new Vector2(position.X + width, position.Y), sourceRectangles[frame],Color.White,1.57f,Vector2.Zero,1f,SpriteEffects.FlipVertically,1f);
            }
            else if(lastKey == right)
            {
                Globals.SpriteBatch.Draw(texture, new Vector2(position.X,position.Y+height), sourceRectangles[frame], Color.White, -1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
            }
            else if(lastKey == down)
            {
                Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
            }
            else if(lastKey == up)
            {
                Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 1f);
            }
            
            
            
            
        }

    }
}
