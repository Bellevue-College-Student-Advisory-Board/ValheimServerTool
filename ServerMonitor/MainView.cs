using ServerMonitor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerMonitor.Models.Views;

namespace ServerMonitor
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MainViewClosed;
        public event EventHandler StartGameClicked;

        public MainView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            pictureBoxValheimBanner.Image = Resources.valheim_background;
            pictureBoxStartGame.Image = Resources.start_game;
        }

        private void pictureBoxStartGame_Click(object sender, EventArgs e)
        {
            StartGameClicked?.Invoke(sender, e);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainViewClosed?.Invoke(sender, e);
        }
    }
}
