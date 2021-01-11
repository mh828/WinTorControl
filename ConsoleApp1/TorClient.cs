using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TorControlClient
{
    class TorClient
    {
        Socket Client;
        ManualResetEvent SendDone = new ManualResetEvent(false);
        ManualResetEvent RecieveDone = new ManualResetEvent(false);

        public TorClient(EndPoint endPoint )
        {
            Client = new Socket(SocketType.Stream, ProtocolType.Tcp);
            Client.BeginConnect(endPoint, BeginConnect, Client);
        }

        void BeginConnect(IAsyncResult result)
        {
            Client.EndConnect(result);
        }

        public void shoutDown()
        {
            Client.Shutdown(SocketShutdown.Both);
            Client.Close();
        }
    }
}
