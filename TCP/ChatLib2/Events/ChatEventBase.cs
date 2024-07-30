using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ChatLib2.Events;
using ChatLib2.Handlers;
using ChatLib2.Models;

namespace ChatLib2.Events
{
    public abstract class ChatEventBase
    {
        public abstract event EventHandler<ChatEventArgs>? Connected;
        public abstract event EventHandler<ChatEventArgs>? Disconnected;
        public abstract event EventHandler<ChatEventArgs>? Received;
    }
}
