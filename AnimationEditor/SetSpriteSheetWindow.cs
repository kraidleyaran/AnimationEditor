using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimationEditor
{
    public partial class SetSpriteSheetWindow : Form
    {
        public SetSpriteSheetWindow(List<string> textureNames)
        {
            InitializeComponent();
            SetTextureList(textureNames);
        }
        public SetSpriteSheetWindow(List<string> textureNames, string defaultTexture)
        {
            InitializeComponent();
            SetTextureList(textureNames);
            if (!textureNames.Contains(defaultTexture))
            {
                throw new Exception("Invalid default texture name: " + defaultTexture);
            }
            combo_TextureNames.SelectedItem = defaultTexture;
        }

        private void SetTextureList(List<string> names)
        {
            foreach (string name in names)
            {
                combo_TextureNames.Items.Add(name);
            }
        }
    }
}
