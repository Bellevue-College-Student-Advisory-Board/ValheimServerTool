using ServerMonitor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerMonitor.Models.Views;
using System.Diagnostics;

namespace ServerMonitor
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MainViewLoaded;
        public event EventHandler MainViewClosed;
        public event EventHandler MainViewMinimized;
        public event EventHandler ViewGithubClicked;
        public event EventHandler LaunchClicked;

        public bool EnableWaitCursor 
        { 
            get => this.UseWaitCursor; 
            set => this.UseWaitCursor = value; 
        }

        public MainView()
        {
            InitializeComponent();
            InitializePictureBoxes();
        }

        private void InitializePictureBoxes()
        {
            this.BackgroundImage = Resources.valheim_background_1120x685;
            pictureBoxValheimLogo.Image = Resources.valheim_logo;
            pictureBoxExitButton.Image = Resources.exit_button;
            pictureBoxMinimizeButton.Image = Resources.minimize_button;
            pictureBoxSerenityLogo.Image = Resources.serenity_logo;
            pictureBoxLaunchButton.Image = Resources.launch_button;
            pictureBoxGithubLogo.Image = Resources.github_icon;
            pictureBoxServerIcon.Image = Resources.server_icon;
        }

        public void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Close()
        {
            Application.Exit();
        }

        public void UpdateIPv4(string ipv4Address)
        {
            labelServerAddress.Text = ipv4Address;
        }

        public void UpdateStateName(string stateName)
        {
            labelServerState.Text = stateName;
        }

        public void UpdateCopyright(string copyright)
        {
            labelCopyright.Text = copyright;
        }
        public void LaunchGame(string steamPath, string arguments)
        {
            ProcessStartInfo steamProcess = new ProcessStartInfo(steamPath, arguments);
            Process.Start(steamProcess);
        }

        public void OpenLink(string url)
        {
            ProcessStartInfo openLink = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(openLink);
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            MainViewLoaded?.Invoke(sender, e);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainViewClosed?.Invoke(sender, e);
        }

        private void pictureBoxExitButton_Click(object sender, EventArgs e)
        {
            MainViewClosed?.Invoke(sender, e);
        }

        private void pictureBoxMinimizeButton_Click(object sender, EventArgs e)
        {
            MainViewMinimized?.Invoke(sender, e);
        }

        private void labelViewGithub_Click(object sender, EventArgs e)
        {
            ViewGithubClicked?.Invoke(sender, e);
        }

        private void pictureBoxLaunchButton_Click(object sender, EventArgs e)
        {
            LaunchClicked?.Invoke(sender, e);
        }
    }
}
