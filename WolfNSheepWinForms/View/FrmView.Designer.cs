namespace WolfNSheepWinForms
{
    partial class FrmView
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
            TbxXSize = new TextBox();
            LblXSize = new Label();
            LblYSize = new Label();
            TbxYSize = new TextBox();
            BtnStart = new Button();
            PbxFieldDraw = new PictureBox();
            BtnA = new Button();
            BtnW = new Button();
            BtnD = new Button();
            BtnS = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxFieldDraw).BeginInit();
            SuspendLayout();
            // 
            // TbxXSize
            // 
            TbxXSize.Location = new Point(12, 29);
            TbxXSize.Name = "TbxXSize";
            TbxXSize.Size = new Size(103, 23);
            TbxXSize.TabIndex = 2;
            // 
            // LblXSize
            // 
            LblXSize.AutoSize = true;
            LblXSize.Location = new Point(9, 11);
            LblXSize.Name = "LblXSize";
            LblXSize.Size = new Size(106, 15);
            LblXSize.TabIndex = 3;
            LblXSize.Text = "Размер поля по x:";
            // 
            // LblYSize
            // 
            LblYSize.AutoSize = true;
            LblYSize.Location = new Point(9, 71);
            LblYSize.Name = "LblYSize";
            LblYSize.Size = new Size(106, 15);
            LblYSize.TabIndex = 4;
            LblYSize.Text = "Размер поля по y:";
            // 
            // TbxYSize
            // 
            TbxYSize.Location = new Point(12, 89);
            TbxYSize.Name = "TbxYSize";
            TbxYSize.Size = new Size(103, 23);
            TbxYSize.TabIndex = 5;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(9, 131);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(106, 37);
            BtnStart.TabIndex = 6;
            BtnStart.Text = "Начать игру!";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // PbxFieldDraw
            // 
            PbxFieldDraw.Location = new Point(167, 12);
            PbxFieldDraw.Name = "PbxFieldDraw";
            PbxFieldDraw.Size = new Size(600, 300);
            PbxFieldDraw.TabIndex = 7;
            PbxFieldDraw.TabStop = false;
            // 
            // BtnA
            // 
            BtnA.Location = new Point(279, 337);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(64, 58);
            BtnA.TabIndex = 8;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnW
            // 
            BtnW.Location = new Point(349, 316);
            BtnW.Name = "BtnW";
            BtnW.Size = new Size(64, 58);
            BtnW.TabIndex = 9;
            BtnW.Text = "W";
            BtnW.UseVisualStyleBackColor = true;
            BtnW.Click += BtnW_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(419, 337);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(64, 58);
            BtnD.TabIndex = 10;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // BtnS
            // 
            BtnS.Location = new Point(349, 380);
            BtnS.Name = "BtnS";
            BtnS.Size = new Size(64, 58);
            BtnS.TabIndex = 11;
            BtnS.Text = "S";
            BtnS.UseVisualStyleBackColor = true;
            BtnS.Click += BtnS_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnS);
            Controls.Add(BtnD);
            Controls.Add(BtnW);
            Controls.Add(BtnA);
            Controls.Add(PbxFieldDraw);
            Controls.Add(BtnStart);
            Controls.Add(TbxYSize);
            Controls.Add(LblYSize);
            Controls.Add(LblXSize);
            Controls.Add(TbxXSize);
            MaximizeBox = false;
            Name = "FrmView";
            Text = "Волк и овцы";
            Paint += Update;
            ((System.ComponentModel.ISupportInitialize)PbxFieldDraw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TbxXSize;
        private Label LblXSize;
        private Label LblYSize;
        private TextBox TbxYSize;
        private Button BtnStart;
        private PictureBox PbxFieldDraw;
        private Button BtnA;
        private Button BtnW;
        private Button BtnD;
        private Button BtnS;
    }
}