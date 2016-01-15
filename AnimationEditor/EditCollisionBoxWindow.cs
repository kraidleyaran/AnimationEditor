using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using GameGraphicsLib;
using GameGraphicsLib.DrawableShapes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AnimationEditor
{
    public partial class EditCollisionBoxWindow : Form
    {
        private AnimationGame collisionGame;
        public Animation ReturnAnimation;
        private BinaryTexture currentTexture;
        public EditCollisionBoxWindow(Animation animation, BinaryTexture animationTexture)
        {
            InitializeComponent();
            ReturnAnimation = animation;
            currentTexture = animationTexture;
            Text = ReturnAnimation.Name + " Collision Box";
            txtBox_X.Text = ReturnAnimation.Collidable.X.ToString();
            txtBox_Y.Text = ReturnAnimation.Collidable.Y.ToString();
            txtBox_Width.Text = ReturnAnimation.Collidable.Width.ToString();
            txtBox_Height.Text = ReturnAnimation.Collidable.Height.ToString();
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void EditCollisionBoxWindow_Shown(object sender, EventArgs e)
        {
            collisionGame = new AnimationGame(pictureBox_CollisionBox.Handle, this, pictureBox_CollisionBox, new Vector2(pictureBox_CollisionBox.Width, pictureBox_CollisionBox.Height));

            collisionGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                DrawnRectangle frameRectangle = new DrawnRectangle
                {
                    Name = ReturnAnimation.Name + " collision box",
                    X = ReturnAnimation.X + ReturnAnimation.Collidable.X,
                    Y = ReturnAnimation.X + ReturnAnimation.Collidable.Y,
                    Size = new Size(Int32.Parse(ReturnAnimation.Collidable.Width.ToString()), Int32.Parse(ReturnAnimation.Collidable.Width.ToString())),
                    Thickness = 1,
                    Color = GameGraphics.ConvertSystemColorToXNA(System.Drawing.Color.Fuchsia)
                };
                collisionGame.gameGraphics.AddTexture(currentTexture.Name,TextureManager.ConvertDataToTexture(currentTexture, collisionGame.GraphicsDevice));
                collisionGame.gameGraphics.AddDrawable(frameRectangle);
                collisionGame.gameGraphics.AddDrawable(ReturnAnimation);
                Vector2 animationPos = new Vector2((panel_CollisionBox.Width /2) - (ReturnAnimation.Frames[ReturnAnimation.Frame].TextureSource.Width / 2),(panel_CollisionBox.Height /2) - (ReturnAnimation.Frames[ReturnAnimation.Frame].TextureSource.Height / 2) );
                collisionGame.gameGraphics.AddToDrawList(new DrawParam(ReturnAnimation.Name, ReturnAnimation.Name, animationPos, DrawnType.Animation));
                collisionGame.gameGraphics.AddToDrawList(new DrawParam(frameRectangle.Name, frameRectangle.Name, new Vector2(animationPos.X + frameRectangle.X, animationPos.Y + frameRectangle.Y), DrawnType.Shape));                
            };
            collisionGame.Run();
        }

        private void txtBox_Numbers_NoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LeaveTextBoxEvent(object sender, EventArgs e)
        {
            SaveCollisionBoxToAnimation();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveCollisionBoxToAnimation();
        }

        private void SaveCollisionBoxToAnimation()
        {
            ReturnAnimation.Collidable.X = float.Parse(txtBox_X.Text);
            ReturnAnimation.Collidable.Y = float.Parse(txtBox_Y.Text);
            ReturnAnimation.Collidable.Width = float.Parse(txtBox_Width.Text);
            ReturnAnimation.Collidable.Height = float.Parse(txtBox_Height.Text);
            Vector2 animationPos = new Vector2((panel_CollisionBox.Width / 2) - (ReturnAnimation.Frames[ReturnAnimation.Frame].TextureSource.Width / 2), (panel_CollisionBox.Height / 2) - (ReturnAnimation.Frames[ReturnAnimation.Frame].TextureSource.Height / 2));
            DrawnRectangle frameRectangle = new DrawnRectangle
            {
                Name = ReturnAnimation.Name + " collision box",
                X = animationPos.X + ReturnAnimation.Collidable.X,
                Y = animationPos.Y + ReturnAnimation.Collidable.Y,
                Size = new Size(Int32.Parse(ReturnAnimation.Collidable.Width.ToString()), Int32.Parse(ReturnAnimation.Collidable.Height.ToString())),
                Thickness = 1,
                Color = GameGraphics.ConvertSystemColorToXNA(System.Drawing.Color.Fuchsia)
            };
            collisionGame.gameGraphics.SetLoadedDrawn(frameRectangle);
        }

        private void EditCollisionBoxWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (collisionGame != null)
            {
                collisionGame.CloseGame();
            }
        }
    }
}
