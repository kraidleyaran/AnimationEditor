using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using GameGraphicsLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GraphicsManagerLib;
using GraphicsManagerLib.Actions;
using GraphicsManagerLib.Actions.AnimationAction;


namespace AnimationEditor
{
    public partial class EditAnimationWindow : Form
    {
        private AnimationGame _textureGame;
        private AnimationGame _frameGame;

        private GraphicsManager animationManager;

        private TextureManager _textureManager;

        private List<string> _animationNames;

        private List<BinaryTexture> _binaryTextures;

        public Animation ReturnAnimation;

        private bool _newAnimation = false;
        private bool _frameGameLoaded = false;
        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames)
        {
            InitializeComponent();            
            _animationNames = animationNames;
            _newAnimation = true;
            _binaryTextures = binaryTextures;
            
        }

        public EditAnimationWindow(List<BinaryTexture> binaryTextures, List<string> animationNames, Animation animation)
        {
            InitializeComponent();
            _animationNames = animationNames;
            ReturnAnimation = animation;
            _binaryTextures = binaryTextures;
        }

        public void OnShown_Window(object sender, EventArgs e)
        {
            panel_XNA.Controls.Add(pictureBox_TextureDisplay);
            panel_FrameDisplay.Controls.Add(pictureBox_FrameDisplay);
            string textureName = "";
            panel_XNA.AutoScroll = true;

            _textureGame = new AnimationGame(pictureBox_TextureDisplay.Handle, this, pictureBox_TextureDisplay, new Vector2(pictureBox_TextureDisplay.Width, pictureBox_TextureDisplay.Height));
            pictureBox_TextureDisplay.Width = _textureGame.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _textureGame.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _textureGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            if (_newAnimation)
            {
                NewNameWindow newAnimationNameWindow = new NewNameWindow(_animationNames, "Animation");
                newAnimationNameWindow.FormClosed += delegate(object o, FormClosedEventArgs args)
                {
                    switch (newAnimationNameWindow.DialogResult)
                    {
                        case DialogResult.OK:
                            ReturnAnimation = new Animation(newAnimationNameWindow.ReturnName, "", 0, 1, 1, Vector2.Zero, Vector2.Zero, 1);
                            txtBox_AnimationName.Text = ReturnAnimation.Name;
                            SetAnimationFieldsToDefault();
                            return;
                        case DialogResult.Cancel:
                            Close();
                            return;
                        default:
                            return;
                    }
                };
                newAnimationNameWindow.ShowDialog();
                if (newAnimationNameWindow.DialogResult == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
                List<string> textureNames = _binaryTextures.Select(texture => texture.Name).ToList();
                SetSpriteSheetWindow setTextureWindow = new SetSpriteSheetWindow(textureNames);
                setTextureWindow.ShowDialog();
                textureName = setTextureWindow.SelectedTexture;
                ReturnAnimation.Texture = textureName;

            }
            SetAnimationFields(ReturnAnimation);
            _textureGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (BinaryTexture texture in _binaryTextures)
                {
                    _textureGame.gameGraphics.textureManager.Textures.Add(texture.Name, TextureManager.ConvertDataToTexture(texture, _textureGame.gameGraphics.GraphicsManager.GraphicsDevice));
                    Animation textureAnimation = new Animation(texture.Name, texture.Name, 0, 1, 1, new Vector2(0, 0), new Vector2(0, 0), 1);
                    textureAnimation.AddFrame(new Frame(new GameRectangle(0, 0, texture.Width, texture.Height)));
                    _textureGame.gameGraphics.AddDrawable(textureAnimation);
                }
                SetAnimationTexture(textureName);
            };
            SendKeys.Send("{TAB}");
            _textureGame.Run();

        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (_textureGame.IsActive)
            {
                _textureGame.CloseGame();    
            }
            if (_frameGame.IsActive)
            {
                _frameGame.CloseGame();
            }
        }

        private void SetAnimationFieldsToDefault()
        {
            txtBox_Scale.Text = "0";
            txtBox_Depth.Text = "0";
            txtBox_Speed.Text = "0";
        }
        private void listBox_Frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
            _frameGame.gameGraphics.ClearDrawList();
            if (listBox_Frames.SelectedItem == null) return;
            int selectedFrame = (int)listBox_Frames.SelectedItem;
            SetFieldsFromFrame(ReturnAnimation.Frames[selectedFrame]);
            lbl_FrameNumber.Text = selectedFrame.ToString();
            float width = ReturnAnimation.Frames[selectedFrame].TextureSource.Width;
            float height = ReturnAnimation.Frames[selectedFrame].TextureSource.Height;
            Vector2 position = Vector2.Zero;
            if (width <= panel_FrameDisplay.Width || height <= panel_FrameDisplay.Height)
            {
                Vector2 center = GetCenter(new Vector2(((width)*ReturnAnimation.Scale),(height)*ReturnAnimation.Scale));
                position = GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            _frameGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, position,DrawnType.Animation));
            FrameAction frameAction = new FrameAction
            {
                Name = ReturnAnimation.Name,
                Drawable = ReturnAnimation.Name,
                Value = selectedFrame
            };
            StatusAction statusAction = new StatusAction
            {
                Name = ReturnAnimation.Name,
                Drawable = ReturnAnimation.Name,
                Value = AnimationStatus.Paused
            };

            animationManager.ExecuteAction(statusAction);
            animationManager.ExecuteAction(frameAction);

        }

        private void LoadFrameGame()
        {
            _frameGame = new AnimationGame(pictureBox_FrameDisplay.Handle, this, pictureBox_FrameDisplay, new Vector2(pictureBox_FrameDisplay.Width, pictureBox_FrameDisplay.Height));
            pictureBox_TextureDisplay.Width = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _frameGame.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _frameGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            _frameGameLoaded = true;
            _frameGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (BinaryTexture texture in _binaryTextures)
                {
                    _frameGame.gameGraphics.textureManager.Textures.Add(texture.Name, TextureManager.ConvertDataToTexture(texture, _frameGame.gameGraphics.GraphicsManager.GraphicsDevice));
                }
            };

            _frameGame.gameGraphics.AddDrawable(ReturnAnimation);
            animationManager = new GraphicsManager(_frameGame.gameGraphics);
            _frameGame.Run();
        }

        private void btn_AddFrame_Click(object sender, EventArgs e)
        {
            AddFrame(new Frame(new GameRectangle(0,0,1,1)));
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }

        private void AddFrame(Frame frame)
        {
            ReturnAnimation.AddFrame(frame);
            if (_frameGame != null && _frameGame.gameGraphics.DoesDrawableExist(ReturnAnimation.Name))
            {
                Animation drawAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
                drawAnimation.AddFrame(frame);
                _frameGame.gameGraphics.SetLoadedDrawn(drawAnimation);
            }
            listBox_Frames.Items.Add(listBox_Frames.Items.Count + 1);
            lbl_CurrentFrameCount.Text = ReturnAnimation.framecount.ToString();
        }
        private bool RemoveFrame(int frame)
        {
            if (frame > ReturnAnimation.framecount) return false;
            listBox_Frames.Items.Remove(frame);
            return ReturnAnimation.RemoveFrame(frame);
        }

        private void SetFieldsFromFrame(Frame frame)
        {
            txtBox_FrameX.Text = frame.TextureSource.X.ToString();
            txtBox_FrameY.Text = frame.TextureSource.Y.ToString();
            txtBox_FrameWidth.Text = frame.TextureSource.Width.ToString();
            txtBox_FrameHeight.Text = frame.TextureSource.Height.ToString();
        }

        private void SetAnimationTexture(string textureName)
        {
            _textureGame.gameGraphics.ClearDrawList();
            _textureGame.gameGraphics.AddToDrawList(new DrawParam(textureName, textureName, new Vector2(0, 0), DrawnType.Animation));
            lbl_TextureName.Text = textureName;
        }

        private void SetAnimationFields(Animation animation)
        {
            txtBox_AnimationName.Text = animation.Name;
            txtBox_Depth.Text = animation.Depth.ToString();
            txtBox_Scale.Text = animation.Scale.ToString();
            txtBox_Speed.Text = animation.FramesPerSecond.ToString();
        }

        private void btn_SetFrame_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtBox_FrameX.Text);
            int y = Int32.Parse(txtBox_FrameY.Text);
            int width = Int32.Parse(txtBox_FrameWidth.Text);
            int height = Int32.Parse(txtBox_FrameHeight.Text);
            int frame = Int32.Parse(lbl_FrameNumber.Text);
            Frame setFrame = new Frame(new GameRectangle(x, y, width, height));
            ReturnAnimation.SetFrame(frame, setFrame);
            Animation drawnAnimation = _frameGame.gameGraphics.GetDrawAnimation(ReturnAnimation.Name);
            drawnAnimation.SetFrame(frame, setFrame);
            _frameGame.gameGraphics.SetLoadedDrawn(drawnAnimation);
            Vector2 position = Vector2.Zero;
            if (width <= panel_FrameDisplay.Width || height <= panel_FrameDisplay.Height)
            {
                Vector2 center = GetCenter(new Vector2(((width)*ReturnAnimation.Scale),(height)*ReturnAnimation.Scale));
                position = GetDrawPosition(new Vector2(panel_FrameDisplay.Width, panel_FrameDisplay.Height), center);
            }
            _frameGame.gameGraphics.UpdateDrawPosition(new DrawParam(drawnAnimation.Name, drawnAnimation.Name, position,DrawnType.Animation));
        }
        private Vector2 GetCenter(Vector2 box)
        {
            return new Vector2(box.X / 2, box.Y / 2);
        }

        private Vector2 GetDrawPosition(Vector2 boxLimits, Vector2 center)
        {
            return new Vector2((boxLimits.X / 2) - center.X, (boxLimits.Y / 2) - center.Y);
        }

    }
}
