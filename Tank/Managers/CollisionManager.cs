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

        private void CollisionForTank(Tank T)
        {

            foreach (var S in M.M)
            {
                if(T.IsTouchingBottom(S) || T1.IsTouchingTop(S) || T.IsTouchingLeft(S) || T.IsTouchingRight(S))
                {
                    T.position -= T.velocity * Globals.TotalSeconds;
                    break;
                }
            }
            if(T.position.X<0 || T.position.X+T1.width> Globals.Window.ClientBounds.Width || T.position.Y<0 || T.position.Y+T.height>Globals.Window.ClientBounds.Height)
            {
                T.position -= T.velocity * Globals.TotalSeconds;
            }
            foreach (var S in M.M)
            {

                if (S.body.Intersects(T.bullet.body))
                {
                    T.bullet.exp.position = T.bullet.position;
                    T.bullet.exp.Start();
                    T.bullet.exp.Reset();
                    T.bullet.velocity = Vector2.Zero;
                    S.position = new Vector2(-8, 0);
                    M.Update();
                    //break;
                }

            }
            if (T.bullet.position.X < 0 || T.bullet.position.X + T.bullet.width > Globals.Window.ClientBounds.Width || T.bullet.position.Y < 0 || T.bullet.position.Y + T.bullet.height > Globals.Window.ClientBounds.Height)
            {
                T.bullet.exp.position = T.bullet.position;
                T.bullet.exp.Start();
                T.bullet.velocity = Vector2.Zero;
            }
            T.Update();
        }

        public void CollisionForTanks()
        {
            CollisionForTank(T1);
            CollisionForTank(T2);
            if(T1.bullet.body.Intersects(T2.bullet.body) && T1.bullet.velocity != Vector2.Zero && T2.bullet.velocity != Vector2.Zero)
            {
                T1.bullet.velocity = Vector2.Zero;
                T1.bullet.exp.position = T1.bullet.position;
                T1.bullet.exp.Reset();
                T1.bullet.exp.Start();
                
                T2.bullet.velocity = Vector2.Zero;
                T2.bullet.exp.position = T2.bullet.position;
                T2.bullet.exp.Reset();
                T2.bullet.exp.Start();
            }
           
        }
    }
}
