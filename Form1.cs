using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace udpCSharpServer
{
    public partial class Form1 : Form
    {
        string serverIp = null;
        int serverPort = 0;
        string clientIp = null;
        int clientPort = 0;
        UdpClient client = null;
        string receiveString = null;
        byte[] receiveData = null;
        //实例化一个远程端点，IP和端口可以随意指定，等调用client.Receive(ref remotePoint)时会将该端点改成真正发送端端点 
        IPEndPoint remotePoint = new IPEndPoint(IPAddress.Any, 0);
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnecTest_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(listenClientMsg);
            t.Start();

        }

        private void tbxServerInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {

        }

        void listenClientMsg()
        {
            string serverIp = tbxServerIp.Text;
            int serverPort = int.Parse(tbxServerPort.Text);
            string clientIp = tbxClientIp.Text;
            int clientPort = int.Parse(tbxClientPort.Text);
            while (true)
            {
                client = new UdpClient(serverPort);
                receiveData = client.Receive(ref remotePoint);//接收数据 
                receiveString = Encoding.Default.GetString(receiveData);
                string msgListen = receiveString;
                tbxServerListenMsg.Text += msgListen+ "\r\n";
                Console.Write(receiveString);
                client.Close();//关闭连接 
            }
        }
    }
}
