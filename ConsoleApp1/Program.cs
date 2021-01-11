using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TorControlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect("127.0.0.1", 9000);
            //Console.WriteLine("Enter Password: ");
            //string hashedPassword = "m1234"; //Console.ReadLine();
            //client.Send(Encoding.UTF8.GetBytes(string.Format("AUTHENTICATE \"{0}\"  \r\n", hashedPassword)));

            /*while (true)
            {
                Console.WriteLine("Host And Port: (ex: 127.0.0.1:9050)");
                string hostAndPort = Console.ReadLine();
                string[] info = hostAndPort.Split(':');
                if (info.Length == 2)
                {
                    string host = info[0];
                    int port = 0;
                    int.TryParse(info[1], out port);
                    if (port > 0)
                    {
                        try
                        {
                            client.Connect(host, port);
                            Console.Clear();
                            Console.WriteLine("conntect to {0} port {1}", host, port);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("We can stablish connection");
                        }
                    }
                }

            }*/


            //string response = "";
            byte[] buffer = new byte[512];

            AsyncCallback callback = null;
            callback = new AsyncCallback((IAsyncResult r) =>
            {
                int byteCount = client.EndReceive(r);
                if (byteCount > 0)
                {
                    Console.Write(Encoding.UTF8.GetString(buffer, 0, byteCount));
                }
                else {
                    Console.WriteLine("connection closed");
                    Environment.Exit(1);
                    return;
                }

                if (client.Available <= 0)
                {
                    Console.WriteLine();
                    Console.Write("> ");
                }
                
                client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, callback, client);

            });


            client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, callback, client);



            string command = "";
            do
            {
                command = Console.ReadLine();
                if (command == "q")
                    break;
                if (command == "clr")
                {
                    Console.Clear();
                    continue;
                }

                client.Send(Encoding.UTF8.GetBytes(command + "\r\n"));

            } while (command != "q");

            /*Console.WriteLine(comunicate(client, "GETINFO config-file \r\n"));
            Console.WriteLine(comunicate(client, "GETCONF SocksPort DataDirectory \r\n"));*/

            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}
