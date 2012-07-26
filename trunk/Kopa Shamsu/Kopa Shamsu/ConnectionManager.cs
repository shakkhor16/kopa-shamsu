using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Kopa_Shamsu
{
    class ConnectionManager
    {
        private UdpClient udpClient;
        private IPEndPoint ipEndPoint;
        private byte[] query = { 255, 255, 255, 255, 103, 101, 116, 115, 116, 97, 116, 117, 115 };

        public ConnectionManager(string hostName, int port)
        {
            IPAddress ipAddress = IPAddress.Parse(hostName);
            ipEndPoint = new IPEndPoint(ipAddress, port);
            udpClient = new UdpClient();
        }

        public String GetServerStatus()
        {
            udpClient.Connect(ipEndPoint);
            udpClient.Send(query, query.Length);

            byte[] response;
            response = udpClient.Receive(ref ipEndPoint);
            udpClient.Close();

            return Encoding.UTF8.GetString(response);
        }
    }
}
