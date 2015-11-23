namespace AnimationEditor
{
    partial class EditAnimationWindow
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
            this.pictureBox_TextureDisplay = new System.Windows.Forms.PictureBox();
            this.listBox_Frames = new System.Windows.Forms.ListBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_AnimationName = new System.Windows.Forms.Label();
            this.txtBox_AnimationName = new System.Windows.Forms.TextBox();
            this.txtBox_FrameX = new System.Windows.Forms.TextBox();
            this.txtBox_FrameY = new System.Windows.Forms.TextBox();
            this.txtBox_FrameWidth = new System.Windows.Forms.TextBox();
            this.txtBox_FrameHeight = new System.Windows.Forms.TextBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_SpriteSheet = new System.Windows.Forms.Label();
            this.btn_AddFrame = new System.Windows.Forms.Button();
            this.btn_RemoveFrame = new System.Windows.Forms.Button();
            this.panel_XNA = new System.Windows.Forms.Panel();
            this.txtBox_Scale = new System.Windows.Forms.TextBox();
            this.txtBox_Depth = new System.Windows.Forms.TextBox();
            this.txtBox_Speed = new System.Windows.Forms.TextBox();
            this.lbl_FrameCount = new System.Windows.Forms.Label();
            this.lbl_CurrentFrameCount = new System.Windows.Forms.Label();
            this.lbl_Scale = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.lbl_Depth = new System.Windows.Forms.Label();
            this.lbl_CurrentFrame = new System.Windows.Forms.Label();
            this.panel_AnimationInformation = new System.Windows.Forms.Panel();
            this.panel_CurrentFrameInformation = new System.Windows.Forms.Panel();
            this.lbl_FrameNumber = new System.Windows.Forms.Label();
            this.lbl_Frame = new System.Windows.Forms.Label();
            this.lbl_TextureName = new System.Windows.Forms.Label();
            this.btn_SetSpriteSheet = new System.Windows.Forms.Button();
            this.lbl_Frames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TextureDisplay)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.panel_XNA.SuspendLayout();
            this.panel_AnimationInformation.SuspendLayout();
            this.panel_CurrentFrameInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_TextureDisplay
            // 
            this.pictureBox_TextureDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_TextureDisplay.Location = new System.Drawing.Point(-1740, -1914);
            this.pictureBox_TextureDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_TextureDisplay.Name = "pictureBox_TextureDisplay";
            this.pictureBox_TextureDisplay.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_TextureDisplay.TabIndex = 0;
            this.pictureBox_TextureDisplay.TabStop = false;
            // 
            // listBox_Frames
            // 
            this.listBox_Frames.FormattingEnabled = true;
            this.listBox_Frames.Location = new System.Drawing.Point(18, 82);
            this.listBox_Frames.Name = "listBox_Frames";
            this.listBox_Frames.Size = new System.Drawing.Size(70, 537);
            this.listBox_Frames.TabIndex = 2;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(959, 24);
            this.menuStrip_Main.TabIndex = 3;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAndExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAndExitToolStripMenuItem
            // 
            this.saveAndExitToolStripMenuItem.Name = "saveAndExitToolStripMenuItem";
            this.saveAndExitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveAndExitToolStripMenuItem.Text = "Save and Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lbl_AnimationName
            // 
            this.lbl_AnimationName.AutoSize = true;
            this.lbl_AnimationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnimationName.Location = new System.Drawing.Point(159, 58);
            this.lbl_AnimationName.Name = "lbl_AnimationName";
            this.lbl_AnimationName.Size = new System.Drawing.Size(98, 13);
            this.lbl_AnimationName.TabIndex = 4;
            this.lbl_AnimationName.Text = "Animation Name";
            // 
            // txtBox_AnimationName
            // 
            this.txtBox_AnimationName.Location = new System.Drawing.Point(103, 80);
            this.txtBox_AnimationName.Name = "txtBox_AnimationName";
            this.txtBox_AnimationName.Size = new System.Drawing.Size(206, 20);
            this.txtBox_AnimationName.TabIndex = 5;
            // 
            // txtBox_FrameX
            // 
            this.txtBox_FrameX.Location = new System.Drawing.Point(67, 29);
            this.txtBox_FrameX.Name = "txtBox_FrameX";
            this.txtBox_FrameX.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameX.TabIndex = 6;
            // 
            // txtBox_FrameY
            // 
            this.txtBox_FrameY.Location = new System.Drawing.Point(67, 55);
            this.txtBox_FrameY.Name = "txtBox_FrameY";
            this.txtBox_FrameY.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameY.TabIndex = 7;
            this.txtBox_FrameY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBox_FrameWidth
            // 
            this.txtBox_FrameWidth.Location = new System.Drawing.Point(67, 107);
            this.txtBox_FrameWidth.Name = "txtBox_FrameWidth";
            this.txtBox_FrameWidth.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameWidth.TabIndex = 8;
            // 
            // txtBox_FrameHeight
            // 
            this.txtBox_FrameHeight.Location = new System.Drawing.Point(67, 81);
            this.txtBox_FrameHeight.Name = "txtBox_FrameHeight";
            this.txtBox_FrameHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameHeight.TabIndex = 9;
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(50, 32);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(14, 13);
            this.lbl_X.TabIndex = 10;
            this.lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(50, 58);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(14, 13);
            this.lbl_Y.TabIndex = 11;
            this.lbl_Y.Text = "Y";
            this.lbl_Y.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(26, 84);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 12;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(29, 110);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 13;
            this.lbl_Width.Text = "Width";
            // 
            // lbl_SpriteSheet
            // 
            this.lbl_SpriteSheet.AutoSize = true;
            this.lbl_SpriteSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpriteSheet.Location = new System.Drawing.Point(503, 38);
            this.lbl_SpriteSheet.Name = "lbl_SpriteSheet";
            this.lbl_SpriteSheet.Size = new System.Drawing.Size(85, 13);
            this.lbl_SpriteSheet.TabIndex = 14;
            this.lbl_SpriteSheet.Text = "Sprite Sheet :";
            // 
            // btn_AddFrame
            // 
            this.btn_AddFrame.Location = new System.Drawing.Point(109, 572);
            this.btn_AddFrame.Name = "btn_AddFrame";
            this.btn_AddFrame.Size = new System.Drawing.Size(91, 23);
            this.btn_AddFrame.TabIndex = 15;
            this.btn_AddFrame.Text = "Add Frame";
            this.btn_AddFrame.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveFrame
            // 
            this.btn_RemoveFrame.Location = new System.Drawing.Point(224, 572);
            this.btn_RemoveFrame.Name = "btn_RemoveFrame";
            this.btn_RemoveFrame.Size = new System.Drawing.Size(91, 23);
            this.btn_RemoveFrame.TabIndex = 16;
            this.btn_RemoveFrame.Text = "Remove Frame";
            this.btn_RemoveFrame.UseVisualStyleBackColor = true;
            // 
            // panel_XNA
            // 
            this.panel_XNA.AutoScroll = true;
            this.panel_XNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_XNA.Controls.Add(this.pictureBox_TextureDisplay);
            this.panel_XNA.Location = new System.Drawing.Point(331, 57);
            this.panel_XNA.Name = "panel_XNA";
            this.panel_XNA.Size = new System.Drawing.Size(619, 271);
            this.panel_XNA.TabIndex = 17;
            // 
            // txtBox_Scale
            // 
            this.txtBox_Scale.Location = new System.Drawing.Point(73, 26);
            this.txtBox_Scale.Name = "txtBox_Scale";
            this.txtBox_Scale.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Scale.TabIndex = 18;
            // 
            // txtBox_Depth
            // 
            this.txtBox_Depth.Location = new System.Drawing.Point(73, 52);
            this.txtBox_Depth.Name = "txtBox_Depth";
            this.txtBox_Depth.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Depth.TabIndex = 19;
            // 
            // txtBox_Speed
            // 
            this.txtBox_Speed.Location = new System.Drawing.Point(73, 79);
            this.txtBox_Speed.Name = "txtBox_Speed";
            this.txtBox_Speed.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Speed.TabIndex = 20;
            // 
            // lbl_FrameCount
            // 
            this.lbl_FrameCount.AutoSize = true;
            this.lbl_FrameCount.Location = new System.Drawing.Point(5, 9);
            this.lbl_FrameCount.Name = "lbl_FrameCount";
            this.lbl_FrameCount.Size = new System.Drawing.Size(67, 13);
            this.lbl_FrameCount.TabIndex = 21;
            this.lbl_FrameCount.Text = "Frame Count";
            // 
            // lbl_CurrentFrameCount
            // 
            this.lbl_CurrentFrameCount.AutoSize = true;
            this.lbl_CurrentFrameCount.Location = new System.Drawing.Point(70, 9);
            this.lbl_CurrentFrameCount.Name = "lbl_CurrentFrameCount";
            this.lbl_CurrentFrameCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_CurrentFrameCount.TabIndex = 22;
            this.lbl_CurrentFrameCount.Text = "0";
            // 
            // lbl_Scale
            // 
            this.lbl_Scale.AutoSize = true;
            this.lbl_Scale.Location = new System.Drawing.Point(38, 29);
            this.lbl_Scale.Name = "lbl_Scale";
            this.lbl_Scale.Size = new System.Drawing.Size(34, 13);
            this.lbl_Scale.TabIndex = 23;
            this.lbl_Scale.Text = "Scale";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Location = new System.Drawing.Point(34, 82);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(38, 13);
            this.lbl_Speed.TabIndex = 24;
            this.lbl_Speed.Text = "Speed";
            // 
            // lbl_Depth
            // 
            this.lbl_Depth.AutoSize = true;
            this.lbl_Depth.Location = new System.Drawing.Point(36, 55);
            this.lbl_Depth.Name = "lbl_Depth";
            this.lbl_Depth.Size = new System.Drawing.Size(36, 13);
            this.lbl_Depth.TabIndex = 25;
            this.lbl_Depth.Text = "Depth";
            // 
            // lbl_CurrentFrame
            // 
            this.lbl_CurrentFrame.AutoSize = true;
            this.lbl_CurrentFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentFrame.Location = new System.Drawing.Point(165, 411);
            this.lbl_CurrentFrame.Name = "lbl_CurrentFrame";
            this.lbl_CurrentFrame.Size = new System.Drawing.Size(86, 13);
            this.lbl_CurrentFrame.TabIndex = 26;
            this.lbl_CurrentFrame.Text = "Current Frame";
            this.lbl_CurrentFrame.Click += new System.EventHandler(this.lbl_CurrentFrame_Click);
            // 
            // panel_AnimationInformation
            // 
            this.panel_AnimationInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AnimationInformation.Controls.Add(this.lbl_FrameCount);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Scale);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Depth);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Depth);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Speed);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Speed);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Scale);
            this.panel_AnimationInformation.Controls.Add(this.lbl_CurrentFrameCount);
            this.panel_AnimationInformation.Location = new System.Drawing.Point(94, 106);
            this.panel_AnimationInformation.Name = "panel_AnimationInformation";
            this.panel_AnimationInformation.Size = new System.Drawing.Size(228, 114);
            this.panel_AnimationInformation.TabIndex = 27;
            // 
            // panel_CurrentFrameInformation
            // 
            this.panel_CurrentFrameInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_FrameNumber);
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_Frame);
            this.panel_CurrentFrameInformation.Controls.Add(this.txtBox_FrameX);
            this.panel_CurrentFrameInformation.Controls.Add(this.txtBox_FrameY);
            this.panel_CurrentFrameInformation.Controls.Add(this.txtBox_FrameWidth);
            this.panel_CurrentFrameInformation.Controls.Add(this.txtBox_FrameHeight);
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_X);
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_Y);
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_Width);
            this.panel_CurrentFrameInformation.Controls.Add(this.lbl_Height);
            this.panel_CurrentFrameInformation.Location = new System.Drawing.Point(100, 431);
            this.panel_CurrentFrameInformation.Name = "panel_CurrentFrameInformation";
            this.panel_CurrentFrameInformation.Size = new System.Drawing.Size(228, 135);
            this.panel_CurrentFrameInformation.TabIndex = 28;
            // 
            // lbl_FrameNumber
            // 
            this.lbl_FrameNumber.AutoSize = true;
            this.lbl_FrameNumber.Location = new System.Drawing.Point(64, 9);
            this.lbl_FrameNumber.Name = "lbl_FrameNumber";
            this.lbl_FrameNumber.Size = new System.Drawing.Size(13, 13);
            this.lbl_FrameNumber.TabIndex = 15;
            this.lbl_FrameNumber.Text = "0";
            // 
            // lbl_Frame
            // 
            this.lbl_Frame.AutoSize = true;
            this.lbl_Frame.Location = new System.Drawing.Point(29, 9);
            this.lbl_Frame.Name = "lbl_Frame";
            this.lbl_Frame.Size = new System.Drawing.Size(36, 13);
            this.lbl_Frame.TabIndex = 14;
            this.lbl_Frame.Text = "Frame";
            // 
            // lbl_TextureName
            // 
            this.lbl_TextureName.AutoSize = true;
            this.lbl_TextureName.Location = new System.Drawing.Point(594, 38);
            this.lbl_TextureName.Name = "lbl_TextureName";
            this.lbl_TextureName.Size = new System.Drawing.Size(33, 13);
            this.lbl_TextureName.TabIndex = 29;
            this.lbl_TextureName.Text = "None";
            // 
            // btn_SetSpriteSheet
            // 
            this.btn_SetSpriteSheet.Location = new System.Drawing.Point(794, 28);
            this.btn_SetSpriteSheet.Name = "btn_SetSpriteSheet";
            this.btn_SetSpriteSheet.Size = new System.Drawing.Size(94, 23);
            this.btn_SetSpriteSheet.TabIndex = 30;
            this.btn_SetSpriteSheet.Text = "Set Sprite Sheet";
            this.btn_SetSpriteSheet.UseVisualStyleBackColor = true;
            // 
            // lbl_Frames
            // 
            this.lbl_Frames.AutoSize = true;
            this.lbl_Frames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Frames.Location = new System.Drawing.Point(29, 60);
            this.lbl_Frames.Name = "lbl_Frames";
            this.lbl_Frames.Size = new System.Drawing.Size(47, 13);
            this.lbl_Frames.TabIndex = 31;
            this.lbl_Frames.Text = "Frames";
            this.lbl_Frames.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // EditAnimationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 634);
            this.Controls.Add(this.lbl_Frames);
            this.Controls.Add(this.btn_SetSpriteSheet);
            this.Controls.Add(this.lbl_TextureName);
            this.Controls.Add(this.lbl_CurrentFrame);
            this.Controls.Add(this.panel_CurrentFrameInformation);
            this.Controls.Add(this.panel_AnimationInformation);
            this.Controls.Add(this.btn_RemoveFrame);
            this.Controls.Add(this.panel_XNA);
            this.Controls.Add(this.lbl_SpriteSheet);
            this.Controls.Add(this.btn_AddFrame);
            this.Controls.Add(this.txtBox_AnimationName);
            this.Controls.Add(this.lbl_AnimationName);
            this.Controls.Add(this.listBox_Frames);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "EditAnimationWindow";
            this.Text = "New Animation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Shown += new System.EventHandler(this.OnShown_Window);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TextureDisplay)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.panel_XNA.ResumeLayout(false);
            this.panel_AnimationInformation.ResumeLayout(false);
            this.panel_AnimationInformation.PerformLayout();
            this.panel_CurrentFrameInformation.ResumeLayout(false);
            this.panel_CurrentFrameInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_TextureDisplay;
        private System.Windows.Forms.ListBox listBox_Frames;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_AnimationName;
        private System.Windows.Forms.TextBox txtBox_AnimationName;
        private System.Windows.Forms.TextBox txtBox_FrameX;
        private System.Windows.Forms.TextBox txtBox_FrameY;
        private System.Windows.Forms.TextBox txtBox_FrameWidth;
        private System.Windows.Forms.TextBox txtBox_FrameHeight;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_SpriteSheet;
        private System.Windows.Forms.Button btn_AddFrame;
        private System.Windows.Forms.Button btn_RemoveFrame;
        private System.Windows.Forms.Panel panel_XNA;
        private System.Windows.Forms.TextBox txtBox_Scale;
        private System.Windows.Forms.TextBox txtBox_Depth;
        private System.Windows.Forms.TextBox txtBox_Speed;
        private System.Windows.Forms.Label lbl_FrameCount;
        private System.Windows.Forms.Label lbl_CurrentFrameCount;
        private System.Windows.Forms.Label lbl_Scale;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label lbl_Depth;
        private System.Windows.Forms.Label lbl_CurrentFrame;
        private System.Windows.Forms.Panel panel_AnimationInformation;
        private System.Windows.Forms.Panel panel_CurrentFrameInformation;
        private System.Windows.Forms.Label lbl_FrameNumber;
        private System.Windows.Forms.Label lbl_Frame;
        private System.Windows.Forms.Label lbl_TextureName;
        private System.Windows.Forms.Button btn_SetSpriteSheet;
        private System.Windows.Forms.ToolStripMenuItem saveAndExitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Frames;
    }
}