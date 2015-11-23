namespace AnimationEditor
{
    partial class SetSpriteSheetWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_TextureNames = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_SelectSpriteSHeet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_TextureNames
            // 
            this.combo_TextureNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TextureNames.FormattingEnabled = true;
            this.combo_TextureNames.Location = new System.Drawing.Point(28, 46);
            this.combo_TextureNames.Name = "combo_TextureNames";
            this.combo_TextureNames.Size = new System.Drawing.Size(292, 21);
            this.combo_TextureNames.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(67, 86);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(197, 86);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_SelectSpriteSHeet
            // 
            this.lbl_SelectSpriteSHeet.AutoSize = true;
            this.lbl_SelectSpriteSHeet.Location = new System.Drawing.Point(118, 20);
            this.lbl_SelectSpriteSHeet.Name = "lbl_SelectSpriteSHeet";
            this.lbl_SelectSpriteSHeet.Size = new System.Drawing.Size(101, 13);
            this.lbl_SelectSpriteSHeet.TabIndex = 3;
            this.lbl_SelectSpriteSHeet.Text = "Select Sprite Sheet:";
            // 
            // SetSpriteSheetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 135);
            this.Controls.Add(this.lbl_SelectSpriteSHeet);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.combo_TextureNames);
            this.MaximumSize = new System.Drawing.Size(372, 173);
            this.MinimumSize = new System.Drawing.Size(372, 173);
            this.Name = "SetSpriteSheetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Sprite Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_TextureNames;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_SelectSpriteSHeet;
    }
}