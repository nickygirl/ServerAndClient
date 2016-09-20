using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationApplication
{
    public partial class FormServer : Form
    {
        private Label labelIP;
        private Label labelPort;
        private Label labelContents;
        private Label labelInput;
        private Button btnTurnOnServer;
        private Button btnSendMsg;
        private TextBox txbIP;
        private TextBox txbPort;
        private TextBox txbContents;
        private TextBox txbSendMsg;

        public FormServer()
        {
            InitializeComponent();

            labelIP = new Label();
            labelIP.Text = "IP";
            labelIP.Location = new Point(50, 50);

            labelPort = new Label();
            labelPort.Text = "PORT";
            labelPort.Location = new Point(250, 50);

            labelContents = new Label();
            labelContents.Text = "Contents";
            labelContents.Location = new Point(50, 100);

            labelInput = new Label();
            labelInput.Text = "Input Msg";
            labelInput.Location = new Point(50, 500);

            btnTurnOnServer = new Button();
            btnTurnOnServer.Text = "Start Server";
            btnTurnOnServer.Location = new Point(500, 50);

            btnSendMsg = new Button();
            btnSendMsg.Text = "Send";
            btnSendMsg.Location = new Point(500, 500);

            txbIP = new TextBox();
            txbIP.Location = new Point(80, 50);

            txbPort = new TextBox();
            txbPort.Location = new Point(280, 50);

            txbContents = new TextBox();
            txbContents.Location = new Point(50, 150);

            txbSendMsg = new TextBox();
            txbSendMsg.Location = new Point(80, 500);

            this.Controls.Add(labelIP);
            this.Controls.Add(labelInput);
            this.Controls.Add(labelPort);
            this.Controls.Add(labelContents);
            this.Controls.Add(btnTurnOnServer);
            this.Controls.Add(btnSendMsg);
            this.Controls.Add(txbContents);
            this.Controls.Add(txbIP);
            this.Controls.Add(txbPort);
            this.Controls.Add(txbSendMsg);

        }




    }
}
