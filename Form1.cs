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
using System.Threading;
namespace udpCSharpServer
{
    public partial class Form1 : Form
    {

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
            bool socketFlag=false;
            bool msgFlag=false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text!=null&&tbxServerPort!=null)
            {
                mySocket = new SocketConnect(tbxServerIp.Text,int.Parse(tbxServerPort.Text));
                socketFlag=true;
            }
            if(socketFlag)
            {
                mySocket.initSocketIpConnect();
            }
            /* 
            if (tbxClientSend.Text != null)
            {
                msgFlag=true;
            }
            if(msgFlag)
            {
                mySocket.sentData(tbxClientSend.Text);
            }
            */
            while (true)
            {
                string listenMsg = mySocket.listenStr();
                tbxServerListenMsg.Text += "Client:"+listenMsg+ "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSeverOpenFile_Click(object sender, EventArgs e)
        {
            /*
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择传输文件";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox .Show(this, "文件夹路径不能为空", "提示");
                    return;
                }

            }
            */
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = dialog.FileName;
                tbxFilePath.Text = filePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(serverSendFile);
            t.Start();
            
        }

        void serverSendFile()
        {

            bool socketFlag = false;
            bool fileFlag = false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text != null && tbxServerPort.Text != null && tbxClientIp.Text != null && tbxClientPort != null&&tbxServerMsgPort.Text!=null&&tbxClientMsgPort.Text!=null)
            {
                mySocket = new SocketConnect(tbxServerIp.Text, int.Parse(tbxServerMsgPort.Text), tbxClientIp.Text, int.Parse(tbxClientMsgPort.Text));
                socketFlag = true;
            }
            if (tbxFilePath.Text != null)
            {
                fileFlag = true;
            }
            if (fileFlag)
            {
                try
                {
                    mySocket.sendFile(tbxFilePath.Text);
                    tbxServerListenMsg.Text += "成功发送文件\r\n";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            bool socketFlag = false;
            bool msgFlag = false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text != null && tbxServerPort != null&&tbxClientIp.Text!=null&&tbxClientPort!=null)
            {
                mySocket = new SocketConnect(tbxClientIp.Text, int.Parse(tbxClientPort.Text));
                socketFlag = true;
            }
            if (socketFlag)
            {
                mySocket.initSocketIpConnect();
            }
            if (tbxServerMsg.Text != null)
            {
                msgFlag = true;
            }
            if (msgFlag)
            {
                mySocket.sentData(tbxServerMsg.Text);
                tbxServerListenMsg.Text += "Server:" + tbxServerMsg.Text + "\r\n";
            }
        }
    }
}
