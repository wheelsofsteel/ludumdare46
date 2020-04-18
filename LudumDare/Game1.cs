using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MonoTetris2
{
    public class Game1 : Game
    {
        private bool _gameOver;
        GraphicsDeviceManager graphics;
        static public Rectangle WindowBounds;
        private Rectangle _panelBounds;
        SpriteBatch spriteBatch;
        private int _level;
        private int _score;
        private Texture2D _sprite;
        private Texture2D _border;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = (48 * 10);
            graphics.PreferredBackBufferWidth = (48 * 20);
        }

        protected override void Initialize()
        {
            LoadContent();
            base.Initialize();
        }
        

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            /*
            _sprite = Content.Load<Texture2D>("block");
            _border = Content.Load<Texture2D>("border");
            */
            var win = graphics.GraphicsDevice.Viewport.Bounds;
            WindowBounds = new Rectangle(win.Left, win.Top, (48 * 20), (48 * 10));
        }


        private void UpdateScore(int total)
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (_gameOver) return;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            //spriteBatch.Draw(_border, new Vector2(0, 0));
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}