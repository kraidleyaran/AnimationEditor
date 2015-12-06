using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameGraphicsLib;

namespace AnimationEditor
{
    public partial class GridFrameTool : Form
    {
        public Dictionary<int, Frame> ReturnFrames = new Dictionary<int, Frame>();
        public GridFrameTool(int defaultHeight, int defaultWidth)
        {
            InitializeComponent();
            txtBox_Height.Text = defaultHeight.ToString();
            txtBox_Width.Text = defaultWidth.ToString();
            SetFieldsToDefault();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!ZeroFieldCheck())
            {
                return;
            }
            int height = Int32.Parse(txtBox_Height.Text);
            int width = Int32.Parse(txtBox_Width.Text);
            int rows = Int32.Parse(txtBox_Rows.Text);
            int columns = Int32.Parse(txtBox_Columns.Text);
            int startPositionX = Int32.Parse(txtBox_StartPositionX.Text);
            int startPositionY = Int32.Parse(txtBox_StartPositionY.Text);
            int widthSpacing = Int32.Parse(txtBox_WidthSpacing.Text);
            int heightSpacing = Int32.Parse(txtBox_HeightSpacing.Text);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int currentFrame = ReturnFrames.Count + 1;
                    int x = ((c * width) + (ReturnFrames.Count * widthSpacing) + startPositionX);
                    int y = ((r * height) + (ReturnFrames.Count * heightSpacing) + startPositionY);
                    Frame frame = new Frame(new GameRectangle(x,y, width, height));
                    ReturnFrames.Add(currentFrame, frame);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SetFieldsToDefault()
        {
            txtBox_Columns.Text = "1";
            txtBox_Rows.Text = "1";
            txtBox_WidthSpacing.Text = "0";
            txtBox_HeightSpacing.Text = "0";
            txtBox_StartPositionX.Text = "0";
            txtBox_StartPositionY.Text = "0";
        }
        private bool ZeroFieldCheck()
        {
            int height = Int32.Parse(txtBox_Height.Text);
            int width = Int32.Parse(txtBox_Width.Text);
            if (height <= 0)
            {
                MessageBox.Show("Height cannot be less than or equal to 0");
                return false;
            }
            if (width <= 0)
            {
                MessageBox.Show("Width cannot be less than or equal to 0");
                return false;
            }           
            int rows = Int32.Parse(txtBox_Rows.Text);
            int columns = Int32.Parse(txtBox_Columns.Text);
            if (rows <= 0)
            {
                MessageBox.Show("Rows cannot be less than or equal to 0");
                return false;
            }
            if (columns <= 0)
            {
                MessageBox.Show("Columns cannot be less than or equal to 0");
                return false;
            }
            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void txtBox_Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            var textBox = sender as TextBox;
            if (textBox != null && ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Numbers_NoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
