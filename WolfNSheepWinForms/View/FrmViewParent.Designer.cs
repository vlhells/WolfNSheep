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
            TbxXSize = new TextBox();
            LblXSize = new Label();
            LblYSize = new Label();
            TbxYSize = new TextBox();
            BtnInitField = new Button();
            PbxFieldDraw = new PictureBox();
            BtnStart = new Button();
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
            // BtnInitField
            // 
            BtnInitField.Location = new Point(9, 131);
            BtnInitField.Name = "BtnInitField";
            BtnInitField.Size = new Size(128, 48);
            BtnInitField.TabIndex = 6;
            BtnInitField.Text = "Инициализировать поле";
            BtnInitField.UseVisualStyleBackColor = true;
            BtnInitField.Click += BtnInitField_Click;
            // 
            // PbxFieldDraw
            // 
            PbxFieldDraw.Location = new Point(167, 12);
            PbxFieldDraw.Name = "PbxFieldDraw";
            PbxFieldDraw.Size = new Size(600, 300);
            PbxFieldDraw.TabIndex = 7;
            PbxFieldDraw.TabStop = false;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(9, 196);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(128, 72);
            BtnStart.TabIndex = 8;
            BtnStart.Text = "Начать игру!";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // FrmViewParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnStart);
            Controls.Add(PbxFieldDraw);
            Controls.Add(BtnInitField);
            Controls.Add(TbxYSize);
            Controls.Add(LblYSize);
            Controls.Add(LblXSize);
            Controls.Add(TbxXSize);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmViewParent";
            Text = "FrmParentView";
            ((System.ComponentModel.ISupportInitialize)PbxFieldDraw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TbxXSize;
        private Label LblXSize;
        private Label LblYSize;
        private TextBox TbxYSize;
        public Button BtnInitField;
        public PictureBox PbxFieldDraw;
        public Button BtnStart;
    }
}