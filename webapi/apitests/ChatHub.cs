using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apitests
{
    public class ChatHub : Microsoft.AspNet.SignalR.Hub
    {
        public void Send(string to, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(to, message);
        }
    }
}
