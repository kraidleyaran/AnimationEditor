using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationEditor
{
    public partial class SetFrameNumber : Form
    {
        public int ReturnFrameNumber;
        public SetFrameNumber()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ReturnFrameNumber = Int32.Parse(txtBox_FrameNumber.Text);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
