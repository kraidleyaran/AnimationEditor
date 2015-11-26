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
using GraphicsManagerLib;
using GraphicsManagerLib.Actions.AnimationAction;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Cyotek.Windows.Forms;

namespace AnimationEditor
{
    public partial class SpriteSheetManagerWindow : Form
    {
        private bool texturesLoaded = false;
        private GraphicsManager graphicsManager;
        public Dictionary<string, BinaryTexture> ReturnTextures = new Dictionary<string, BinaryTexture>();
        public SpriteSheetManagerWindow(List<BinaryTexture> textures)
        {
            InitializeComponent();
            this.Focus();
            panel_SpriteSheetPreview.Controls.Add(pictureBox_SpriteSheetPreview);
            foreach (BinaryTexture texture in textures)
            {
                ReturnTextures.Add(texture.Name, texture);
            }

        }
        
        private Texture2D selectedTexture;



        public TextureGame Game { get; set; }

        private void OnShown(object sender, EventArgs e)
        {
            panel_SpriteSheetPreview.AutoScroll = true;

            this.Game = new TextureGame(this.pictureBox_SpriteSheetPreview.Handle, this, this.pictureBox_SpriteSheetPreview, new Vector2(this.pictureBox_SpriteSheetPreview.Width, this.pictureBox_SpriteSheetPreview.Height));
            graphicsManager = new GraphicsManager(Game.gameGraphics);

            pictureBox_SpriteSheetPreview.Width = Game.gameGraphics.GraphicsManager.PreferredBackBufferWidth;
            pictureBox_SpriteSheetPreview.Height = Game.gameGraphics.GraphicsManager.PreferredBackBufferHeight;

            Game.gameForm.GotFocus += delegate(object o, EventArgs args)
            {
                this.Focus();
            };
            Game.gameGraphics.GraphicsManager.DeviceCreated += delegate(object o, EventArgs args)
            {
                foreach (KeyValuePair<string, BinaryTexture> pair in ReturnTextures)
                {
                    Game.gameGraphics.textureManager.Textures.Add(pair.Key, TextureManager.ConvertDataToTexture(pair.Value, Game.gameGraphics.GraphicsManager.GraphicsDevice));
                    AddTextureLabelToList(pair.Value.Name);
                    Animation textureAnimation = new Animation(pair.Value.Name, pair.Value.Name, 0, 1, 1, new Vector2(0, 0), new Vector2(0, 0), 1);
                    textureAnimation.AddFrame(new Frame(new GameRectangle(0, 0, pair.Value.Width, pair.Value.Height)));
                    Game.gameGraphics.AddDrawable(textureAnimation);
                }
            };
            this.Game.Run();

        }

        private void AddTextureLabelToList(string textureName)
        {
            listBox_SpriteSheets.Items.Add(textureName);
        }

        private void AddTextureToList(Texture2D texture)
        {
            AddTextureLabelToList(texture.Name);
            Game.gameGraphics.textureManager.Textures.Add(texture.Name, texture);
            Animation textureAnimation = new Animation(texture.Name, texture.Name, 0, 1, 1, new Vector2(0,0), new Vector2(0,0),1);
            textureAnimation.AddFrame(new Frame(new GameRectangle(0, 0, texture.Width, texture.Height)));
            Game.gameGraphics.AddDrawable(textureAnimation);
        }

        private void RemoveTextureFromList(string textureName)
        {
            if (selectedTexture.Name == textureName)
            {
                Game.gameGraphics.RemoveFromDrawList(textureName);
            }
            listBox_SpriteSheets.Items.Remove(textureName);
            Game.gameGraphics.textureManager.Textures.Remove(textureName);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.Filter = "PNG Files (.png)| *.png|All Files (*.*)| *.*";
            DialogResult result = getImage.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Texture2D newTexture = Game.gameGraphics.LoadTexture(getImage.FileName);
                    if (newTexture != null)
                    {
                        List<string> textureNames = Game.gameGraphics.textureManager.Textures.Keys.ToList();
                        NewNameWindow spriteSheetName = new NewNameWindow(textureNames, "Sprite Sheet");
                        spriteSheetName.ShowDialog();
                        switch (spriteSheetName.DialogResult)
                        {
                            case DialogResult.OK:
                                if (newTexture.Width > 4096 || newTexture.Height > 4096)
                                {
                                    throw new Exception("Sprite sheets cannot be bigger than 4096 x 4096 pixels");
                                }
                                newTexture.Name = spriteSheetName.ReturnName;
                                AddTextureToList(newTexture);
                                Animation textureAnimation = new Animation(newTexture.Name,
                                    newTexture.Name, 0, 1, 1, new Vector2(0, 0), new Vector2(0, 0), 1);
                                /*{
                                    IsLoop = true
                                };
                                 */
                                textureAnimation.AddFrame(new Frame(new GameRectangle(0, 0, newTexture.Width, newTexture.Height )));
                                Game.gameGraphics.AddDrawable(textureAnimation);
                                break;
                            default:
                                return;
                        }
                    }
                    break;
                default:
                    return;
            }

        }

        private string GetUnusedTextureName(string name, int counter)
        {
            while (true)
            {
                if (!Game.gameGraphics.textureManager.Textures.ContainsKey(name + counter)) return name + counter;
                counter++;
            }

        }

        private void SpriteManagerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnTextures.Clear();
            ReturnTextures = new Dictionary<string, BinaryTexture>();
            foreach (KeyValuePair<string, Texture2D> pair in Game.gameGraphics.textureManager.Textures)
            {
                ReturnTextures.Add(pair.Key, new BinaryTexture(pair.Value) );
            }
            Game.CloseGame();
        }

        private void listBox_SpriteSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_SpriteSheets.SelectedItem == null) return;
            
            Game.gameGraphics.ClearDrawList();
            
            panel_SpriteSheetPreview.AutoScroll = true;
            
            string selectedItem = listBox_SpriteSheets.SelectedItem.ToString();
            int height = Game.gameGraphics.textureManager.Textures[selectedItem].Height;
            int width = Game.gameGraphics.textureManager.Textures[selectedItem].Width;
            Game.SetGameHeight(height);
            Game.SetGameWidth(width);
            panel_SpriteSheetPreview.AutoScrollMinSize = new Size(Game.gameGraphics.textureManager.Textures[listBox_SpriteSheets.SelectedItem.ToString()].Width, Game.gameGraphics.textureManager.Textures[listBox_SpriteSheets.SelectedItem.ToString()].Height);
            pictureBox_SpriteSheetPreview.Location = new System.Drawing.Point(0, 0);

            lbl_HeightValue.Text = height.ToString();
            lbl_WidthValue.Text = width.ToString();
            txtBox_SheetName.Text = selectedItem;


            Game.gameGraphics.AddToDrawList(new DrawParam(selectedItem, selectedItem, new Vector2(0, 0), DrawnType.Animation));
            LoopAction loopAnimation = new LoopAction
            {
                Name = "loop " + selectedItem,
                Drawable = selectedItem,
                Value = true
            };
            graphicsManager.ExecuteAction(loopAnimation);
            selectedTexture = Game.gameGraphics.textureManager.Textures[selectedItem];
        }

        private void btn_TransparentColor_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorDialog = new ColorPickerDialog();
            DialogResult result = colorDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Texture2D newTexture = BinaryTexture.RemoveTransparentColor(selectedTexture, GameGraphics.ConvertSystemColorToXNA(colorDialog.Color));
                    Game.gameGraphics.textureManager.Textures[newTexture.Name] = newTexture;
                    selectedTexture = newTexture;
                    return;
                default:
                    return;
            }
        }

        private void btn_BackgroundColor_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorDialog = new ColorPickerDialog();
            DialogResult result = colorDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Game.BackgroundColor = GameGraphics.ConvertSystemColorToXNA(colorDialog.Color);
                    return;
                default:
                    return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (selectedTexture.Name != txtBox_SheetName.Text)
            {
                if (Game.gameGraphics.textureManager.Textures.ContainsKey(txtBox_SheetName.Text))
                {
                    MessageBox.Show(txtBox_SheetName.Text + " Sprite Sheet name already exists, try again");
                    return;
                }
                RemoveTextureFromList(selectedTexture.Name);

                selectedTexture.Name = txtBox_SheetName.Text;

                AddTextureToList(selectedTexture);
            }
            else
            {
                Game.gameGraphics.textureManager.Textures[selectedTexture.Name] = selectedTexture;
            }
            
        }
    }
}
