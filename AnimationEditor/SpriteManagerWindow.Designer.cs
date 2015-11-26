namespace AnimationEditor
{
    partial class SpriteSheetManagerWindow
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
            this.pictureBox_SpriteSheetPreview = new System.Windows.Forms.PictureBox();
            this.panel_SpriteSheetPreview = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_SpriteSheets = new System.Windows.Forms.ListBox();
            this.lbl_SpriteSheets = new System.Windows.Forms.Label();
            this.txtBox_SheetName = new System.Windows.Forms.TextBox();
            this.lbl_SheetName = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_WidthValue = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_HeightValue = new System.Windows.Forms.Label();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_SetTransparentColor = new System.Windows.Forms.Button();
            this.btn_BackgroundColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SpriteSheetPreview)).BeginInit();
            this.panel_SpriteSheetPreview.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_SpriteSheetPreview
            // 
            this.pictureBox_SpriteSheetPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_SpriteSheetPreview.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_SpriteSheetPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_SpriteSheetPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_SpriteSheetPreview.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_SpriteSheetPreview.Name = "pictureBox_SpriteSheetPreview";
            this.pictureBox_SpriteSheetPreview.Size = new System.Drawing.Size(5461, 5041);
            this.pictureBox_SpriteSheetPreview.TabIndex = 0;
            this.pictureBox_SpriteSheetPreview.TabStop = false;
            // 
            // panel_SpriteSheetPreview
            // 
            this.panel_SpriteSheetPreview.AutoScroll = true;
            this.panel_SpriteSheetPreview.Controls.Add(this.pictureBox_SpriteSheetPreview);
            this.panel_SpriteSheetPreview.Location = new System.Drawing.Point(421, 177);
            this.panel_SpriteSheetPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_SpriteSheetPreview.Name = "panel_SpriteSheetPreview";
            this.panel_SpriteSheetPreview.Size = new System.Drawing.Size(1055, 554);
            this.panel_SpriteSheetPreview.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1492, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listBox_SpriteSheets
            // 
            this.listBox_SpriteSheets.FormattingEnabled = true;
            this.listBox_SpriteSheets.ItemHeight = 16;
            this.listBox_SpriteSheets.Location = new System.Drawing.Point(16, 123);
            this.listBox_SpriteSheets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_SpriteSheets.Name = "listBox_SpriteSheets";
            this.listBox_SpriteSheets.Size = new System.Drawing.Size(360, 644);
            this.listBox_SpriteSheets.TabIndex = 3;
            this.listBox_SpriteSheets.SelectedIndexChanged += new System.EventHandler(this.listBox_SpriteSheets_SelectedIndexChanged);
            // 
            // lbl_SpriteSheets
            // 
            this.lbl_SpriteSheets.AutoSize = true;
            this.lbl_SpriteSheets.Location = new System.Drawing.Point(141, 97);
            this.lbl_SpriteSheets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SpriteSheets.Name = "lbl_SpriteSheets";
            this.lbl_SpriteSheets.Size = new System.Drawing.Size(93, 17);
            this.lbl_SpriteSheets.TabIndex = 4;
            this.lbl_SpriteSheets.Text = "Sprite Sheets";
            // 
            // txtBox_SheetName
            // 
            this.txtBox_SheetName.Location = new System.Drawing.Point(788, 84);
            this.txtBox_SheetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_SheetName.Name = "txtBox_SheetName";
            this.txtBox_SheetName.Size = new System.Drawing.Size(352, 22);
            this.txtBox_SheetName.TabIndex = 5;
            // 
            // lbl_SheetName
            // 
            this.lbl_SheetName.AutoSize = true;
            this.lbl_SheetName.Location = new System.Drawing.Point(696, 87);
            this.lbl_SheetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SheetName.Name = "lbl_SheetName";
            this.lbl_SheetName.Size = new System.Drawing.Size(90, 17);
            this.lbl_SheetName.TabIndex = 6;
            this.lbl_SheetName.Text = "Sheet Name:";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.Location = new System.Drawing.Point(840, 133);
            this.lbl_Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(54, 17);
            this.lbl_Width.TabIndex = 7;
            this.lbl_Width.Text = "Width:";
            // 
            // lbl_WidthValue
            // 
            this.lbl_WidthValue.AutoSize = true;
            this.lbl_WidthValue.Location = new System.Drawing.Point(907, 133);
            this.lbl_WidthValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WidthValue.Name = "lbl_WidthValue";
            this.lbl_WidthValue.Size = new System.Drawing.Size(16, 17);
            this.lbl_WidthValue.TabIndex = 8;
            this.lbl_WidthValue.Text = "0";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(991, 133);
            this.lbl_Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(60, 17);
            this.lbl_Height.TabIndex = 9;
            this.lbl_Height.Text = "Height:";
            // 
            // lbl_HeightValue
            // 
            this.lbl_HeightValue.AutoSize = true;
            this.lbl_HeightValue.Location = new System.Drawing.Point(1063, 133);
            this.lbl_HeightValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeightValue.Name = "lbl_HeightValue";
            this.lbl_HeightValue.Size = new System.Drawing.Size(16, 17);
            this.lbl_HeightValue.TabIndex = 10;
            this.lbl_HeightValue.Text = "0";
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(917, 735);
            this.btn_LoadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(100, 28);
            this.btn_LoadImage.TabIndex = 11;
            this.btn_LoadImage.Text = "Load Image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(59, 44);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(100, 28);
            this.btn_New.TabIndex = 12;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(216, 44);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 28);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1213, 97);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(143, 28);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Sprite Sheet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_SetTransparentColor
            // 
            this.btn_SetTransparentColor.Location = new System.Drawing.Point(1213, 57);
            this.btn_SetTransparentColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SetTransparentColor.Name = "btn_SetTransparentColor";
            this.btn_SetTransparentColor.Size = new System.Drawing.Size(143, 28);
            this.btn_SetTransparentColor.TabIndex = 15;
            this.btn_SetTransparentColor.Text = "Transparent Color";
            this.btn_SetTransparentColor.UseVisualStyleBackColor = true;
            this.btn_SetTransparentColor.Click += new System.EventHandler(this.btn_TransparentColor_Click);
            // 
            // btn_BackgroundColor
            // 
            this.btn_BackgroundColor.Location = new System.Drawing.Point(461, 142);
            this.btn_BackgroundColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BackgroundColor.Name = "btn_BackgroundColor";
            this.btn_BackgroundColor.Size = new System.Drawing.Size(149, 28);
            this.btn_BackgroundColor.TabIndex = 16;
            this.btn_BackgroundColor.Text = "Background Color";
            this.btn_BackgroundColor.UseVisualStyleBackColor = true;
            this.btn_BackgroundColor.Click += new System.EventHandler(this.btn_BackgroundColor_Click);
            // 
            // SpriteSheetManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 783);
            this.Controls.Add(this.btn_BackgroundColor);
            this.Controls.Add(this.btn_SetTransparentColor);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.lbl_HeightValue);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_WidthValue);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_SheetName);
            this.Controls.Add(this.txtBox_SheetName);
            this.Controls.Add(this.lbl_SpriteSheets);
            this.Controls.Add(this.listBox_SpriteSheets);
            this.Controls.Add(this.panel_SpriteSheetPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpriteSheetManagerWindow";
            this.Text = "Sprite Sheet Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpriteManagerWindow_FormClosing);
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SpriteSheetPreview)).EndInit();
            this.panel_SpriteSheetPreview.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_SpriteSheetPreview;
        private System.Windows.Forms.Panel panel_SpriteSheetPreview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_SpriteSheets;
        private System.Windows.Forms.Label lbl_SpriteSheets;
        private System.Windows.Forms.TextBox txtBox_SheetName;
        private System.Windows.Forms.Label lbl_SheetName;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_WidthValue;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_HeightValue;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_SetTransparentColor;
        private System.Windows.Forms.Button btn_BackgroundColor;
    }
}