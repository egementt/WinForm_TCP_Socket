
namespace SocketEx
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConn = new System.Windows.Forms.Label();
            this.receivedTxt = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBroadcast = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(99, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(164, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(59, 20);
            this.txtPort.TabIndex = 1;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(21, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.Location = new System.Drawing.Point(12, 183);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(78, 13);
            this.lblConn.TabIndex = 4;
            this.lblConn.Text = "No Connection";
            // 
            // receivedTxt
            // 
            this.receivedTxt.Location = new System.Drawing.Point(24, 48);
            this.receivedTxt.Name = "receivedTxt";
            this.receivedTxt.Size = new System.Drawing.Size(306, 71);
            this.receivedTxt.TabIndex = 5;
            this.receivedTxt.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(255, 137);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBroadcast
            // 
            this.txtBroadcast.Location = new System.Drawing.Point(24, 137);
            this.txtBroadcast.Name = "txtBroadcast";
            this.txtBroadcast.Size = new System.Drawing.Size(225, 23);
            this.txtBroadcast.TabIndex = 7;
            this.txtBroadcast.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 205);
            this.Controls.Add(this.txtBroadcast);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.receivedTxt);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.RichTextBox receivedTxt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtBroadcast;
    }
}

