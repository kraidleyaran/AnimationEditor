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

namespace AnimationEditor
{
    public partial class EditAnimationWindow : Form
    {
        private AnimationGame _Game;
        private TextureManager _textureManager;
        private List<string> _animationNames;
        public Animation ReturnAnimation;
        private bool _newAnimation = false;
        public EditAnimationWindow(TextureManager textureManager, List<string> animationNames)
        {
            InitializeComponent();
            _textureManager = textureManager;
            _animationNames = animationNames;
            _newAnimation = true;
        }

        public EditAnimationWindow(TextureManager textureManager, List<string> animationNames, Animation animation)
        {
            InitializeComponent();
            _textureManager = textureManager;
            _animationNames = animationNames;
            ReturnAnimation = animation;
        }

        public void OnShown_Window(object sender, EventArgs e)
        {
            panel_XNA.AutoScroll = true;

            _Game = new AnimationGame(pictureBox_TextureDisplay.Handle, this, pictureBox_TextureDisplay, new Vector2(pictureBox_TextureDisplay.Width, pictureBox_TextureDisplay.Height));
            pictureBox_TextureDisplay.Width = _Game.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_TextureDisplay.Height = _Game.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            _Game.gameForm.GotFocus += delegate(object o, EventArgs args)
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
                SetSpriteSheetWindow setTextureWindow = new SetSpriteSheetWindow(_textureManager.Textures.Keys.ToList());
                setTextureWindow.ShowDialog();
            }
            _Game.Run();

            


        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (_Game.IsActive)
            {
                _Game.CloseGame();    
            }
        }

        private void SetAnimationFieldsToDefault()
        {
            txtBox_Scale.Text = "0";
            txtBox_Depth.Text = "0";
            txtBox_Speed.Text = "0";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CurrentFrame_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
