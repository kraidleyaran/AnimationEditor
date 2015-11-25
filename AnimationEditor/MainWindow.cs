using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using Microsoft.Xna.Framework;

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
            SpriteSheetManagerWindow spriteManagerWindow = new SpriteSheetManagerWindow(Game.gameGraphics.textureManager);

            spriteManagerWindow.ShowDialog();
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
