using System.Collections.Generic;

namespace Tank
{
    internal class Sprite
    {
        public Vector2 position;
        public readonly Texture2D texture;
        public Vector2 velocity;
        public Rectangle body;
        public int width;
        public int height;

        public int frame;
        public readonly List<Rectangle> sourceRectangles = new List<Rectangle>();
        protected readonly float frameTime;
        protected float frameTimeLeft;
        protected bool active = true;
        protected readonly int frames;

        public Sprite(Texture2D texture,int framesX,int framesY,float frameTime,int row=1)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            frames = framesX;
            var frameWidth = texture.Width / framesX;
            var frameHeight = texture.Height / framesY;
            for(int i=0;i<frames;i++)
            {
                sourceRectangles.Add(new Rectangle(i * frameWidth, (row - 1) * frameHeight, frameWidth, frameHeight));
            }
            position = new Vector2(0, 0);
            velocity = new Vector2(0, 0);
            width = frameWidth;
            height = frameHeight;
            body = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public Sprite(Texture2D texture) : this(texture,1,1,0.1f,1)
        {
            
        }
        public Sprite(Texture2D texture, float x,float y) : this(texture,1,1,0.1f,1)
        {
            position.X = x;
            position.Y = y;
            body.X=(int)position.X;
            body.Y=(int)position.Y;
        }
        public Sprite(Texture2D texture,float x,float y,int width,int height) : this(texture,x,y)
        {
            this.width = width; 
            this.height = height;
        }

        public Sprite(Texture2D texture, int framesX, int framesY, float frameTime, int row,float x,float y) : this(texture,framesX,framesY,frameTime,row)
        {
            position.X = x;
            position.Y = y;
            body.X = (int)position.X;
            body.Y = (int)position.Y;
        }

        public void Stop()
        {
            active = false;
        }

        public void Start()
        {
            active=true;
        }

        public virtual void Reset()
        {
            frame = 0;
            frameTimeLeft = frameTime;
        }

        public virtual void Update()
        {
            position += velocity * Globals.TotalSeconds;
            body.X = (int)position.X;
            body.Y = (int)position.Y;

            if(active)
            {
                frameTimeLeft -= Globals.TotalSeconds;
                if(frameTimeLeft<0)
                {
                    frameTimeLeft += frameTime;
                    frame = (frame + 1) % frames;
                }
            }
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(texture, position, sourceRectangles[frame],Color.White);
        }

        public bool IsTouchingLeft(Sprite S)
        {
            return body.Right + velocity.X*Globals.TotalSeconds > S.body.Left &&
                body.Left < S.body.Left &&
                body.Bottom > S.body.Top &&
                body.Top < S.body.Bottom;
        }

        public bool IsTouchingRight(Sprite S)
        {
            return body.Left +velocity.X*Globals.TotalSeconds < S.body.Right &&
                body.Right > S.body.Right &&
                body.Bottom > S.body.Top &&
                body.Top < S.body.Bottom;
        }
        public bool IsTouchingTop(Sprite S)
        {
            return body.Bottom + velocity.Y * Globals.TotalSeconds > S.body.Top &&
                body.Top < S.body.Top &&
                body.Right > S.body.Left &&
                body.Left < S.body.Right;
        }

        public bool IsTouchingBottom(Sprite S)
        {
            return body.Top + velocity.Y * Globals.TotalSeconds < S.body.Bottom &&
                body.Bottom > S.body.Bottom &&
                body.Right > S.body.Left &&
                body.Left < S.body.Right;
        }
    }
}
