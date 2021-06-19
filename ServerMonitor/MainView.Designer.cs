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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.pictureBoxValheimLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxExitButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizeButton = new System.Windows.Forms.PictureBox();
            this.panelServerStats = new System.Windows.Forms.Panel();
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.labelServerState = new System.Windows.Forms.Label();
            this.labelSeparator2 = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.pictureBoxServerIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxLaunchButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxSerenityLogo = new System.Windows.Forms.PictureBox();
            this.panelCredits = new System.Windows.Forms.Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelViewGithub = new System.Windows.Forms.Label();
            this.pictureBoxGithubLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValheimLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeButton)).BeginInit();
            this.panelServerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaunchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerenityLogo)).BeginInit();
            this.panelCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithubLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxValheimLogo
            // 
            this.pictureBoxValheimLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxValheimLogo.Location = new System.Drawing.Point(297, -114);
            this.pictureBoxValheimLogo.MaximumSize = new System.Drawing.Size(500, 422);
            this.pictureBoxValheimLogo.Name = "pictureBoxValheimLogo";
            this.pictureBoxValheimLogo.Size = new System.Drawing.Size(500, 422);
            this.pictureBoxValheimLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxValheimLogo.TabIndex = 0;
            this.pictureBoxValheimLogo.TabStop = false;
            // 
            // pictureBoxExitButton
            // 
            this.pictureBoxExitButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExitButton.Location = new System.Drawing.Point(1044, 4);
            this.pictureBoxExitButton.MaximumSize = new System.Drawing.Size(54, 50);
            this.pictureBoxExitButton.Name = "pictureBoxExitButton";
            this.pictureBoxExitButton.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExitButton.TabIndex = 1;
            this.pictureBoxExitButton.TabStop = false;
            this.pictureBoxExitButton.Click += new System.EventHandler(this.pictureBoxExitButton_Click);
            // 
            // pictureBoxMinimizeButton
            // 
            this.pictureBoxMinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizeButton.Location = new System.Drawing.Point(981, 4);
            this.pictureBoxMinimizeButton.MaximumSize = new System.Drawing.Size(54, 50);
            this.pictureBoxMinimizeButton.Name = "pictureBoxMinimizeButton";
            this.pictureBoxMinimizeButton.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizeButton.TabIndex = 1;
            this.pictureBoxMinimizeButton.TabStop = false;
            this.pictureBoxMinimizeButton.Click += new System.EventHandler(this.pictureBoxMinimizeButton_Click);
            // 
            // panelServerStats
            // 
            this.panelServerStats.BackColor = System.Drawing.Color.White;
            this.panelServerStats.Controls.Add(this.labelServerAddress);
            this.panelServerStats.Controls.Add(this.labelServerState);
            this.panelServerStats.Controls.Add(this.labelSeparator2);
            this.panelServerStats.Controls.Add(this.labelSeparator);
            this.panelServerStats.Controls.Add(this.labelAddress);
            this.panelServerStats.Controls.Add(this.labelState);
            this.panelServerStats.Controls.Add(this.labelServerStatus);
            this.panelServerStats.Controls.Add(this.pictureBoxServerIcon);
            this.panelServerStats.Controls.Add(this.pictureBoxLaunchButton);
            this.panelServerStats.Controls.Add(this.pictureBoxSerenityLogo);
            this.panelServerStats.Location = new System.Drawing.Point(214, 197);
            this.panelServerStats.MaximumSize = new System.Drawing.Size(683, 292);
            this.panelServerStats.Name = "panelServerStats";
            this.panelServerStats.Size = new System.Drawing.Size(683, 292);
            this.panelServerStats.TabIndex = 2;
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.AutoSize = true;
            this.labelServerAddress.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelServerAddress.Location = new System.Drawing.Point(518, 165);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(58, 20);
            this.labelServerAddress.TabIndex = 3;
            this.labelServerAddress.Text = "0.0.0.0";
            // 
            // labelServerState
            // 
            this.labelServerState.AutoSize = true;
            this.labelServerState.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelServerState.Location = new System.Drawing.Point(518, 123);
            this.labelServerState.Name = "labelServerState";
            this.labelServerState.Size = new System.Drawing.Size(74, 20);
            this.labelServerState.TabIndex = 3;
            this.labelServerState.Text = "stopped";
            // 
            // labelSeparator2
            // 
            this.labelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeparator2.Location = new System.Drawing.Point(331, 191);
            this.labelSeparator2.Name = "labelSeparator2";
            this.labelSeparator2.Size = new System.Drawing.Size(320, 2);
            this.labelSeparator2.TabIndex = 3;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeparator.Location = new System.Drawing.Point(331, 146);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(320, 2);
            this.labelSeparator.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(351, 165);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(42, 20);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "IPv4";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelState.Location = new System.Drawing.Point(348, 123);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(50, 20);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelServerStatus.Location = new System.Drawing.Point(373, 78);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(135, 24);
            this.labelServerStatus.TabIndex = 3;
            this.labelServerStatus.Text = "Server Status";
            // 
            // pictureBoxServerIcon
            // 
            this.pictureBoxServerIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxServerIcon.Location = new System.Drawing.Point(331, 72);
            this.pictureBoxServerIcon.MaximumSize = new System.Drawing.Size(32, 32);
            this.pictureBoxServerIcon.Name = "pictureBoxServerIcon";
            this.pictureBoxServerIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxServerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxServerIcon.TabIndex = 1;
            this.pictureBoxServerIcon.TabStop = false;
            this.pictureBoxServerIcon.Click += new System.EventHandler(this.pictureBoxMinimizeButton_Click);
            // 
            // pictureBoxLaunchButton
            // 
            this.pictureBoxLaunchButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLaunchButton.Location = new System.Drawing.Point(382, 209);
            this.pictureBoxLaunchButton.MaximumSize = new System.Drawing.Size(181, 80);
            this.pictureBoxLaunchButton.Name = "pictureBoxLaunchButton";
            this.pictureBoxLaunchButton.Size = new System.Drawing.Size(161, 65);
            this.pictureBoxLaunchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLaunchButton.TabIndex = 1;
            this.pictureBoxLaunchButton.TabStop = false;
            this.pictureBoxLaunchButton.Click += new System.EventHandler(this.pictureBoxLaunchButton_Click);
            // 
            // pictureBoxSerenityLogo
            // 
            this.pictureBoxSerenityLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSerenityLogo.Location = new System.Drawing.Point(34, 72);
            this.pictureBoxSerenityLogo.MaximumSize = new System.Drawing.Size(245, 154);
            this.pictureBoxSerenityLogo.Name = "pictureBoxSerenityLogo";
            this.pictureBoxSerenityLogo.Size = new System.Drawing.Size(245, 154);
            this.pictureBoxSerenityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSerenityLogo.TabIndex = 1;
            this.pictureBoxSerenityLogo.TabStop = false;
            // 
            // panelCredits
            // 
            this.panelCredits.BackColor = System.Drawing.Color.White;
            this.panelCredits.Controls.Add(this.labelCopyright);
            this.panelCredits.Controls.Add(this.labelViewGithub);
            this.panelCredits.Controls.Add(this.pictureBoxGithubLogo);
            this.panelCredits.Location = new System.Drawing.Point(214, 513);
            this.panelCredits.MaximumSize = new System.Drawing.Size(683, 63);
            this.panelCredits.Name = "panelCredits";
            this.panelCredits.Size = new System.Drawing.Size(683, 63);
            this.panelCredits.TabIndex = 2;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCopyright.Location = new System.Drawing.Point(439, 23);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(224, 20);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "© 2021 Project Contributors";
            // 
            // labelViewGithub
            // 
            this.labelViewGithub.AutoSize = true;
            this.labelViewGithub.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelViewGithub.Location = new System.Drawing.Point(56, 23);
            this.labelViewGithub.Name = "labelViewGithub";
            this.labelViewGithub.Size = new System.Drawing.Size(129, 20);
            this.labelViewGithub.TabIndex = 3;
            this.labelViewGithub.Text = "View on Github";
            this.labelViewGithub.Click += new System.EventHandler(this.labelViewGithub_Click);
            // 
            // pictureBoxGithubLogo
            // 
            this.pictureBoxGithubLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGithubLogo.Location = new System.Drawing.Point(18, 15);
            this.pictureBoxGithubLogo.MaximumSize = new System.Drawing.Size(32, 32);
            this.pictureBoxGithubLogo.Name = "pictureBoxGithubLogo";
            this.pictureBoxGithubLogo.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxGithubLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGithubLogo.TabIndex = 1;
            this.pictureBoxGithubLogo.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1104, 646);
            this.Controls.Add(this.panelCredits);
            this.Controls.Add(this.panelServerStats);
            this.Controls.Add(this.pictureBoxMinimizeButton);
            this.Controls.Add(this.pictureBoxExitButton);
            this.Controls.Add(this.pictureBoxValheimLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1120, 685);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValheimLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeButton)).EndInit();
            this.panelServerStats.ResumeLayout(false);
            this.panelServerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaunchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerenityLogo)).EndInit();
            this.panelCredits.ResumeLayout(false);
            this.panelCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithubLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxValheimLogo;
        private System.Windows.Forms.PictureBox pictureBoxExitButton;
        private System.Windows.Forms.PictureBox pictureBoxMinimizeButton;
        private System.Windows.Forms.Panel panelServerStats;
        private System.Windows.Forms.Panel panelCredits;
        private System.Windows.Forms.PictureBox pictureBoxSerenityLogo;
        private System.Windows.Forms.PictureBox pictureBoxLaunchButton;
        private System.Windows.Forms.PictureBox pictureBoxGithubLogo;
        private System.Windows.Forms.Label labelViewGithub;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox pictureBoxServerIcon;
        private System.Windows.Forms.Label labelServerStatus;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelSeparator2;
        private System.Windows.Forms.Label labelServerState;
        private System.Windows.Forms.Label labelServerAddress;
    }
}