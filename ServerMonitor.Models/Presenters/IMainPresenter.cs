using ServerMonitor.Models.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Presenters
{
    public interface IMainPresenter
    {
        public IMainView MainView { get; set; }
    }
}
