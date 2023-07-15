
using System;

namespace Tank
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont font;
        private Tank T1;
        private Tank T2;
        private Map M;
        CollisionManager collisionManager;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Globals.Content = Content;
            Globals.Window = Window;
            _graphics.PreferredBackBufferHeight = Map.height * 8;
            _graphics.PreferredBackBufferWidth = Map.width * 8;
            _graphics.ApplyChanges(); 
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.SpriteBatch = _spriteBatch;
            font = Globals.Content.Load<SpriteFont>("File");
            T1 = new Tank(Globals.Content.Load<Texture2D>("Tank1"), 8*32, 32,
                Keys.A,
                Keys.D,
                Keys.W,
                Keys.S,
                Keys.F);
            T2 = new Tank(Globals.Content.Load<Texture2D>("Tank2"), 8 * 32, 16 * 32,
                Keys.Left,
                Keys.Right,
                Keys.Up,
                Keys.Down,
                Keys.NumPad0);
            M = new Map();
            collisionManager = new CollisionManager(T1,T2, M);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            // TODO: Add your update logic here
            Globals.Update(gameTime);
            collisionManager.CollisionForTanks();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            M.Draw();
            T1.Draw();
            T2.Draw();
            _spriteBatch.DrawString(font, T1.body.ToString(), Vector2.Zero, Color.White);
            _spriteBatch.DrawString(font, T1.bullet.body.ToString(), new Vector2(0, 40), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}