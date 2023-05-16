namespace WolfNSheepWinForms
{
    partial class FrmViewParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbxXSize = new System.Windows.Forms.TextBox();
            this.LblXSize = new System.Windows.Forms.Label();
            this.LblYSize = new System.Windows.Forms.Label();
            this.TbxYSize = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.PbxFieldDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFieldDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxXSize
            // 
            this.TbxXSize.Location = new System.Drawing.Point(22, 62);
            this.TbxXSize.Margin = new System.Windows.Forms.Padding(6);
            this.TbxXSize.Name = "TbxXSize";
            this.TbxXSize.Size = new System.Drawing.Size(188, 39);
            this.TbxXSize.TabIndex = 2;
            // 
            // LblXSize
            // 
            this.LblXSize.AutoSize = true;
            this.LblXSize.Location = new System.Drawing.Point(17, 23);
            this.LblXSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblXSize.Name = "LblXSize";
            this.LblXSize.Size = new System.Drawing.Size(212, 32);
            this.LblXSize.TabIndex = 3;
            this.LblXSize.Text = "Размер поля по x:";
            // 
            // LblYSize
            // 
            this.LblYSize.AutoSize = true;
            this.LblYSize.Location = new System.Drawing.Point(17, 151);
            this.LblYSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblYSize.Name = "LblYSize";
            this.LblYSize.Size = new System.Drawing.Size(213, 32);
            this.LblYSize.TabIndex = 4;
            this.LblYSize.Text = "Размер поля по y:";
            // 
            // TbxYSize
            // 
            this.TbxYSize.Location = new System.Drawing.Point(22, 190);
            this.TbxYSize.Margin = new System.Windows.Forms.Padding(6);
            this.TbxYSize.Name = "TbxYSize";
            this.TbxYSize.Size = new System.Drawing.Size(188, 39);
            this.TbxYSize.TabIndex = 5;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(17, 279);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(6);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(197, 79);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Начать игру!";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PbxFieldDraw
            // 
            this.PbxFieldDraw.Location = new System.Drawing.Point(310, 26);
            this.PbxFieldDraw.Margin = new System.Windows.Forms.Padding(6);
            this.PbxFieldDraw.Name = "PbxFieldDraw";
            this.PbxFieldDraw.Size = new System.Drawing.Size(1114, 640);
            this.PbxFieldDraw.TabIndex = 7;
            this.PbxFieldDraw.TabStop = false;
            // 
            // FrmViewParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.PbxFieldDraw);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TbxYSize);
            this.Controls.Add(this.LblYSize);
            this.Controls.Add(this.LblXSize);
            this.Controls.Add(this.TbxXSize);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmViewParent";
            this.Text = "FrmParentView";
            ((System.ComponentModel.ISupportInitialize)(this.PbxFieldDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TbxXSize;
        private Label LblXSize;
        private Label LblYSize;
        private TextBox TbxYSize;
        public Button BtnStart;
        public PictureBox PbxFieldDraw;
    }
}