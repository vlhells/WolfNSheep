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
            BtnLoadGame = new Button();
            BtnLoadModel = new Button();
            SuspendLayout();
            // 
            // BtnLoadGame
            // 
            BtnLoadGame.AutoSize = true;
            BtnLoadGame.Location = new Point(72, 67);
            BtnLoadGame.Margin = new Padding(2, 1, 2, 1);
            BtnLoadGame.Name = "BtnLoadGame";
            BtnLoadGame.Size = new Size(122, 59);
            BtnLoadGame.TabIndex = 0;
            BtnLoadGame.Text = "Запустить игру";
            BtnLoadGame.UseVisualStyleBackColor = true;
            BtnLoadGame.Click += BtnLoadGame_Click;
            // 
            // BtnLoadModel
            // 
            BtnLoadModel.AutoSize = true;
            BtnLoadModel.Location = new Point(235, 67);
            BtnLoadModel.Margin = new Padding(2, 1, 2, 1);
            BtnLoadModel.Name = "BtnLoadModel";
            BtnLoadModel.Size = new Size(124, 59);
            BtnLoadModel.TabIndex = 1;
            BtnLoadModel.Text = "Запустить автоигру";
            BtnLoadModel.UseVisualStyleBackColor = true;
            BtnLoadModel.Click += BtnLoadModel_Click;
            // 
            // FrmFirst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(BtnLoadModel);
            Controls.Add(BtnLoadGame);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(447, 250);
            Name = "FrmFirst";
            Text = "FrmFirst";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLoadGame;
        private Button BtnLoadModel;
    }
}