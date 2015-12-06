namespace AnimationEditor
{
    partial class SetFrameNumber
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
            this.txtBox_FrameNumber = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_FrameNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_FrameNumber
            // 
            this.txtBox_FrameNumber.Location = new System.Drawing.Point(99, 43);
            this.txtBox_FrameNumber.Name = "txtBox_FrameNumber";
            this.txtBox_FrameNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameNumber.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(29, 92);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(133, 92);
            this.btn_Cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_FrameNumber
            // 
            this.lbl_FrameNumber.AutoSize = true;
            this.lbl_FrameNumber.Location = new System.Drawing.Point(26, 46);
            this.lbl_FrameNumber.Name = "lbl_FrameNumber";
            this.lbl_FrameNumber.Size = new System.Drawing.Size(67, 13);
            this.lbl_FrameNumber.TabIndex = 3;
            this.lbl_FrameNumber.Text = "Set Frame to";
            // 
            // SetFrameNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 127);
            this.Controls.Add(this.lbl_FrameNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtBox_FrameNumber);
            this.Name = "SetFrameNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Frame Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_FrameNumber;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_FrameNumber;
    }
}