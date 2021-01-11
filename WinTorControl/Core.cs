using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinTorControl
{
    class Core : IDisposable
    {
        public event Action<string> OnMessage;
        public event Action<Exception> OnConnectionClose;
        public event Action<string> OnEventNotification;
        
        string message = string.Empty;
        Socket client;
        byte[] buffer = new byte[512];

        public bool connect(string host, int port)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(host, port);

                client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, reciveInfo, client);

                return true;

            }
            catch (Exception ex)
            {
                if (OnConnectionClose != null)
                    OnConnectionClose(ex);
            }

            return false;
        }


        void reciveInfo(IAsyncResult result)
        {
            try
            {
                int byteCount = client.EndReceive(result);
                if (byteCount > 0)
                {
                    message += Encoding.UTF8.GetString(buffer, 0, byteCount);
                   
                }
                else
                {
                    throw new Exception("connection closed");
                }

                if(client.Available == 0)
                {
                    foreach (var item in message.Split("\r\n"))
                    {
                        if (string.IsNullOrWhiteSpace(item))
                            continue;

                        if (item.Trim().StartsWith("650"))
                        {
                            if (OnEventNotification != null)
                                OnEventNotification(item);
                        }
                        else if (OnMessage != null)
                            OnMessage.Invoke(item);
                    }                   

                    message = string.Empty;
                }

                client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, reciveInfo, client);
            }
            catch (Exception ex)
            {
                if (OnConnectionClose != null)
                    OnConnectionClose(ex);
            }
        }

        public void command(string command)
        {
            client.Send(Encoding.UTF8.GetBytes(command + "\r\n"));
        }

        void close()
        {
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            client.Dispose();
        }

        void IDisposable.Dispose()
        {
            this.close();
        }
    }
}
