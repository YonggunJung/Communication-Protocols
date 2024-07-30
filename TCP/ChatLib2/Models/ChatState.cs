using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ChatLib2.Events;
using ChatLib2.Handlers;


namespace ChatLib2.Models
{
    public enum ChatState
    {
        None, Initial, Connect, Disconnect
    }
}
