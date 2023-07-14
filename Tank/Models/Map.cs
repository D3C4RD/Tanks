namespace Tank
{
    internal class Map
    {
        public Sprite[] M = new Sprite[1504];
        private Texture2D texture = Globals.Content.Load<Texture2D>("Block");
        public const bool w = true;
        public const bool e = false;
        public const int width =68;
        public const int height =76;
        private bool[,] map = new bool[height,width]
        {
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w, w,w,w,w, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, e,e,e,e, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w},
            {w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w, w,w,w,w}
        };
        public Map()
        {
            int k = 0;
            for(int i=0;i<height;i++)
            {
                for(int j=0;j<width;j++)
                {
                    if (map[i,j])
                    {
                        M[k] = new Sprite(texture, j * texture.Width, i * texture.Height);
                        k++;
                    }
                }
            }
        }
        public void Update()
        {
            foreach(Sprite S in M)
            {
                S.Update();
            }
        }
        public void Draw()
        {
            foreach(Sprite S in M)
            {
                S.Draw();
            }
        }
    }
}
