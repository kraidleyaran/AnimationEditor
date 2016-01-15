namespace AnimationEditor
{
    partial class EditCollisionBoxWindow
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
            this.panel_CollisionBox = new System.Windows.Forms.Panel();
            this.pictureBox_CollisionBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_X = new System.Windows.Forms.TextBox();
            this.txtBox_Y = new System.Windows.Forms.TextBox();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.panel_CollisionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CollisionBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_CollisionBox
            // 
            this.panel_CollisionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CollisionBox.Controls.Add(this.pictureBox_CollisionBox);
            this.panel_CollisionBox.Location = new System.Drawing.Point(312, 72);
            this.panel_CollisionBox.Name = "panel_CollisionBox";
            this.panel_CollisionBox.Size = new System.Drawing.Size(525, 343);
            this.panel_CollisionBox.TabIndex = 0;
            // 
            // pictureBox_CollisionBox
            // 
            this.pictureBox_CollisionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_CollisionBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_CollisionBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox_CollisionBox.Name = "pictureBox_CollisionBox";
            this.pictureBox_CollisionBox.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_CollisionBox.TabIndex = 0;
            this.pictureBox_CollisionBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // txtBox_X
            // 
            this.txtBox_X.Location = new System.Drawing.Point(90, 72);
            this.txtBox_X.Name = "txtBox_X";
            this.txtBox_X.Size = new System.Drawing.Size(139, 20);
            this.txtBox_X.TabIndex = 4;
            this.txtBox_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            this.txtBox_X.Leave += new System.EventHandler(this.LeaveTextBoxEvent);
            // 
            // txtBox_Y
            // 
            this.txtBox_Y.Location = new System.Drawing.Point(90, 98);
            this.txtBox_Y.Name = "txtBox_Y";
            this.txtBox_Y.Size = new System.Drawing.Size(139, 20);
            this.txtBox_Y.TabIndex = 5;
            this.txtBox_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            this.txtBox_Y.Leave += new System.EventHandler(this.LeaveTextBoxEvent);
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(90, 124);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(139, 20);
            this.txtBox_Width.TabIndex = 6;
            this.txtBox_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            this.txtBox_Width.Leave += new System.EventHandler(this.LeaveTextBoxEvent);
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Location = new System.Drawing.Point(90, 150);
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(139, 20);
            this.txtBox_Height.TabIndex = 7;
            this.txtBox_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            this.txtBox_Height.Leave += new System.EventHandler(this.LeaveTextBoxEvent);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(70, 75);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(14, 13);
            this.lbl_X.TabIndex = 8;
            this.lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(70, 101);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(14, 13);
            this.lbl_Y.TabIndex = 9;
            this.lbl_Y.Text = "Y";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(46, 153);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 10;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(49, 127);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 11;
            this.lbl_Width.Text = "Width";
            // 
            // EditCollisionBoxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.txtBox_Height);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.txtBox_Y);
            this.Controls.Add(this.txtBox_X);
            this.Controls.Add(this.panel_CollisionBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditCollisionBoxWindow";
            this.Text = "EditCollisionBoxWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCollisionBoxWindow_FormClosing);
            this.Shown += new System.EventHandler(this.EditCollisionBoxWindow_Shown);
            this.panel_CollisionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CollisionBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_CollisionBox;
        private System.Windows.Forms.PictureBox pictureBox_CollisionBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox_X;
        private System.Windows.Forms.TextBox txtBox_Y;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
    }
}