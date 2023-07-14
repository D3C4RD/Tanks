using System.Reflection;

namespace Tank
{
    internal class Bullet : Sprite
    {
        public Keys dir;

        public Explosion exp = new Explosion();
        public Bullet() : base(Globals.Content.Load<Texture2D>("Bullet"),1,1,0.1f,1,-9,0)
        {
           
        }

        public Bullet(float x,float y) : base(Globals.Content.Load<Texture2D>("Bullet"), 1, 1, 0.1f, 1, x, y)
        {
            
        }
        

        public void Update(Keys lastKey,bool fire)
        {
            base.Update();
            if(fire)
            {
                if (lastKey == Tank.left)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.X = -Tank.speed * 4;
                }
                if (lastKey == Tank.right)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.X = Tank.speed * 4;
                }
                if (lastKey == Tank.up)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.Y = -Tank.speed * 4;
                }
                if (lastKey == Tank.down)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.Y = Tank.speed * 4;
                }
            }
            exp.Update();
            

        }

        public void Set(float x,float y)
        {
            position.X = x; 
            position.Y = y;
            body.X = (int) x;
            body.Y = (int) y;
        }

        public override void Draw()
        {
            if(velocity != Vector2.Zero   )
            {
               switch(dir)
               {
                    case Keys.A:
                        Globals.SpriteBatch.Draw(texture, new Vector2(position.X + width, position.Y), sourceRectangles[frame], Color.White, 1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
                        break;
                    case Keys.D:
                        Globals.SpriteBatch.Draw(texture, new Vector2(position.X, position.Y + height), sourceRectangles[frame], Color.White, -1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
                        break;
                    case Keys.W:
                        Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 1f);
                        break;
                    case Keys.S:
                        Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
                        break;
               }               
            }
            exp.Draw();
        }
    }
}
