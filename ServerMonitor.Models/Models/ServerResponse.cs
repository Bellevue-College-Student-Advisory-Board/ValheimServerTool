using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMonitor.Models.Models
{
    public class ServerResponse
    {
        public string CurrentState { get; private set; }
        public string CurrentIPv4 { get; private set; }

        public ServerResponse(string currentState, string currentIPv4 = "0.0.0.0")
        {
            this.CurrentState = currentState;
            this.CurrentIPv4 = CurrentIPv4;
        }
    }
}
