namespace ServerMonitor
{
    partial class MainView
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
            this.pictureBoxValheimBanner = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValheimBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxValheimBanner
            // 
            this.pictureBoxValheimBanner.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxValheimBanner.Name = "pictureBoxValheimBanner";
            this.pictureBoxValheimBanner.Size = new System.Drawing.Size(719, 448);
            this.pictureBoxValheimBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxValheimBanner.TabIndex = 0;
            this.pictureBoxValheimBanner.TabStop = false;
            // 
            // pictureBoxStartGame
            // 
            this.pictureBoxStartGame.Location = new System.Drawing.Point(243, 143);
            this.pictureBoxStartGame.Name = "pictureBoxStartGame";
            this.pictureBoxStartGame.Size = new System.Drawing.Size(191, 54);
            this.pictureBoxStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStartGame.TabIndex = 1;
            this.pictureBoxStartGame.TabStop = false;
            this.pictureBoxStartGame.Click += new System.EventHandler(this.pictureBoxStartGame_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 453);
            this.Controls.Add(this.pictureBoxStartGame);
            this.Controls.Add(this.pictureBoxValheimBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValheimBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxValheimBanner;
        private System.Windows.Forms.PictureBox pictureBoxStartGame;
    }
}