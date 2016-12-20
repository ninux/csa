using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TestServer
{
    class SimpleHttpServer
    {
        public static void Main()
        {
            TcpListener listen = new TcpListener(IPAddress.Any, 8080);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " + listen.LocalEndpoint + "...");
                new Thread(new HttpHandler(listen.AcceptTcpClient()).Do).Start();
            }
        }

    }
}
