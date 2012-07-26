using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kopa_Shamsu.Entities;

namespace Kopa_Shamsu
{
    public partial class FormMain : Form
    {
        private string ipAddress = "107.6.124.34";
        private string port = "2222";

        public FormMain()
        {
            InitializeComponent();
            textBoxAddress.Text = ipAddress;
            textBoxPort.Text = port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int portAsInteger = Convert.ToInt32(textBoxPort.Text);
            ConnectionManager connectionManager = new ConnectionManager(textBoxAddress.Text, portAsInteger);
            string response = connectionManager.GetServerStatus();
            StatusStringProcessor statusStringProcessor = new StatusStringProcessor(response);

            dataGridViewServerarameters.DataSource = statusStringProcessor.GetServerParameters();
            dataGridViewPlayers.DataSource = statusStringProcessor.GetPlayers();
        }

    }
}
