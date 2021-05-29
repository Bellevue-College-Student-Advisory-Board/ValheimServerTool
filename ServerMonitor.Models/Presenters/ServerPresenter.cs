using ServerMonitor.Models.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Presenters
{
    public class ServerPresenter : IServerPresenter
    {
        public IServerView ServerView { get; set; }

        /// <summary>
        /// Constructs a presenter for the server view using the given view.
        /// </summary>
        /// <param name="serverView">The server form</param>
        public ServerPresenter(IServerView serverView)
        {
            ServerView = serverView;
            SubscribeToEvents();
        }

        /// <summary>
        /// Subscribe to form event handlers
        /// </summary>
        private void SubscribeToEvents()
        {
            ServerView.ServerViewLoaded += OnServerViewLoaded;
            ServerView.ServerViewClosed += OnServerViewClosed;
            
        }

        private void OnServerViewClosed(object sender, EventArgs e)
        {
            ServerView.Hide();
        }

        private void OnServerViewLoaded(object sender, EventArgs e)
        {
            ServerView.StartInstance();
        }
    }
}
