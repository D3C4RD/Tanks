namespace Tank
{
    internal class Explosion : Sprite
    {
        public bool reload = true;
        public Explosion() : base(Globals.Content.Load<Texture2D>("Explosion"),9,1,0.1f)
        {
            active = false;
        }

        public override void Update()
        {
            base.Update();
            if ( frame == 8)
            {
                Stop();
                Reset();
                reload = true;
            }
        }

        public override void Draw()
        {
            if (frame != 0)
            base.Draw();
        }

    }
}
