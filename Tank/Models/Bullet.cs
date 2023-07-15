using System.Net.Mime;
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
        

        public void Update(Keys lastKey,bool fire,Tank T)
        {
            base.Update();
            if(fire)
            {
                if (lastKey == T.Controls.Left)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.X = -Tank.speed * 4;
                }
                if (lastKey == T.Controls.Right)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.X = Tank.speed * 4;
                }
                if (lastKey == T.Controls.Up)
                {
                    this.velocity = Vector2.Zero;
                    this.velocity.Y = -Tank.speed * 4;
                }
                if (lastKey == T.Controls.Down)
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

        public void Draw(Tank T)
        {
            if(velocity != Vector2.Zero   )
            {
               if(dir == T.Controls.Left)
                    Globals.SpriteBatch.Draw(texture, new Vector2(position.X + width, position.Y), sourceRectangles[frame], Color.White, 1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
               if(dir == T.Controls.Right) 
                    Globals.SpriteBatch.Draw(texture, new Vector2(position.X, position.Y + height), sourceRectangles[frame], Color.White, -1.57f, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);
               if(dir == T.Controls.Up)
                    Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 1f);
               if(dir == T.Controls.Down)
                    Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame], Color.White, 0, Vector2.Zero, 1f, SpriteEffects.FlipVertically, 1f);   
            }
            exp.Draw();
        }
    }
}
