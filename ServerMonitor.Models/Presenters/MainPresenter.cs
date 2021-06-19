using ServerMonitor.Models.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        public IMainView MainView { get; set; }
        public IServerPresenter ServerPresenter { get; set; }

        /// <summary>
        /// Constructs a presenter for the main view using the given view and server presenter.
        /// </summary>
        /// <param name="mainView">The main form</param>
        /// <param name="serverPresenter">The presenter for the server form</param>
        public MainPresenter(IMainView mainView, IServerPresenter serverPresenter)
        {
            MainView = mainView;
            ServerPresenter = serverPresenter;

            SubscribeToEvents();
        }

        /// <summary>
        /// Subscribe to form event handlers
        /// </summary>
        private void SubscribeToEvents()
        {
            MainView.MainViewClosed += OnMainViewClosed;
            MainView.StartGameClicked += OnStartGameClicked;
        }

        private void OnMainViewClosed(object sender, EventArgs e)
        {
            ServerPresenter.ServerView.StopInstance();
        }

        private void OnStartGameClicked(object sender, EventArgs e)
        {
            ServerPresenter.ServerView.Show();
        }
    }
}
