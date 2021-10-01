using Amazon.EC2.Model;
using ServerMonitor.Models.Models;
using ServerMonitor.Models.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        public IMainView MainView { get; set; }

        /// <summary>
        /// Constructs a presenter for the main view using the given view and server presenter.
        /// </summary>
        /// <param name="mainView">The main form</param>
        /// <param name="serverPresenter">The presenter for the server form</param>
        public MainPresenter(IMainView mainView)
        {
            MainView = mainView;
            SubscribeToEvents();
        }

        /// <summary>
        /// Subscribe to form event handlers
        /// </summary>
        private void SubscribeToEvents()
        {
            MainView.MainViewLoaded += OnMainViewLoaded;
            MainView.MainViewClosed += OnMainViewClosed;
            MainView.MainViewMinimized += OnMainViewMinimized;
            MainView.LaunchClicked += OnLaunchClicked;
            MainView.ViewGithubClicked += OnViewGithubClicked;

            Server.Instance.ServerStateReceived += OnServerStateReceived;
            Server.Instance.ServerStarted += OnServerStarted;
            Server.Instance.ServerShutdown += OnServerShutdown;

        }

        private void OnViewGithubClicked(object sender, EventArgs e)
        {
            MainView.OpenLink("http://github.com/Bellevue-College-Discord/ValheimServerTool");
        }

        private void OnMainViewLoaded(object sender, EventArgs e)
        {
            MainView.UpdateStateName(Server.Instance.State);
            MainView.UpdateIPv4(Server.Instance.IPv4);
            MainView.UpdateCopyright($"© {DateTime.Now.Year}  Project Contributors");
        }

        private void OnMainViewMinimized(object sender, EventArgs e)
        {
            MainView.Minimize();
        }

        private void OnMainViewClosed(object sender, EventArgs e)
        {
            Server.Instance.Close();
            MainView.Close();
        }


        private void OnLaunchClicked(object sender, EventArgs e)
        {
            MainView.EnableWaitCursor = true;
            Server.Instance.Start();
        }

        private void OnServerShutdown(object sender, EventArgs e)
        {
            MainView.UpdateStateName(Server.Instance.State);
            MainView.UpdateIPv4(Server.Instance.IPv4);
        }

        private void OnServerStarted(object sender, EventArgs e)
        {
            MainView.UpdateStateName(Server.Instance.State);
            MainView.UpdateIPv4(Server.Instance.IPv4);

            MainView.LaunchGame(@"C:\Program Files (x86)\Steam\steam.exe", $"-applaunch 892970 +connect {Server.Instance.IPv4}:2456");
            MainView.EnableWaitCursor = false;
        }

        private void OnServerStateReceived(object sender, EventArgs e)
        {
            MainView.UpdateStateName(Server.Instance.State);
        }
    }
}
