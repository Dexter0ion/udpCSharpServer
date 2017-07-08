namespace udpCSharpServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnServerListen = new System.Windows.Forms.Button();
            this.tbxServerIp = new System.Windows.Forms.TextBox();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.tbxServerPort = new System.Windows.Forms.TextBox();
            this.tbxClientPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.tbxClientIp = new System.Windows.Forms.TextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tbxServerListenMsg = new System.Windows.Forms.TextBox();
            this.btnSeverOpenFile = new System.Windows.Forms.Button();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnServerSendFile = new System.Windows.Forms.Button();
            this.tbxServerMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerMsgPort = new System.Windows.Forms.TextBox();
            this.tbxClientMsgPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServerListen
            // 
            this.btnServerListen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnServerListen.Location = new System.Drawing.Point(9, 341);
            this.btnServerListen.Name = "btnServerListen";
            this.btnServerListen.Size = new System.Drawing.Size(243, 39);
            this.btnServerListen.TabIndex = 0;
            this.btnServerListen.Text = "Server开始监听";
            this.btnServerListen.UseVisualStyleBackColor = false;
            this.btnServerListen.Click += new System.EventHandler(this.btnConnecTest_Click);
            // 
            // tbxServerIp
            // 
            this.tbxServerIp.BackColor = System.Drawing.Color.White;
            this.tbxServerIp.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerIp.Location = new System.Drawing.Point(25, 39);
            this.tbxServerIp.Name = "tbxServerIp";
            this.tbxServerIp.Size = new System.Drawing.Size(232, 38);
            this.tbxServerIp.TabIndex = 1;
            this.tbxServerIp.Text = "127.0.0.1";
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServerIp.Location = new System.Drawing.Point(25, 5);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(133, 31);
            this.lblServerIp.TabIndex = 2;
            this.lblServerIp.Text = "Server端IP";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServerPort.Location = new System.Drawing.Point(25, 80);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(207, 31);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Server端消息Port";
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.BackColor = System.Drawing.Color.White;
            this.tbxServerPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerPort.Location = new System.Drawing.Point(25, 114);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(232, 38);
            this.tbxServerPort.TabIndex = 4;
            this.tbxServerPort.Text = "11000";
            // 
            // tbxClientPort
            // 
            this.tbxClientPort.BackColor = System.Drawing.Color.White;
            this.tbxClientPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientPort.Location = new System.Drawing.Point(304, 114);
            this.tbxClientPort.Name = "tbxClientPort";
            this.tbxClientPort.Size = new System.Drawing.Size(229, 38);
            this.tbxClientPort.TabIndex = 8;
            this.tbxClientPort.Text = "11001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(304, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client端Port";
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClientPort.Location = new System.Drawing.Point(304, 5);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(126, 31);
            this.lblClientPort.TabIndex = 6;
            this.lblClientPort.Text = "Client端IP";
            // 
            // tbxClientIp
            // 
            this.tbxClientIp.BackColor = System.Drawing.Color.White;
            this.tbxClientIp.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientIp.Location = new System.Drawing.Point(304, 39);
            this.tbxClientIp.Name = "tbxClientIp";
            this.tbxClientIp.Size = new System.Drawing.Size(232, 38);
            this.tbxClientIp.TabIndex = 5;
            this.tbxClientIp.Text = "127.0.0.1";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.Moccasin;
            this.btnSaveInfo.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveInfo.Location = new System.Drawing.Point(25, 246);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(232, 39);
            this.btnSaveInfo.TabIndex = 9;
            this.btnSaveInfo.Text = "保存连接信息";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tbxServerListenMsg
            // 
            this.tbxServerListenMsg.BackColor = System.Drawing.Color.Black;
            this.tbxServerListenMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxServerListenMsg.ForeColor = System.Drawing.Color.White;
            this.tbxServerListenMsg.Location = new System.Drawing.Point(3, 6);
            this.tbxServerListenMsg.Multiline = true;
            this.tbxServerListenMsg.Name = "tbxServerListenMsg";
            this.tbxServerListenMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxServerListenMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxServerListenMsg.Size = new System.Drawing.Size(613, 252);
            this.tbxServerListenMsg.TabIndex = 10;
            // 
            // btnSeverOpenFile
            // 
            this.btnSeverOpenFile.BackColor = System.Drawing.Color.Bisque;
            this.btnSeverOpenFile.Location = new System.Drawing.Point(3, 72);
            this.btnSeverOpenFile.Name = "btnSeverOpenFile";
            this.btnSeverOpenFile.Size = new System.Drawing.Size(136, 34);
            this.btnSeverOpenFile.TabIndex = 11;
            this.btnSeverOpenFile.Text = "选择文件";
            this.btnSeverOpenFile.UseVisualStyleBackColor = false;
            this.btnSeverOpenFile.Click += new System.EventHandler(this.btnSeverOpenFile_Click);
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(145, 72);
            this.tbxFilePath.Multiline = true;
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(474, 34);
            this.tbxFilePath.TabIndex = 12;
            // 
            // btnServerSendFile
            // 
            this.btnServerSendFile.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnServerSendFile.Location = new System.Drawing.Point(354, 112);
            this.btnServerSendFile.Name = "btnServerSendFile";
            this.btnServerSendFile.Size = new System.Drawing.Size(265, 39);
            this.btnServerSendFile.TabIndex = 13;
            this.btnServerSendFile.Text = "Server发送文件";
            this.btnServerSendFile.UseVisualStyleBackColor = false;
            this.btnServerSendFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxServerMsg
            // 
            this.tbxServerMsg.BackColor = System.Drawing.Color.White;
            this.tbxServerMsg.Location = new System.Drawing.Point(9, 287);
            this.tbxServerMsg.Name = "tbxServerMsg";
            this.tbxServerMsg.Size = new System.Drawing.Size(428, 34);
            this.tbxServerMsg.TabIndex = 14;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSendMsg.Location = new System.Drawing.Point(443, 286);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(176, 34);
            this.btnSendMsg.TabIndex = 15;
            this.btnSendMsg.Text = "发送";
            this.btnSendMsg.UseVisualStyleBackColor = false;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileName.Location = new System.Drawing.Point(140, 30);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(335, 31);
            this.lblFileName.TabIndex = 17;
            this.lblFileName.Text = "文件路径(UDP,50kb以内文件)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Server端文件Port";
            // 
            // tbxServerMsgPort
            // 
            this.tbxServerMsgPort.BackColor = System.Drawing.Color.White;
            this.tbxServerMsgPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerMsgPort.Location = new System.Drawing.Point(25, 189);
            this.tbxServerMsgPort.Name = "tbxServerMsgPort";
            this.tbxServerMsgPort.Size = new System.Drawing.Size(232, 38);
            this.tbxServerMsgPort.TabIndex = 19;
            this.tbxServerMsgPort.Text = "11002";
            // 
            // tbxClientMsgPort
            // 
            this.tbxClientMsgPort.BackColor = System.Drawing.Color.White;
            this.tbxClientMsgPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientMsgPort.Location = new System.Drawing.Point(304, 189);
            this.tbxClientMsgPort.Name = "tbxClientMsgPort";
            this.tbxClientMsgPort.Size = new System.Drawing.Size(229, 38);
            this.tbxClientMsgPort.TabIndex = 20;
            this.tbxClientMsgPort.Text = "11003";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(304, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Client端文件Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 445);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnSaveInfo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbxServerIp);
            this.tabPage1.Controls.Add(this.tbxClientMsgPort);
            this.tabPage1.Controls.Add(this.lblServerIp);
            this.tabPage1.Controls.Add(this.tbxServerMsgPort);
            this.tabPage1.Controls.Add(this.lblServerPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbxServerPort);
            this.tabPage1.Controls.Add(this.tbxClientIp);
            this.tabPage1.Controls.Add(this.lblClientPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxClientPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置连接信息";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tbxServerListenMsg);
            this.tabPage2.Controls.Add(this.tbxServerMsg);
            this.tabPage2.Controls.Add(this.btnSendMsg);
            this.tabPage2.Controls.Add(this.btnServerListen);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通信";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnSeverOpenFile);
            this.tabPage3.Controls.Add(this.btnServerSendFile);
            this.tabPage3.Controls.Add(this.lblFileName);
            this.tabPage3.Controls.Add(this.tbxFilePath);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(622, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "传输文件";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(622, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "制作小组信息";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(26, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 355);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "UDP 一班二组 计算机科学与技术1班\r\n\r\n负责人：\r\n邵博超 2016110131 \r\n\r\n组员：\r\n\r\n朱利佳 2016110163\r\n王艳琴 201611" +
    "0138\r\n邓偲易 2016110106\r\n\r\n";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(622, 405);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "开始";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 456);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "UDP-Server端-邵博超";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServerListen;
        private System.Windows.Forms.TextBox tbxServerIp;
        private System.Windows.Forms.Label lblServerIp;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tbxServerPort;
        private System.Windows.Forms.TextBox tbxClientPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.TextBox tbxClientIp;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox tbxServerListenMsg;
        private System.Windows.Forms.Button btnSeverOpenFile;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnServerSendFile;
        private System.Windows.Forms.TextBox tbxServerMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerMsgPort;
        private System.Windows.Forms.TextBox tbxClientMsgPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
    }
}

