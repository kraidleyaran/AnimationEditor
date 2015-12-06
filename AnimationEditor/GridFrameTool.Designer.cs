namespace AnimationEditor
{
    partial class GridFrameTool
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
            this.lbl_StartPositionX = new System.Windows.Forms.Label();
            this.lbl_StartPositionY = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Rows = new System.Windows.Forms.Label();
            this.lbl_Columns = new System.Windows.Forms.Label();
            this.lbl_WidthSpacing = new System.Windows.Forms.Label();
            this.txtBox_StartPositionX = new System.Windows.Forms.TextBox();
            this.txtBox_StartPositionY = new System.Windows.Forms.TextBox();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.txtBox_Rows = new System.Windows.Forms.TextBox();
            this.txtBox_Columns = new System.Windows.Forms.TextBox();
            this.txtBox_WidthSpacing = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_HeightSpacing = new System.Windows.Forms.Label();
            this.txtBox_HeightSpacing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_StartPositionX
            // 
            this.lbl_StartPositionX.AutoSize = true;
            this.lbl_StartPositionX.Location = new System.Drawing.Point(57, 15);
            this.lbl_StartPositionX.Name = "lbl_StartPositionX";
            this.lbl_StartPositionX.Size = new System.Drawing.Size(39, 13);
            this.lbl_StartPositionX.TabIndex = 0;
            this.lbl_StartPositionX.Text = "Start X";
            // 
            // lbl_StartPositionY
            // 
            this.lbl_StartPositionY.AutoSize = true;
            this.lbl_StartPositionY.Location = new System.Drawing.Point(57, 41);
            this.lbl_StartPositionY.Name = "lbl_StartPositionY";
            this.lbl_StartPositionY.Size = new System.Drawing.Size(39, 13);
            this.lbl_StartPositionY.TabIndex = 1;
            this.lbl_StartPositionY.Text = "Start Y";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(57, 67);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 2;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(60, 93);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 3;
            this.lbl_Width.Text = "Width";
            // 
            // lbl_Rows
            // 
            this.lbl_Rows.AutoSize = true;
            this.lbl_Rows.Location = new System.Drawing.Point(62, 172);
            this.lbl_Rows.Name = "lbl_Rows";
            this.lbl_Rows.Size = new System.Drawing.Size(34, 13);
            this.lbl_Rows.TabIndex = 4;
            this.lbl_Rows.Text = "Rows";
            // 
            // lbl_Columns
            // 
            this.lbl_Columns.AutoSize = true;
            this.lbl_Columns.Location = new System.Drawing.Point(49, 198);
            this.lbl_Columns.Name = "lbl_Columns";
            this.lbl_Columns.Size = new System.Drawing.Size(47, 13);
            this.lbl_Columns.TabIndex = 5;
            this.lbl_Columns.Text = "Columns";
            // 
            // lbl_WidthSpacing
            // 
            this.lbl_WidthSpacing.AutoSize = true;
            this.lbl_WidthSpacing.Location = new System.Drawing.Point(20, 145);
            this.lbl_WidthSpacing.Name = "lbl_WidthSpacing";
            this.lbl_WidthSpacing.Size = new System.Drawing.Size(77, 13);
            this.lbl_WidthSpacing.TabIndex = 6;
            this.lbl_WidthSpacing.Text = "Width Spacing";
            // 
            // txtBox_StartPositionX
            // 
            this.txtBox_StartPositionX.Location = new System.Drawing.Point(111, 12);
            this.txtBox_StartPositionX.Name = "txtBox_StartPositionX";
            this.txtBox_StartPositionX.Size = new System.Drawing.Size(128, 20);
            this.txtBox_StartPositionX.TabIndex = 1;
            this.txtBox_StartPositionX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_StartPositionY
            // 
            this.txtBox_StartPositionY.Location = new System.Drawing.Point(111, 38);
            this.txtBox_StartPositionY.Name = "txtBox_StartPositionY";
            this.txtBox_StartPositionY.Size = new System.Drawing.Size(128, 20);
            this.txtBox_StartPositionY.TabIndex = 2;
            this.txtBox_StartPositionY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(110, 90);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Width.TabIndex = 4;
            this.txtBox_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Location = new System.Drawing.Point(111, 64);
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Height.TabIndex = 3;
            this.txtBox_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_Rows
            // 
            this.txtBox_Rows.Location = new System.Drawing.Point(110, 169);
            this.txtBox_Rows.Name = "txtBox_Rows";
            this.txtBox_Rows.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Rows.TabIndex = 7;
            this.txtBox_Rows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_Columns
            // 
            this.txtBox_Columns.Location = new System.Drawing.Point(110, 195);
            this.txtBox_Columns.Name = "txtBox_Columns";
            this.txtBox_Columns.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Columns.TabIndex = 8;
            this.txtBox_Columns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // txtBox_WidthSpacing
            // 
            this.txtBox_WidthSpacing.Location = new System.Drawing.Point(111, 142);
            this.txtBox_WidthSpacing.Name = "txtBox_WidthSpacing";
            this.txtBox_WidthSpacing.Size = new System.Drawing.Size(128, 20);
            this.txtBox_WidthSpacing.TabIndex = 6;
            this.txtBox_WidthSpacing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(52, 238);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(136, 238);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_HeightSpacing
            // 
            this.lbl_HeightSpacing.AutoSize = true;
            this.lbl_HeightSpacing.Location = new System.Drawing.Point(16, 119);
            this.lbl_HeightSpacing.Name = "lbl_HeightSpacing";
            this.lbl_HeightSpacing.Size = new System.Drawing.Size(80, 13);
            this.lbl_HeightSpacing.TabIndex = 16;
            this.lbl_HeightSpacing.Text = "Height Spacing";
            // 
            // txtBox_HeightSpacing
            // 
            this.txtBox_HeightSpacing.Location = new System.Drawing.Point(110, 116);
            this.txtBox_HeightSpacing.Name = "txtBox_HeightSpacing";
            this.txtBox_HeightSpacing.Size = new System.Drawing.Size(128, 20);
            this.txtBox_HeightSpacing.TabIndex = 5;
            this.txtBox_HeightSpacing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Numbers_NoDecimal_KeyPress);
            // 
            // GridFrameTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 273);
            this.Controls.Add(this.txtBox_HeightSpacing);
            this.Controls.Add(this.lbl_HeightSpacing);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtBox_WidthSpacing);
            this.Controls.Add(this.txtBox_Columns);
            this.Controls.Add(this.txtBox_Rows);
            this.Controls.Add(this.txtBox_Height);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.txtBox_StartPositionY);
            this.Controls.Add(this.txtBox_StartPositionX);
            this.Controls.Add(this.lbl_WidthSpacing);
            this.Controls.Add(this.lbl_Columns);
            this.Controls.Add(this.lbl_Rows);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_StartPositionY);
            this.Controls.Add(this.lbl_StartPositionX);
            this.Name = "GridFrameTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridFrameTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StartPositionX;
        private System.Windows.Forms.Label lbl_StartPositionY;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Rows;
        private System.Windows.Forms.Label lbl_Columns;
        private System.Windows.Forms.Label lbl_WidthSpacing;
        private System.Windows.Forms.TextBox txtBox_StartPositionX;
        private System.Windows.Forms.TextBox txtBox_StartPositionY;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.TextBox txtBox_Rows;
        private System.Windows.Forms.TextBox txtBox_Columns;
        private System.Windows.Forms.TextBox txtBox_WidthSpacing;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_HeightSpacing;
        private System.Windows.Forms.TextBox txtBox_HeightSpacing;
    }
}