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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void spriteSheetManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<BinaryTexture> textures = Game.gameGraphics.textureManager.Textures.Select(pair => new BinaryTexture(pair.Value)).ToList();
            SpriteSheetManagerWindow spriteManagerWindow = new SpriteSheetManagerWindow(textures);
            spriteManagerWindow.ShowDialog();
            foreach (KeyValuePair<string, BinaryTexture> pair in spriteManagerWindow.ReturnTextures)
            {
                Game.gameGraphics.textureManager.Textures.Add(pair.Key, TextureManager.ConvertDataToTexture(pair.Value, Game.gameGraphics.GraphicsManager.GraphicsDevice));
            }
        }

        public TextureGame Game { get; set; }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.CloseGame();
        }

        private void animationEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewAnimation_Click(object sender, EventArgs e)
        {
            EditAnimationWindow animationWindow = new EditAnimationWindow(Game.gameGraphics.textureManager, Game.gameGraphics.GetDrawnNames());
            animationWindow.ShowDialog();
        }
    }
}
