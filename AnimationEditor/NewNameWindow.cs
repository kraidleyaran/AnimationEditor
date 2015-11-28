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
    public partial class NewNameWindow : Form
    {
        private List<string> _currentNames;
        private string _objectTypeName;
        public NewNameWindow(List<string> currentNames, string objectTypeName)
        {
            InitializeComponent();
            _currentNames = currentNames;
            _objectTypeName = objectTypeName;
            Text = _objectTypeName + " Name";
            lbl_EnterName.Text = "Enter " + _objectTypeName + " name";
        }

        public string ReturnName { get; set; }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ReturnName = txtBox_Name.Text;
            if (_currentNames.Contains(ReturnName))
            {
                DialogResult result = MessageBox.Show(_objectTypeName + " name already exists", _objectTypeName + " name " + ReturnName + " already exists, try again", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        txtBox_Name.SelectedText = ReturnName;
                        break;
                    case DialogResult.Cancel:
                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                }
                
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
