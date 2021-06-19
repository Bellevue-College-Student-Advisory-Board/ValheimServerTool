using System;

namespace ServerMonitor.Models.Views
{
    public interface IServerView
    {
        event EventHandler ServerViewLoaded;
        event EventHandler ServerViewClosed;

        void Show();
        void Hide();
        void StartInstance();
        void StopInstance();
    }
}