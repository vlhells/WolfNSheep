namespace WolfNSheepWinForms
{
    partial class FrmFirst
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
            this.BtnLoadGame = new System.Windows.Forms.Button();
            this.BtnLoadModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadGame
            // 
            this.BtnLoadGame.AutoSize = true;
            this.BtnLoadGame.Location = new System.Drawing.Point(134, 143);
            this.BtnLoadGame.Name = "BtnLoadGame";
            this.BtnLoadGame.Size = new System.Drawing.Size(226, 126);
            this.BtnLoadGame.TabIndex = 0;
            this.BtnLoadGame.Text = "Запустить игру";
            this.BtnLoadGame.UseVisualStyleBackColor = true;
            this.BtnLoadGame.Click += new System.EventHandler(this.BtnLoadGame_Click);
            // 
            // BtnLoadModel
            // 
            this.BtnLoadModel.AutoSize = true;
            this.BtnLoadModel.Location = new System.Drawing.Point(436, 143);
            this.BtnLoadModel.Name = "BtnLoadModel";
            this.BtnLoadModel.Size = new System.Drawing.Size(226, 126);
            this.BtnLoadModel.TabIndex = 1;
            this.BtnLoadModel.Text = "Запустить модель";
            this.BtnLoadModel.UseVisualStyleBackColor = true;
            this.BtnLoadModel.Click += new System.EventHandler(this.BtnLoadModel_Click);
            // 
            // FrmFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLoadModel);
            this.Controls.Add(this.BtnLoadGame);
            this.Name = "FrmFirst";
            this.Text = "FrmFirst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnLoadGame;
        private Button BtnLoadModel;
    }
}