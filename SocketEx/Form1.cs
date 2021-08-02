using System;
using System.Collections.Generic;
using System.ComponentModel;
using SimpleTCP;
using System.Windows.Forms;

namespace SocketEx
{
    public partial class Server : Form
    {
        SimpleTcpServer server;
        const string address = "127.0.0.1";
        const string port = "7777";

        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = new SimpleTcpServer().Start(Convert.ToInt32(port));

            if(server.IsStarted)
            {
                lblConn.Text = "Connected";
            }
            server.Delimiter = 0x13;

            server.DataReceived += (senderS, msg) =>
            {


                if(receivedTxt.InvokeRequired)
                {
                    receivedTxt.Invoke(new Action(() => receivedTxt.AppendText("\n-> " + msg.MessageString.Trim())));
                }

            };
        }

        private void Server_Load(object sender, EventArgs e)
        {
            txtAddress.Text = address;
            txtPort.Text = port;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            server.BroadcastLine(txtBroadcast.Text.Trim());
        }
    }
}
