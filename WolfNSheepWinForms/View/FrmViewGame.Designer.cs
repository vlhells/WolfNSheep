namespace WolfNSheepWinForms.View
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
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnW = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFieldDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            //this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnA
            // 
            this.BtnA.AutoSize = true;
            this.BtnA.Location = new System.Drawing.Point(620, 756);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(126, 115);
            this.BtnA.TabIndex = 8;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnW
            // 
            this.BtnW.AutoSize = true;
            this.BtnW.Location = new System.Drawing.Point(752, 689);
            this.BtnW.Name = "BtnW";
            this.BtnW.Size = new System.Drawing.Size(126, 115);
            this.BtnW.TabIndex = 9;
            this.BtnW.Text = "W";
            this.BtnW.UseVisualStyleBackColor = true;
            this.BtnW.Click += new System.EventHandler(this.BtnW_Click);
            // 
            // BtnD
            // 
            this.BtnD.AutoSize = true;
            this.BtnD.Location = new System.Drawing.Point(884, 756);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(126, 115);
            this.BtnD.TabIndex = 10;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnS
            // 
            this.BtnS.AutoSize = true;
            this.BtnS.Location = new System.Drawing.Point(752, 810);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(126, 115);
            this.BtnS.TabIndex = 11;
            this.BtnS.Text = "S";
            this.BtnS.UseVisualStyleBackColor = true;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // FrmViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnW);
            this.Controls.Add(this.BtnA);
            this.Name = "FrmViewGame";
            this.Text = "Волк и овцы";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawField);
            this.Controls.SetChildIndex(this.PbxFieldDraw, 0);
            this.Controls.SetChildIndex(this.BtnStart, 0);
            this.Controls.SetChildIndex(this.BtnA, 0);
            this.Controls.SetChildIndex(this.BtnW, 0);
            this.Controls.SetChildIndex(this.BtnD, 0);
            this.Controls.SetChildIndex(this.BtnS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFieldDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnA;
        private Button BtnW;
        private Button BtnD;
        private Button BtnS;
    }
}