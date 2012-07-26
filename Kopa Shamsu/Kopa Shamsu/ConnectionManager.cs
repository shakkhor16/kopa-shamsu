using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Kopa_Shamsu
{
    internal class ConnectionManager
    {
        private readonly byte[] query = {255, 255, 255, 255, 103, 101, 116, 115, 116, 97, 116, 117, 115};
        private readonly UdpClient udpClient;
        private IPEndPoint ipEndPoint;

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