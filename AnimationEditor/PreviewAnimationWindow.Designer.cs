namespace AnimationEditor
{
    partial class PreviewAnimationWindow
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
            this.pictureBox_AnimationPreview = new System.Windows.Forms.PictureBox();
            this.panel_AnimationPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnimationPreview)).BeginInit();
            this.panel_AnimationPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_AnimationPreview
            // 
            this.pictureBox_AnimationPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AnimationPreview.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox_AnimationPreview.Name = "pictureBox_AnimationPreview";
            this.pictureBox_AnimationPreview.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_AnimationPreview.TabIndex = 0;
            this.pictureBox_AnimationPreview.TabStop = false;
            // 
            // panel_AnimationPreview
            // 
            this.panel_AnimationPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AnimationPreview.Controls.Add(this.pictureBox_AnimationPreview);
            this.panel_AnimationPreview.Location = new System.Drawing.Point(103, 66);
            this.panel_AnimationPreview.Name = "panel_AnimationPreview";
            this.panel_AnimationPreview.Size = new System.Drawing.Size(784, 352);
            this.panel_AnimationPreview.TabIndex = 1;
            // 
            // PreviewAnimationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 429);
            this.Controls.Add(this.panel_AnimationPreview);
            this.Name = "PreviewAnimationWindow";
            this.Text = "PreviewAnimationWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosed);
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnimationPreview)).EndInit();
            this.panel_AnimationPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_AnimationPreview;
        private System.Windows.Forms.Panel panel_AnimationPreview;
    }
}