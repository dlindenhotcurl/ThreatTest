
using System.Net;
using System.Net.Sockets;

namespace threat_test
{
    class UdpState
    {
        public UdpClient u;
        public IPEndPoint e;

        public UdpState(UdpClient client, IPEndPoint endPoint)
        {
            u = client;
            e = endPoint;
        }
    }
}
