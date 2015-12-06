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
            this.txtBox_DefaultWidth = new System.Windows.Forms.TextBox();
            this.txtBox_DefaultHeight = new System.Windows.Forms.TextBox();
            this.lbl_DefaultWidth = new System.Windows.Forms.Label();
            this.lbl_DefaultHeight = new System.Windows.Forms.Label();
            this.panel_CurrentFrameInformation = new System.Windows.Forms.Panel();
            this.lbl_FrameNumber = new System.Windows.Forms.Label();
            this.lbl_Frame = new System.Windows.Forms.Label();
            this.lbl_TextureName = new System.Windows.Forms.Label();
            this.btn_SetSpriteSheet = new System.Windows.Forms.Button();
            this.lbl_Frames = new System.Windows.Forms.Label();
            this.panel_FrameDisplay = new System.Windows.Forms.Panel();
            this.pictureBox_FrameDisplay = new System.Windows.Forms.PictureBox();
            this.label_DisplayFrameCurrent = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_SetFrame = new System.Windows.Forms.Button();
            this.btn_SetAnimation = new System.Windows.Forms.Button();
            this.btn_GridTool = new System.Windows.Forms.Button();
            this.btn_CloneFrame = new System.Windows.Forms.Button();
            this.btn_FrameBackgroundColor = new System.Windows.Forms.Button();
            this.btn_TextureBackgroundColor = new System.Windows.Forms.Button();
            this.lbl_MouseState = new System.Windows.Forms.Label();
            this.lbl_MousePositionLabel = new System.Windows.Forms.Label();
            this.btn_FrameColor = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SetFrameNumber = new System.Windows.Forms.Button();
            this.saveAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SaveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TextureDisplay)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.panel_XNA.SuspendLayout();
            this.panel_AnimationInformation.SuspendLayout();
            this.panel_CurrentFrameInformation.SuspendLayout();
            this.panel_FrameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FrameDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_TextureDisplay
            // 
            this.pictureBox_TextureDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_TextureDisplay.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_TextureDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_TextureDisplay.Name = "pictureBox_TextureDisplay";
            this.pictureBox_TextureDisplay.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_TextureDisplay.TabIndex = 0;
            this.pictureBox_TextureDisplay.TabStop = false;
            this.pictureBox_TextureDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_TextureDisplay_MouseMove);
            // 
            // listBox_Frames
            // 
            this.listBox_Frames.FormattingEnabled = true;
            this.listBox_Frames.Location = new System.Drawing.Point(17, 58);
            this.listBox_Frames.Name = "listBox_Frames";
            this.listBox_Frames.Size = new System.Drawing.Size(70, 576);
            this.listBox_Frames.TabIndex = 1;
            this.listBox_Frames.SelectedIndexChanged += new System.EventHandler(this.listBox_Frames_SelectedIndexChanged);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip_Main.TabIndex = 3;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAndExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lbl_AnimationName
            // 
            this.lbl_AnimationName.AutoSize = true;
            this.lbl_AnimationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnimationName.Location = new System.Drawing.Point(160, 28);
            this.lbl_AnimationName.Name = "lbl_AnimationName";
            this.lbl_AnimationName.Size = new System.Drawing.Size(98, 13);
            this.lbl_AnimationName.TabIndex = 4;
            this.lbl_AnimationName.Text = "Animation Name";
            // 
            // txtBox_AnimationName
            // 
            this.txtBox_AnimationName.Location = new System.Drawing.Point(104, 50);
            this.txtBox_AnimationName.Name = "txtBox_AnimationName";
            this.txtBox_AnimationName.Size = new System.Drawing.Size(206, 20);
            this.txtBox_AnimationName.TabIndex = 3;
            // 
            // txtBox_FrameX
            // 
            this.txtBox_FrameX.Location = new System.Drawing.Point(67, 29);
            this.txtBox_FrameX.Name = "txtBox_FrameX";
            this.txtBox_FrameX.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameX.TabIndex = 11;
            this.txtBox_FrameX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_FrameY
            // 
            this.txtBox_FrameY.Location = new System.Drawing.Point(67, 55);
            this.txtBox_FrameY.Name = "txtBox_FrameY";
            this.txtBox_FrameY.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameY.TabIndex = 12;
            this.txtBox_FrameY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_FrameWidth
            // 
            this.txtBox_FrameWidth.Location = new System.Drawing.Point(67, 107);
            this.txtBox_FrameWidth.Name = "txtBox_FrameWidth";
            this.txtBox_FrameWidth.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameWidth.TabIndex = 14;
            this.txtBox_FrameWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_FrameHeight
            // 
            this.txtBox_FrameHeight.Location = new System.Drawing.Point(67, 81);
            this.txtBox_FrameHeight.Name = "txtBox_FrameHeight";
            this.txtBox_FrameHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FrameHeight.TabIndex = 13;
            this.txtBox_FrameHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
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
            this.btn_AddFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_AddFrame.Location = new System.Drawing.Point(17, 644);
            this.btn_AddFrame.Name = "btn_AddFrame";
            this.btn_AddFrame.Size = new System.Drawing.Size(27, 23);
            this.btn_AddFrame.TabIndex = 2;
            this.btn_AddFrame.Text = "+";
            this.btn_AddFrame.UseVisualStyleBackColor = true;
            this.btn_AddFrame.Click += new System.EventHandler(this.btn_AddFrame_Click);
            // 
            // btn_RemoveFrame
            // 
            this.btn_RemoveFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_RemoveFrame.Location = new System.Drawing.Point(60, 644);
            this.btn_RemoveFrame.Name = "btn_RemoveFrame";
            this.btn_RemoveFrame.Size = new System.Drawing.Size(27, 23);
            this.btn_RemoveFrame.TabIndex = 3;
            this.btn_RemoveFrame.Text = "-";
            this.btn_RemoveFrame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_RemoveFrame.UseVisualStyleBackColor = true;
            this.btn_RemoveFrame.Click += new System.EventHandler(this.btn_RemoveFrame_Click);
            // 
            // panel_XNA
            // 
            this.panel_XNA.AutoScroll = true;
            this.panel_XNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_XNA.Controls.Add(this.pictureBox_TextureDisplay);
            this.panel_XNA.Location = new System.Drawing.Point(331, 57);
            this.panel_XNA.Name = "panel_XNA";
            this.panel_XNA.Size = new System.Drawing.Size(619, 271);
            this.panel_XNA.TabIndex = 1;
            this.panel_XNA.TabStop = true;
            // 
            // txtBox_Scale
            // 
            this.txtBox_Scale.Location = new System.Drawing.Point(99, 29);
            this.txtBox_Scale.Name = "txtBox_Scale";
            this.txtBox_Scale.Size = new System.Drawing.Size(124, 20);
            this.txtBox_Scale.TabIndex = 4;
            this.txtBox_Scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_KeyPress);
            // 
            // txtBox_Depth
            // 
            this.txtBox_Depth.Location = new System.Drawing.Point(99, 55);
            this.txtBox_Depth.Name = "txtBox_Depth";
            this.txtBox_Depth.Size = new System.Drawing.Size(124, 20);
            this.txtBox_Depth.TabIndex = 5;
            this.txtBox_Depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_KeyPress);
            // 
            // txtBox_Speed
            // 
            this.txtBox_Speed.Location = new System.Drawing.Point(99, 82);
            this.txtBox_Speed.Name = "txtBox_Speed";
            this.txtBox_Speed.Size = new System.Drawing.Size(124, 20);
            this.txtBox_Speed.TabIndex = 6;
            this.txtBox_Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // lbl_FrameCount
            // 
            this.lbl_FrameCount.AutoSize = true;
            this.lbl_FrameCount.Location = new System.Drawing.Point(22, 10);
            this.lbl_FrameCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_FrameCount.Name = "lbl_FrameCount";
            this.lbl_FrameCount.Size = new System.Drawing.Size(67, 13);
            this.lbl_FrameCount.TabIndex = 21;
            this.lbl_FrameCount.Text = "Frame Count";
            // 
            // lbl_CurrentFrameCount
            // 
            this.lbl_CurrentFrameCount.AutoSize = true;
            this.lbl_CurrentFrameCount.Location = new System.Drawing.Point(96, 10);
            this.lbl_CurrentFrameCount.Name = "lbl_CurrentFrameCount";
            this.lbl_CurrentFrameCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_CurrentFrameCount.TabIndex = 22;
            this.lbl_CurrentFrameCount.Text = "0";
            // 
            // lbl_Scale
            // 
            this.lbl_Scale.AutoSize = true;
            this.lbl_Scale.Location = new System.Drawing.Point(52, 32);
            this.lbl_Scale.Name = "lbl_Scale";
            this.lbl_Scale.Size = new System.Drawing.Size(34, 13);
            this.lbl_Scale.TabIndex = 23;
            this.lbl_Scale.Text = "Scale";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Location = new System.Drawing.Point(48, 85);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(38, 13);
            this.lbl_Speed.TabIndex = 24;
            this.lbl_Speed.Text = "Speed";
            // 
            // lbl_Depth
            // 
            this.lbl_Depth.AutoSize = true;
            this.lbl_Depth.Location = new System.Drawing.Point(50, 58);
            this.lbl_Depth.Name = "lbl_Depth";
            this.lbl_Depth.Size = new System.Drawing.Size(36, 13);
            this.lbl_Depth.TabIndex = 25;
            this.lbl_Depth.Text = "Depth";
            // 
            // lbl_CurrentFrame
            // 
            this.lbl_CurrentFrame.AutoSize = true;
            this.lbl_CurrentFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentFrame.Location = new System.Drawing.Point(165, 335);
            this.lbl_CurrentFrame.Name = "lbl_CurrentFrame";
            this.lbl_CurrentFrame.Size = new System.Drawing.Size(86, 13);
            this.lbl_CurrentFrame.TabIndex = 26;
            this.lbl_CurrentFrame.Text = "Current Frame";
            // 
            // panel_AnimationInformation
            // 
            this.panel_AnimationInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AnimationInformation.Controls.Add(this.txtBox_DefaultWidth);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_DefaultHeight);
            this.panel_AnimationInformation.Controls.Add(this.lbl_DefaultWidth);
            this.panel_AnimationInformation.Controls.Add(this.lbl_DefaultHeight);
            this.panel_AnimationInformation.Controls.Add(this.lbl_FrameCount);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Scale);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Depth);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Depth);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Speed);
            this.panel_AnimationInformation.Controls.Add(this.txtBox_Speed);
            this.panel_AnimationInformation.Controls.Add(this.lbl_Scale);
            this.panel_AnimationInformation.Controls.Add(this.lbl_CurrentFrameCount);
            this.panel_AnimationInformation.Location = new System.Drawing.Point(95, 76);
            this.panel_AnimationInformation.Name = "panel_AnimationInformation";
            this.panel_AnimationInformation.Size = new System.Drawing.Size(228, 167);
            this.panel_AnimationInformation.TabIndex = 27;
            // 
            // txtBox_DefaultWidth
            // 
            this.txtBox_DefaultWidth.Location = new System.Drawing.Point(99, 134);
            this.txtBox_DefaultWidth.Name = "txtBox_DefaultWidth";
            this.txtBox_DefaultWidth.Size = new System.Drawing.Size(124, 20);
            this.txtBox_DefaultWidth.TabIndex = 8;
            this.txtBox_DefaultWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_DefaultHeight
            // 
            this.txtBox_DefaultHeight.Location = new System.Drawing.Point(99, 108);
            this.txtBox_DefaultHeight.Name = "txtBox_DefaultHeight";
            this.txtBox_DefaultHeight.Size = new System.Drawing.Size(124, 20);
            this.txtBox_DefaultHeight.TabIndex = 7;
            this.txtBox_DefaultHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // lbl_DefaultWidth
            // 
            this.lbl_DefaultWidth.AutoSize = true;
            this.lbl_DefaultWidth.Location = new System.Drawing.Point(14, 137);
            this.lbl_DefaultWidth.Name = "lbl_DefaultWidth";
            this.lbl_DefaultWidth.Size = new System.Drawing.Size(72, 13);
            this.lbl_DefaultWidth.TabIndex = 27;
            this.lbl_DefaultWidth.Text = "Default Width";
            // 
            // lbl_DefaultHeight
            // 
            this.lbl_DefaultHeight.AutoSize = true;
            this.lbl_DefaultHeight.Location = new System.Drawing.Point(14, 111);
            this.lbl_DefaultHeight.Name = "lbl_DefaultHeight";
            this.lbl_DefaultHeight.Size = new System.Drawing.Size(75, 13);
            this.lbl_DefaultHeight.TabIndex = 26;
            this.lbl_DefaultHeight.Text = "Default Height";
            // 
            // panel_CurrentFrameInformation
            // 
            this.panel_CurrentFrameInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CurrentFrameInformation.Controls.Add(this.btn_SetFrameNumber);
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
            this.panel_CurrentFrameInformation.Location = new System.Drawing.Point(100, 355);
            this.panel_CurrentFrameInformation.Name = "panel_CurrentFrameInformation";
            this.panel_CurrentFrameInformation.Size = new System.Drawing.Size(222, 135);
            this.panel_CurrentFrameInformation.TabIndex = 28;
            // 
            // lbl_FrameNumber
            // 
            this.lbl_FrameNumber.AutoSize = true;
            this.lbl_FrameNumber.Location = new System.Drawing.Point(68, 9);
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
            this.btn_SetSpriteSheet.TabIndex = 18;
            this.btn_SetSpriteSheet.Text = "Set Sprite Sheet";
            this.btn_SetSpriteSheet.UseVisualStyleBackColor = true;
            this.btn_SetSpriteSheet.Click += new System.EventHandler(this.btn_SetSpriteSheet_Click);
            // 
            // lbl_Frames
            // 
            this.lbl_Frames.AutoSize = true;
            this.lbl_Frames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Frames.Location = new System.Drawing.Point(28, 38);
            this.lbl_Frames.Name = "lbl_Frames";
            this.lbl_Frames.Size = new System.Drawing.Size(47, 13);
            this.lbl_Frames.TabIndex = 31;
            this.lbl_Frames.Text = "Frames";
            // 
            // panel_FrameDisplay
            // 
            this.panel_FrameDisplay.AutoScroll = true;
            this.panel_FrameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FrameDisplay.Controls.Add(this.pictureBox_FrameDisplay);
            this.panel_FrameDisplay.Location = new System.Drawing.Point(332, 388);
            this.panel_FrameDisplay.Name = "panel_FrameDisplay";
            this.panel_FrameDisplay.Size = new System.Drawing.Size(618, 266);
            this.panel_FrameDisplay.TabIndex = 32;
            // 
            // pictureBox_FrameDisplay
            // 
            this.pictureBox_FrameDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_FrameDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_FrameDisplay.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_FrameDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_FrameDisplay.Name = "pictureBox_FrameDisplay";
            this.pictureBox_FrameDisplay.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_FrameDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FrameDisplay.TabIndex = 0;
            this.pictureBox_FrameDisplay.TabStop = false;
            // 
            // label_DisplayFrameCurrent
            // 
            this.label_DisplayFrameCurrent.AutoSize = true;
            this.label_DisplayFrameCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayFrameCurrent.Location = new System.Drawing.Point(594, 365);
            this.label_DisplayFrameCurrent.Name = "label_DisplayFrameCurrent";
            this.label_DisplayFrameCurrent.Size = new System.Drawing.Size(86, 13);
            this.label_DisplayFrameCurrent.TabIndex = 33;
            this.label_DisplayFrameCurrent.Text = "Current Frame";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(219, 263);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(91, 23);
            this.btn_Preview.TabIndex = 10;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_SetFrame
            // 
            this.btn_SetFrame.Location = new System.Drawing.Point(169, 497);
            this.btn_SetFrame.Name = "btn_SetFrame";
            this.btn_SetFrame.Size = new System.Drawing.Size(75, 23);
            this.btn_SetFrame.TabIndex = 15;
            this.btn_SetFrame.Text = "Set Frame";
            this.btn_SetFrame.UseVisualStyleBackColor = true;
            this.btn_SetFrame.Click += new System.EventHandler(this.btn_SetFrame_Click);
            // 
            // btn_SetAnimation
            // 
            this.btn_SetAnimation.Location = new System.Drawing.Point(97, 263);
            this.btn_SetAnimation.Name = "btn_SetAnimation";
            this.btn_SetAnimation.Size = new System.Drawing.Size(108, 23);
            this.btn_SetAnimation.TabIndex = 9;
            this.btn_SetAnimation.Text = "Set Animation";
            this.btn_SetAnimation.UseVisualStyleBackColor = true;
            this.btn_SetAnimation.Click += new System.EventHandler(this.btn_SetAnimation_Click);
            // 
            // btn_GridTool
            // 
            this.btn_GridTool.Location = new System.Drawing.Point(137, 572);
            this.btn_GridTool.Name = "btn_GridTool";
            this.btn_GridTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_GridTool.Size = new System.Drawing.Size(131, 23);
            this.btn_GridTool.TabIndex = 17;
            this.btn_GridTool.Text = "Add Frames with Grid";
            this.btn_GridTool.UseVisualStyleBackColor = true;
            this.btn_GridTool.Click += new System.EventHandler(this.btn_GridTool_Click);
            // 
            // btn_CloneFrame
            // 
            this.btn_CloneFrame.Location = new System.Drawing.Point(164, 525);
            this.btn_CloneFrame.Name = "btn_CloneFrame";
            this.btn_CloneFrame.Size = new System.Drawing.Size(83, 23);
            this.btn_CloneFrame.TabIndex = 16;
            this.btn_CloneFrame.Text = "Clone Frame";
            this.btn_CloneFrame.UseVisualStyleBackColor = true;
            this.btn_CloneFrame.Click += new System.EventHandler(this.btn_CloneFrame_Click);
            // 
            // btn_FrameBackgroundColor
            // 
            this.btn_FrameBackgroundColor.Location = new System.Drawing.Point(331, 663);
            this.btn_FrameBackgroundColor.Name = "btn_FrameBackgroundColor";
            this.btn_FrameBackgroundColor.Size = new System.Drawing.Size(109, 23);
            this.btn_FrameBackgroundColor.TabIndex = 21;
            this.btn_FrameBackgroundColor.Text = "Background Color";
            this.btn_FrameBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_FrameBackgroundColor.Click += new System.EventHandler(this.btn_FrameBackgroundColor_Click);
            // 
            // btn_TextureBackgroundColor
            // 
            this.btn_TextureBackgroundColor.Location = new System.Drawing.Point(332, 334);
            this.btn_TextureBackgroundColor.Name = "btn_TextureBackgroundColor";
            this.btn_TextureBackgroundColor.Size = new System.Drawing.Size(108, 23);
            this.btn_TextureBackgroundColor.TabIndex = 19;
            this.btn_TextureBackgroundColor.Text = "Background Color";
            this.btn_TextureBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_TextureBackgroundColor.Click += new System.EventHandler(this.btn_TextureBackgroundColor_Click);
            // 
            // lbl_MouseState
            // 
            this.lbl_MouseState.AutoSize = true;
            this.lbl_MouseState.Location = new System.Drawing.Point(821, 335);
            this.lbl_MouseState.Name = "lbl_MouseState";
            this.lbl_MouseState.Size = new System.Drawing.Size(67, 13);
            this.lbl_MouseState.TabIndex = 83;
            this.lbl_MouseState.Text = "Mouse State";
            // 
            // lbl_MousePositionLabel
            // 
            this.lbl_MousePositionLabel.AutoSize = true;
            this.lbl_MousePositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MousePositionLabel.Location = new System.Drawing.Point(718, 335);
            this.lbl_MousePositionLabel.Name = "lbl_MousePositionLabel";
            this.lbl_MousePositionLabel.Size = new System.Drawing.Size(97, 13);
            this.lbl_MousePositionLabel.TabIndex = 84;
            this.lbl_MousePositionLabel.Text = "Mouse Position:";
            // 
            // btn_FrameColor
            // 
            this.btn_FrameColor.Location = new System.Drawing.Point(446, 334);
            this.btn_FrameColor.Name = "btn_FrameColor";
            this.btn_FrameColor.Size = new System.Drawing.Size(75, 23);
            this.btn_FrameColor.TabIndex = 20;
            this.btn_FrameColor.Text = "Frame Color";
            this.btn_FrameColor.UseVisualStyleBackColor = true;
            this.btn_FrameColor.Click += new System.EventHandler(this.btn_FrameColor_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_SetFrameNumber
            // 
            this.btn_SetFrameNumber.Location = new System.Drawing.Point(176, 4);
            this.btn_SetFrameNumber.Name = "btn_SetFrameNumber";
            this.btn_SetFrameNumber.Size = new System.Drawing.Size(33, 23);
            this.btn_SetFrameNumber.TabIndex = 16;
            this.btn_SetFrameNumber.Text = "Set";
            this.btn_SetFrameNumber.UseVisualStyleBackColor = true;
            this.btn_SetFrameNumber.Click += new System.EventHandler(this.btn_SetFrameNumber_Click);
            // 
            // saveAndExitToolStripMenuItem
            // 
            this.saveAndExitToolStripMenuItem.Name = "saveAndExitToolStripMenuItem";
            this.saveAndExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAndExitToolStripMenuItem.Text = "Save and Exit";
            this.saveAndExitToolStripMenuItem.Click += new System.EventHandler(this.saveAndExitToolStripMenuItem_Click);
            // 
            // btn_SaveAll
            // 
            this.btn_SaveAll.Location = new System.Drawing.Point(172, 0);
            this.btn_SaveAll.Name = "btn_SaveAll";
            this.btn_SaveAll.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAll.TabIndex = 85;
            this.btn_SaveAll.Text = "Save All";
            this.btn_SaveAll.UseVisualStyleBackColor = true;
            this.btn_SaveAll.Click += new System.EventHandler(this.btn_SaveAll_Click);
            this.btn_SaveAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveAll_KeyDown);
            // 
            // EditAnimationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 698);
            this.Controls.Add(this.btn_SaveAll);
            this.Controls.Add(this.btn_FrameColor);
            this.Controls.Add(this.lbl_MousePositionLabel);
            this.Controls.Add(this.lbl_MouseState);
            this.Controls.Add(this.btn_TextureBackgroundColor);
            this.Controls.Add(this.btn_FrameBackgroundColor);
            this.Controls.Add(this.btn_CloneFrame);
            this.Controls.Add(this.btn_GridTool);
            this.Controls.Add(this.btn_SetAnimation);
            this.Controls.Add(this.btn_SetFrame);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label_DisplayFrameCurrent);
            this.Controls.Add(this.panel_FrameDisplay);
            this.Controls.Add(this.lbl_Frames);
            this.Controls.Add(this.btn_SetSpriteSheet);
            this.Controls.Add(this.lbl_TextureName);
            this.Controls.Add(this.lbl_CurrentFrame);
            this.Controls.Add(this.btn_AddFrame);
            this.Controls.Add(this.panel_CurrentFrameInformation);
            this.Controls.Add(this.panel_AnimationInformation);
            this.Controls.Add(this.btn_RemoveFrame);
            this.Controls.Add(this.panel_XNA);
            this.Controls.Add(this.lbl_SpriteSheet);
            this.Controls.Add(this.txtBox_AnimationName);
            this.Controls.Add(this.lbl_AnimationName);
            this.Controls.Add(this.listBox_Frames);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "EditAnimationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAnimationWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Shown += new System.EventHandler(this.OnShown_Window);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditAnimationWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TextureDisplay)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.panel_XNA.ResumeLayout(false);
            this.panel_AnimationInformation.ResumeLayout(false);
            this.panel_AnimationInformation.PerformLayout();
            this.panel_CurrentFrameInformation.ResumeLayout(false);
            this.panel_CurrentFrameInformation.PerformLayout();
            this.panel_FrameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FrameDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_TextureDisplay;
        private System.Windows.Forms.ListBox listBox_Frames;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
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
        private System.Windows.Forms.Label lbl_Frames;
        private System.Windows.Forms.Panel panel_FrameDisplay;
        private System.Windows.Forms.PictureBox pictureBox_FrameDisplay;
        private System.Windows.Forms.Label label_DisplayFrameCurrent;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_SetFrame;
        private System.Windows.Forms.Button btn_SetAnimation;
        private System.Windows.Forms.TextBox txtBox_DefaultWidth;
        private System.Windows.Forms.TextBox txtBox_DefaultHeight;
        private System.Windows.Forms.Label lbl_DefaultWidth;
        private System.Windows.Forms.Label lbl_DefaultHeight;
        private System.Windows.Forms.Button btn_GridTool;
        private System.Windows.Forms.Button btn_CloneFrame;
        private System.Windows.Forms.Button btn_FrameBackgroundColor;
        private System.Windows.Forms.Button btn_TextureBackgroundColor;
        private System.Windows.Forms.Label lbl_MouseState;
        private System.Windows.Forms.Label lbl_MousePositionLabel;
        private System.Windows.Forms.Button btn_FrameColor;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_SetFrameNumber;
        private System.Windows.Forms.ToolStripMenuItem saveAndExitToolStripMenuItem;
        private System.Windows.Forms.Button btn_SaveAll;
    }
}