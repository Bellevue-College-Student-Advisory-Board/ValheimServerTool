using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Models
{
    public interface IServer
    {
        event EventHandler ServerStateReceived;
        event EventHandler ServerStarted;
        event EventHandler ServerShutdown;

        public string IPv4 { get; }
        public string State { get; }
        void Start();
        void Close();

        
    }
}
