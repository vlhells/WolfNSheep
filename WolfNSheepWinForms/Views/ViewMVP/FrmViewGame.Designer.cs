namespace WolvesAndSheep.View
{
    partial class FrmViewGame
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
            BtnA = new Button();
            BtnW = new Button();
            BtnS = new Button();
            BtnD = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxFieldDraw).BeginInit();
            SuspendLayout();
            // 
            // BtnA
            // 
            BtnA.Location = new Point(361, 363);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(58, 53);
            BtnA.TabIndex = 9;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnW
            // 
            BtnW.Location = new Point(425, 326);
            BtnW.Name = "BtnW";
            BtnW.Size = new Size(58, 53);
            BtnW.TabIndex = 10;
            BtnW.Text = "W";
            BtnW.UseVisualStyleBackColor = true;
            BtnW.Click += BtnW_Click;
            // 
            // BtnS
            // 
            BtnS.Location = new Point(425, 385);
            BtnS.Name = "BtnS";
            BtnS.Size = new Size(58, 53);
            BtnS.TabIndex = 11;
            BtnS.Text = "S";
            BtnS.UseVisualStyleBackColor = true;
            BtnS.Click += BtnS_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(489, 363);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(58, 53);
            BtnD.TabIndex = 12;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // FrmViewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnD);
            Controls.Add(BtnS);
            Controls.Add(BtnW);
            Controls.Add(BtnA);
            Name = "FrmViewGame";
            Text = "FrmViewGame";
            Paint += DrawField;
            Controls.SetChildIndex(BtnInitField, 0);
            Controls.SetChildIndex(PbxFieldDraw, 0);
            Controls.SetChildIndex(BtnStart, 0);
            Controls.SetChildIndex(BtnA, 0);
            Controls.SetChildIndex(BtnW, 0);
            Controls.SetChildIndex(BtnS, 0);
            Controls.SetChildIndex(BtnD, 0);
            ((System.ComponentModel.ISupportInitialize)PbxFieldDraw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnA;
        private Button BtnW;
        private Button BtnS;
        private Button BtnD;
    }
}