using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Urban_Terror_Packet_Repair
{
    class UdpProxy
    {
        private string address;
        private int port;

        public static IPEndPoint listenEndpoint = null;
        public static EndPoint connectedClientEndpoint = null;
        public static IPEndPoint sendEndpoint = null;
        public static Socket listenSocket = null;
        public static Socket sendSocket = null;

        public UdpProxy(string address, int port)
        {
            this.address = address;
            this.port = port;
        }

        public void Start()
        {
            listenEndpoint = new IPEndPoint(IPAddress.Any, port);
            listenSocket = new Socket(listenEndpoint.Address.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            listenSocket.Bind(listenEndpoint);

            sendEndpoint = new System.Net.IPEndPoint(IPAddress.Parse(address), port);
            connectedClientEndpoint = new System.Net.IPEndPoint(IPAddress.Any, port);

            ThreadSafeSingleton singleton = ThreadSafeSingleton.Instance;
            byte[] data = new byte[65535];

            while (!singleton.IsTimeToExit)
            {
                if (listenSocket.Available > 0)
                {

                    int size = listenSocket.ReceiveFrom(data, ref connectedClientEndpoint);

                    if (sendSocket == null)
                    {
                        sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    }

                    sendSocket.SendTo(data, size, SocketFlags.None, sendEndpoint);

                }

                if (sendSocket != null && sendSocket.Available > 0)
                {
                    int size = sendSocket.Receive(data);

                    listenSocket.SendTo(data, size, SocketFlags.None, connectedClientEndpoint);

                }
            }
        }
    }
}
