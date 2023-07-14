using Microsoft.Xna.Framework.Content;

namespace Tank
{
    internal class Globals
    {
        public static float TotalSeconds { get; set; }
        public static ContentManager Content { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }

        public static GameWindow Window { get; set; }
        public static void Update(GameTime gt)
        {
            TotalSeconds = (float)gt.ElapsedGameTime.TotalSeconds;
        }
    }
}
