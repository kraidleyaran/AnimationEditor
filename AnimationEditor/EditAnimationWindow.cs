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

namespace AnimationEditor
{
    public partial class EditAnimationWindow : Form
    {
        private AnimationGame _textureGame;
        private AnimationGame _frameGame;

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
                            ReturnAnimation = new Animation(newAnimationNameWindow.ReturnName);
                            txtBox_AnimationName.Text = ReturnAnimation.Name;
                            SetAnimationFieldsToDefault();
                            return;
                        case DialogResult.Cancel:
                            this.Close();
                            return;
                        default:
                            return;
                    }
                };
                newAnimationNameWindow.ShowDialog();
                List<string> textureNames = _binaryTextures.Select(texture => texture.Name).ToList();
                SetSpriteSheetWindow setTextureWindow = new SetSpriteSheetWindow(textureNames);
                setTextureWindow.ShowDialog();
                textureName = setTextureWindow.SelectedTexture;
                
            }
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
            _textureGame.Run();

        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (_textureGame.IsActive)
            {
                _textureGame.CloseGame();    
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
            if (listBox_Frames.SelectedItem == null) return;
            int selectedFrame = (int)listBox_Frames.SelectedItem;
            SetFieldsFromFrame(ReturnAnimation.Frames[selectedFrame]);
            if (!_frameGameLoaded)
            {
                LoadFrameGame();    
            }
            lbl_FrameNumber.Text = selectedFrame.ToString();
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
            _frameGame.Run();
        }

        private void btn_AddFrame_Click(object sender, EventArgs e)
        {
            AddFrame(new Frame(new GameRectangle(0,0,0,0)));
            if (!_frameGameLoaded)
            {
                LoadFrameGame();
            }
        }

        private void AddFrame(Frame frame)
        {
            ReturnAnimation.AddFrame(frame);
            listBox_Frames.Items.Add(listBox_Frames.Items.Count + 1);
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

    }
}
