using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Threading;
using Chat = System.Net;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotería_CS
{
    public partial class IP_interconección : Form
    {
        public IP_interconección()
        {
            InitializeComponent();
        }
            SimpleTcpServidor servidor;
              public int Servidor_RecibeInformación { get; private set; }
        public object Encoging { get; private set; }

        private void Conexión_IP_Load(object sender, EventArgs e)
        {
            servidor = new SimpleTcpServidor();
            servidor.Delimiter = 0 * 13;

            servidor.StringEncoder = Encoding.UTF8;
            servidor.DataRecived += Servidor_RecibeInformación;
        }
        private void Servidor_DataRecibeInformación(object sender, SimpleTCP.Message e)
        {
            txtEstatus.Invoke((MethodInvoker)delegate ()
            {
                txtEstatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Usted dijo: {0}", e.MessageString));

            });
        }
        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

