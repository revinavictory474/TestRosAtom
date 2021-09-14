using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Client
    {
        private IPEndPoint ipPoint;
        private Socket socket;
        static int port = 8005; 

        public string address { get; set; }

        public void StartConnection()
        {
            try
            {
                ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);

                byte[] data = new byte[256];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                string message = "ответ сервера: " + builder.ToString();

                
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex) { }
        }
    }
}
