namespace AnimationEditor
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteSheetManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_AnimationPreview = new System.Windows.Forms.Panel();
            this.picBox_AnimationPreview = new System.Windows.Forms.PictureBox();
            this.btn_NewAnimation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_AnimationPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnimationPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.spriteSheetManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // spriteSheetManagerToolStripMenuItem
            // 
            this.spriteSheetManagerToolStripMenuItem.Name = "spriteSheetManagerToolStripMenuItem";
            this.spriteSheetManagerToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.spriteSheetManagerToolStripMenuItem.Text = "Sprite Sheet Manager";
            this.spriteSheetManagerToolStripMenuItem.Click += new System.EventHandler(this.spriteSheetManagerToolStripMenuItem_Click);
            // 
            // panel_AnimationPreview
            // 
            this.panel_AnimationPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_AnimationPreview.AutoScroll = true;
            this.panel_AnimationPreview.Controls.Add(this.picBox_AnimationPreview);
            this.panel_AnimationPreview.Location = new System.Drawing.Point(225, 139);
            this.panel_AnimationPreview.Name = "panel_AnimationPreview";
            this.panel_AnimationPreview.Size = new System.Drawing.Size(704, 377);
            this.panel_AnimationPreview.TabIndex = 1;
            // 
            // picBox_AnimationPreview
            // 
            this.picBox_AnimationPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_AnimationPreview.Location = new System.Drawing.Point(0, 0);
            this.picBox_AnimationPreview.Name = "picBox_AnimationPreview";
            this.picBox_AnimationPreview.Size = new System.Drawing.Size(704, 377);
            this.picBox_AnimationPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_AnimationPreview.TabIndex = 0;
            this.picBox_AnimationPreview.TabStop = false;
            // 
            // btn_NewAnimation
            // 
            this.btn_NewAnimation.Location = new System.Drawing.Point(146, 49);
            this.btn_NewAnimation.Name = "btn_NewAnimation";
            this.btn_NewAnimation.Size = new System.Drawing.Size(99, 23);
            this.btn_NewAnimation.TabIndex = 2;
            this.btn_NewAnimation.Text = "New Animation";
            this.btn_NewAnimation.UseVisualStyleBackColor = true;
            this.btn_NewAnimation.Click += new System.EventHandler(this.btn_NewAnimation_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 528);
            this.Controls.Add(this.btn_NewAnimation);
            this.Controls.Add(this.panel_AnimationPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_AnimationPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnimationPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteSheetManagerToolStripMenuItem;
        private System.Windows.Forms.Panel panel_AnimationPreview;
        public System.Windows.Forms.PictureBox picBox_AnimationPreview;
        private System.Windows.Forms.Button btn_NewAnimation;
    }
}