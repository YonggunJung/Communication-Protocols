using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ChatLib2.Handlers;
using ChatLib2.Models;

namespace ChatLib2.Events
{
    public class ChatEventArgs : EventArgs
    {
        public ChatEventArgs(ClientHandler clientHandler, ChatHub hub)
        {
            ClientHandler = clientHandler;
            Hub = hub;
        }

        public ClientHandler ClientHandler { get; }
        public ChatHub Hub { get; }
    }
}
