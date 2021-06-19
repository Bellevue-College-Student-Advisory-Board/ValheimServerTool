using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Views
{
    public interface IMainView
    {
        event EventHandler MainViewClosed;
        event EventHandler StartGameClicked;
    }
}
