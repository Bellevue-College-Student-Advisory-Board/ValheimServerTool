namespace ServerMonitor
{
    partial class ServerView
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
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.buttonCopyClipboard = new System.Windows.Forms.Button();
            this.labelInstanceStatus = new System.Windows.Forms.Label();
            this.labelInstanceState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxServerIP.Location = new System.Drawing.Point(162, 135);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.ReadOnly = true;
            this.textBoxServerIP.Size = new System.Drawing.Size(257, 27);
            this.textBoxServerIP.TabIndex = 1;
            // 
            // buttonCopyClipboard
            // 
            this.buttonCopyClipboard.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyClipboard.Location = new System.Drawing.Point(162, 168);
            this.buttonCopyClipboard.Name = "buttonCopyClipboard";
            this.buttonCopyClipboard.Size = new System.Drawing.Size(257, 35);
            this.buttonCopyClipboard.TabIndex = 2;
            this.buttonCopyClipboard.Text = "COPY TO CLIPBOARD";
            this.buttonCopyClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyClipboard.Click += new System.EventHandler(this.buttonCopyClipboard_Click);
            // 
            // labelInstanceStatus
            // 
            this.labelInstanceStatus.AutoSize = true;
            this.labelInstanceStatus.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstanceStatus.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelInstanceStatus.Location = new System.Drawing.Point(205, 32);
            this.labelInstanceStatus.Name = "labelInstanceStatus";
            this.labelInstanceStatus.Size = new System.Drawing.Size(147, 25);
            this.labelInstanceStatus.TabIndex = 3;
            this.labelInstanceStatus.Text = "Server Status: ";
            // 
            // labelInstanceState
            // 
            this.labelInstanceState.AutoSize = true;
            this.labelInstanceState.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstanceState.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelInstanceState.Location = new System.Drawing.Point(228, 76);
            this.labelInstanceState.Name = "labelInstanceState";
            this.labelInstanceState.Size = new System.Drawing.Size(107, 25);
            this.labelInstanceState.TabIndex = 3;
            this.labelInstanceState.Text = "STOPPED";
            // 
            // ServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(565, 283);
            this.Controls.Add(this.labelInstanceState);
            this.Controls.Add(this.labelInstanceStatus);
            this.Controls.Add(this.buttonCopyClipboard);
            this.Controls.Add(this.textBoxServerIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerView";
            this.Text = "ServerView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerView_FormClosed);
            this.Load += new System.EventHandler(this.ServerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.Button buttonCopyClipboard;
        private System.Windows.Forms.Label labelInstanceStatus;
        private System.Windows.Forms.Label labelInstanceState;
    }
}