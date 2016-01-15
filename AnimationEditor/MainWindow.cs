using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimationEditor.GameClasses;
using FileDialogLib;
using FileDialogLib.Objects;
using GameArchiveLib;
using GameGraphicsLib;
using GraphicsManagerLib;
using GraphicsManagerLib.Actions.AnimationAction;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AnimationEditor
{
    public partial class MainWindow : Form
    {
        private List<BinaryTexture> binaryTextures;
        
        private string SelectedAnimation = "";
        
        private bool fileLoaded = false;
        private string filePath = "";
        private bool fileChanged = false;
        private string defaultFileName = "New";

        private GameArchive gameArchive = GameArchive.Instance;
        public GraphicsManager graphicsManager;
        private GameFileDialog gameFileDialog = new GameFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            binaryTextures = new List<BinaryTexture>();
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
        }

        private void spriteSheetManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<BinaryTexture> textures = Game.gameGraphics.textureManager.Textures.Select(pair => new BinaryTexture(pair.Value)).ToList();
            SpriteSheetManagerWindow spriteManagerWindow = new SpriteSheetManagerWindow(textures);
            //SpriteSheetManagerWindow spriteManagerWindow = new SpriteSheetManagerWindow(Game);
            spriteManagerWindow.ShowDialog();
            Game.gameGraphics.textureManager.ClearAllTextures();
            binaryTextures.Clear();
            binaryTextures = new List<BinaryTexture>();
            foreach (KeyValuePair<string, BinaryTexture> pair in spriteManagerWindow.ReturnTextures)
            {
                if (Game.gameGraphics.textureManager.Textures.ContainsKey(pair.Key)) continue;
                Game.gameGraphics.textureManager.Textures.Add(pair.Key, TextureManager.ConvertDataToTexture(pair.Value, Game.gameGraphics.GraphicsManager.GraphicsDevice));
                binaryTextures.Add(pair.Value);
            }
            fileChanged = true;
        } 

        public AnimationGame Game { get; set; }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileChanged)
            Game.CloseGame();
            this.Dispose();
        }

        private void btn_NewAnimation_Click(object sender, EventArgs e)
        {
            EditAnimationWindow animationWindow = new EditAnimationWindow(binaryTextures,Game.gameGraphics.GetDrawnNames());
            switch (animationWindow.ShowDialog())
            {
                case DialogResult.OK:
                    Game.gameGraphics.AddDrawable(animationWindow.ReturnAnimation);
                    listBox_Animations.Items.Add(animationWindow.ReturnAnimation.Name);
                    fileChanged = true;
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }

        private void MainWindow_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (listBox_Animations.SelectedItem == null)
            {
                MessageBox.Show("Must have an animation selected", "No Animation Selected", MessageBoxButtons.OK);
                return;
            }
            Animation animation = Game.gameGraphics.GetAnimation(SelectedAnimation);
            EditAnimationWindow animationWindow = new EditAnimationWindow(binaryTextures, Game.gameGraphics.GetDrawnNames(), animation);
            switch (animationWindow.ShowDialog())
            {
                case DialogResult.OK:
                    if (string.IsNullOrEmpty(SelectedAnimation)) return;
                    if (SelectedAnimation == animationWindow.ReturnAnimation.Name)
                    {
                        listBox_Animations.SelectedItem = null;
                        Game.gameGraphics.ClearDrawList();
                    }
                    Game.gameGraphics.SetDrawable(animationWindow.ReturnAnimation);
                    Game.gameGraphics.SetLoadedDrawn(animationWindow.ReturnAnimation, animationWindow.ReturnAnimation.Name);
                    fileChanged = true;
                    break;
                case DialogResult.Cancel:
                    return;
            }

        }

        private void listBox_Animations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Animations.SelectedItem == null)
            {
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
                return;
            }
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            SelectedAnimation = listBox_Animations.SelectedItem.ToString();
            Animation animation = Game.gameGraphics.GetAnimation(SelectedAnimation);
            if (animation.FrameCount > 0)
            {
                Vector2 center = StaticMethods.GetCenter(new Vector2(animation.Frames[1].TextureSource.Width, animation.Frames[1].TextureSource.Height));
                Vector2 position = StaticMethods.GetDrawPosition(new Vector2(panel_AnimationPreview.Width, panel_AnimationPreview.Height), center);
                Game.gameGraphics.ClearDrawList();
                Game.gameGraphics.AddToDrawList(new DrawParam(SelectedAnimation, SelectedAnimation, position, DrawnType.Animation));
                LoopAction loopAction = new LoopAction
                {
                    Name = "Loop current animation",
                    Drawable = animation.Name,
                    Value = true
                };
                graphicsManager.ExecuteAction(loopAction);  
            }


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Animations.SelectedItem == null) return;
            Game.gameGraphics.RemoveFromDrawList(SelectedAnimation);
            Game.gameGraphics.RemoveDrawable(SelectedAnimation);
            listBox_Animations.Items.Remove(SelectedAnimation);
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileLoaded)
            {
                SaveAs();
                return;
            }
            gameArchive.SaveData(Game.gameGraphics.SaveData(), filePath);
            fileChanged = false;
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Response response = SaveAs();
            filePath = response.DirectoryPath;
        }

        private Response SaveAs()
        {
            Response response = gameFileDialog.SaveFile<GraphicsData>(Game.gameGraphics.SaveData(), "agd", "Graphics", defaultFileName);
            if (response.ValidData)
            {
                MessageBox.Show("File succesfuly saved", "File saved", MessageBoxButtons.OK);
            }
            fileChanged = false;
            return response;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Response response = gameFileDialog.LoadFile<GraphicsData>("agd", "Graphics");
            if (!response.ValidData) return;
            
            LoadGraphicsData((GraphicsData)response.Data);
            filePath = response.DirectoryPath;
            defaultFileName = response.FileName;
            MessageBox.Show("File succesfully loaded", "File loadead", MessageBoxButtons.OK);
        }

        private void LoadGraphicsData(GraphicsData data)
        {
            foreach (BinaryTexture texture in data.AnimationTextures)
            {
                Game.gameGraphics.textureManager.ClearAllTextures();
                Game.gameGraphics.AddTexture(texture.Name,TextureManager.ConvertDataToTexture(texture, Game.gameGraphics.GraphicsManager.GraphicsDevice));
                binaryTextures.Add(texture);
            }
            listBox_Animations.Items.Clear();
            foreach (IDrawn drawObject in data.DrawnObjects)
            {
                switch (drawObject.DrawnType)
                {
                    case DrawnType.Animation:
                        Game.gameGraphics.ClearAnimationList();
                        Game.gameGraphics.AddDrawable(drawObject);
                        listBox_Animations.Items.Add(drawObject.Name);
                        break;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Game = new AnimationGame(picBox_AnimationPreview.Handle, this, picBox_AnimationPreview, new Vector2(0, 0));
            Game.gameGraphics.GraphicsManager.DeviceCreated += delegate(object gsender, EventArgs gargs)
            {
                graphicsManager = new GraphicsManager(Game.gameGraphics);
            };
            Game.Run();
        }
    }
}
