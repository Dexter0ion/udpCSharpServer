using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
namespace udpCSharpServer
{
    class SocketConnect
    {
        private string serverIp;
        private int serverPort;
        private string clientIp;
        private int clientPort;
        private IPAddress remoteIP;
        private IPEndPoint remotePoint;
        private string sendString;
        private byte[] sendData;
        string receiveString;
        byte[] receiveData;


        public SocketConnect()
        {
            serverIp = null;
            serverPort = 0;
            clientIp = null;
            clientPort = 0;
        }
        public SocketConnect(string serverIp_, int serverPort_)
        {
            serverIp = serverIp_;
            serverPort = serverPort_;
            clientIp = null;
            clientPort = 0;
        }
        public SocketConnect(string serverIp_, int serverPort_, string clientIp_, int clientPort_)
        {
            serverIp = serverIp_;
            serverPort = serverPort_;
            clientIp = clientIp_;
            clientPort = clientPort_;
        }

        public void initSocketIpConnect()
        {

                //client to server
                remoteIP = IPAddress.Parse(serverIp);
                int remotePort = serverPort;
                remotePoint = new IPEndPoint(remoteIP, remotePort);
            
            /*
            if(mode == "Server2Client")
            {
                //server to client
                remoteIP = IPAddress.Parse(clientIp);
                int remotePort = clientPort;
                remotePoint = new IPEndPoint(remoteIP, remotePort);
            }*/
        }

        public void initSocketIpConnectServer()
        {

            //client to server
            remoteIP = IPAddress.Parse(clientIp);
            int remotePort = clientPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);

            /*
            if(mode == "Server2Client")
            {
                //server to client
                remoteIP = IPAddress.Parse(clientIp);
                int remotePort = clientPort;
                remotePoint = new IPEndPoint(remoteIP, remotePort);
            }*/
        }

        public void sentData(string msg)
        {
            sendString = msg;
            sendData = Encoding.Default.GetBytes(sendString);

            UdpClient client = null;
            client = new UdpClient();
            client.Send(sendData, sendData.Length, remotePoint); //发送数据至远程端口
            client.Close();
        }

        public string listenStr()
        {
            UdpClient client = new UdpClient(serverPort);
            receiveData = client.Receive(ref remotePoint);
            receiveString = Encoding.Default.GetString(receiveData);
            string msgListen = receiveString;
            client.Close();
            return msgListen;
        }

        public void sendFile(string filePath)
        {
            remoteIP = IPAddress.Parse(clientIp);
            int remotePort = clientPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fileData = br.ReadBytes(Convert.ToInt32(fs.Length));

            UdpClient client = null;
            client = new UdpClient();

            client.Send(fileData, fileData.Length, remotePoint);
        }

        public string recvFile()
        {
            remoteIP = IPAddress.Parse(serverIp);
            int remotePort =serverPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
            UdpClient client = new UdpClient(clientPort);
            receiveData = client.Receive(ref remotePoint);
            receiveString = Encoding.Default.GetString(receiveData);
            string fileListen = receiveString;
            client.Close();
            return fileListen;
        }
    }
}
