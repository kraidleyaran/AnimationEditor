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
using GraphicsManagerLib;
using GraphicsManagerLib.Actions.AnimationAction;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AnimationEditor
{
    public partial class PreviewAnimationWindow : Form
    {
        private Animation previewAnimation;
        private AnimationGame previewGame;
        private BinaryTexture animationTexture;
        private GraphicsManager previewManager;

        public PreviewAnimationWindow(Animation animation, BinaryTexture texture)
        {
            InitializeComponent();
            previewAnimation = animation;
            animationTexture = texture;
        }

        private void OnShown(object sender, EventArgs e)
        {
            previewGame = new AnimationGame(pictureBox_AnimationPreview.Handle, this, pictureBox_AnimationPreview, new Vector2(pictureBox_AnimationPreview.Width, pictureBox_AnimationPreview.Height));
            previewManager = new GraphicsManager(previewGame.gameGraphics);
            previewGame.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            previewGame.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                previewGame.gameGraphics.AddTexture(animationTexture.Name, TextureManager.ConvertDataToTexture(animationTexture, previewGame.GraphicsDevice));
                previewGame.gameGraphics.AddDrawable(previewAnimation);
                Vector2 center = StaticMethods.GetCenter(new Vector2(previewAnimation.Frames[1].TextureSource.Width,previewAnimation.Frames[1].TextureSource.Height));
                Vector2 position = StaticMethods.GetDrawPosition(new Vector2(panel_AnimationPreview.Width, panel_AnimationPreview.Height), center);
                previewGame.gameGraphics.AddToDrawList(new DrawParam(previewAnimation.Name, previewAnimation.Name,position, DrawnType.Animation));
                LoopAction loopActon = new LoopAction
                {
                    Name = previewAnimation.Name,
                    Drawable = previewAnimation.Name,
                    Value = true
                };
                previewManager.ExecuteAction(loopActon);

            };
            previewGame.Run();
        }


        private void OnClosed(object sender, FormClosingEventArgs e)
        {
            previewGame.CloseGame();
        }
    }
}
