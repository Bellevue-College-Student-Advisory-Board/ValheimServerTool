using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Views
{
    public interface IMainView
    {
        event EventHandler MainViewLoaded;
        event EventHandler MainViewClosed;
        event EventHandler MainViewMinimized;
        event EventHandler ViewGithubClicked;
        event EventHandler LaunchClicked;

        bool EnableWaitCursor { get; set; }

        void Close();
        void Minimize();
        void UpdateIPv4(string ipv4Address);
        void UpdateStateName(string stateName);
        void UpdateCopyright(string copyright);
        void LaunchGame(string steamPath, string arguments);
        void OpenLink(string url);
    }
}
