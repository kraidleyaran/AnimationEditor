using System;
using System.Windows.Forms;
using GameGraphicsLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace AnimationEditor.GameClasses
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class AnimationGame : Game
    {
        public GameGraphics gameGraphics;
        public Control gameForm;
        public IntPtr DrawingSurface;
        private Form ParentForm;
        private PictureBox PictureBox;

        public AnimationGame(IntPtr drawingSurface, Form parentForm, PictureBox pictureBox, Vector2 size)
        {
            DrawingSurface = drawingSurface;
            ParentForm = parentForm;
            PictureBox = pictureBox;

            gameGraphics = new GameGraphics(this);
            int width = 0;
            int height = 0;
            width += pictureBox.Width;
            height += pictureBox.Height;
            gameGraphics.GraphicsManager.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            gameGraphics.GraphicsManager.PreferredBackBufferWidth = width;
            gameGraphics.GraphicsManager.PreferredBackBufferHeight = height;

            gameForm = Control.FromHandle(Window.Handle);
            Mouse.WindowHandle = drawingSurface;
            gameForm.VisibleChanged += delegate(object sender, EventArgs args)
            {
                gameForm.Visible = false;
            };
            BackgroundColor = Color.CornflowerBlue;
        }

        public Color BackgroundColor { get; set; }
        private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = DrawingSurface;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsFixedTimeStep = false;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            gameGraphics.SetSpriteBatch();

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            gameGraphics.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(BackgroundColor);
            gameGraphics.SpriteBatch.Begin();
            gameGraphics.Draw();
            gameGraphics.SpriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public void SetGameWidth(int width)
        {
            gameGraphics.GraphicsManager.PreferredBackBufferWidth = width;
        }

        public void SetGameHeight(int height)
        {
            gameGraphics.GraphicsManager.PreferredBackBufferHeight = height;
        }

        public void CloseGame()
        {
            this.Exit();
            this.Dispose();
            this.gameForm.Dispose();
        }

    }
}
