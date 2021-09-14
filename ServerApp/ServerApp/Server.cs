using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    public class Server
    {
        private int port = 8005;
        private Socket listenSocket;
        private Socket handler;
        private bool isStartAnimate = false;

        public string IP { get; set; }

        public void StartServer()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(IP), port);
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listenSocket.Bind(ipPoint);
                listenSocket.Listen(10);

                while (true)
                {
                    handler = listenSocket.Accept();

                    string message;
                    while (true)
                    {
                        if (isStartAnimate)
                        {
                            message = "Start";
                            byte[] data = new byte[32];
                            data = Encoding.Unicode.GetBytes(message);
                            handler.Send(data);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void StartAnimate()
        {
            isStartAnimate = !isStartAnimate;
        }

        
    }
}
