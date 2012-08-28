using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Urban_Terror_Packet_Repair
{
    public partial class FormMain : Form
    {
        private Thread proxyThread;
        private string ipAddress = "107.6.124.34";
        private string port = "2222";

        public FormMain()
        {
            InitializeComponent();
            textBoxAddress.Text = ipAddress;
            textBoxPort.Text = port;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart.Text = "Proxy is running...";
            if(proxyThread==null)
            {
                proxyThread = new Thread(new ThreadStart(StartProxy));
                proxyThread.Start();
            }
        }

        private void StartProxy()
        {
            UdpProxy udpProxy = new UdpProxy(textBoxAddress.Text, Convert.ToInt32(textBoxPort.Text));
            udpProxy.Start();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(proxyThread!=null)
            {
                //Application.
            }
        }
    }
}
