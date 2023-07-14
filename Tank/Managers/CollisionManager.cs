using System.Linq;
using System.Threading;

namespace Tank
{
    internal class CollisionManager
    {
        public Tank T1;
        public Tank T2;
        public Map M;
        public CollisionManager(Tank T1,Tank T2, Map M)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.M = M;
        }

        public CollisionManager(Tank T,Map M)
        {
            this.T1 = T;
            this.M= M; 
        }

        public void CollisionForTank()
        {

            foreach (var S in M.M)
            {
                if(T1.IsTouchingBottom(S) || T1.IsTouchingTop(S) || T1.IsTouchingLeft(S) || T1.IsTouchingRight(S))
                {
                    T1.position -= T1.velocity * Globals.TotalSeconds;
                    break;
                }
                
            }
            if(T1.position.X<0 || T1.position.X+T1.width> Globals.Window.ClientBounds.Width || T1.position.Y<0 || T1.position.Y+T1.height>Globals.Window.ClientBounds.Height)
            {
                T1.position -= T1.velocity * Globals.TotalSeconds;
            }
            CollisionForBullet(T1.bullet);
            T1.Update();
        }
        public void CollisionForBullet(Bullet b)
        {
           
            
            foreach(var S in M.M)
            {

                if(S.body.Intersects(b.body))
                {
                    b.exp.position = b.position;
                    b.exp.Start();
                    b.exp.Reset();
                    T1.bullet.velocity = Vector2.Zero;
                    S.position = new Vector2(-8, 0);
                    
                    //break;
                }
                
            }
            if(b.position.X < 0 || b.position.X+b.width>Globals.Window.ClientBounds.Width || b.position.Y<0 || b.position.Y+b.height>Globals.Window.ClientBounds.Height)
            {
                
                b.exp.position = b.position;
                b.exp.Start();
                b.velocity= Vector2.Zero;
                
            }
            
        }
    }
}
