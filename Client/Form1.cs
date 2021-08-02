using System;
using SimpleTCP;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        SimpleTcpClient client;
        const string address = "127.0.0.1";
        const string port = "7777";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAddress.Text = address;
            txtPort.Text = port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new SimpleTcpClient().Connect(address, Convert.ToInt32(port));

            client.DataReceived += (senderS, msg) =>
            {


                if (msgTextBox.InvokeRequired)
                {
                    msgTextBox.Invoke(new Action(() => msgTextBox.AppendText("\nSERVER: " + msg.MessageString.Trim())));
                }

            };
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var replyMsg = client.WriteLineAndGetReply(msgTextBox.Text, TimeSpan.FromSeconds(3));
        }
    }
}
