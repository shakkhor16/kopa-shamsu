using System;
using System.Windows.Forms;

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
            var connectionManager = new ConnectionManager(textBoxAddress.Text, portAsInteger);
            string response = connectionManager.GetServerStatus();
            var statusStringProcessor = new StatusStringProcessor(response);

            dataGridViewServerarameters.DataSource = statusStringProcessor.GetServerParameters();
            dataGridViewPlayers.DataSource = statusStringProcessor.GetPlayers();
        }
    }
}