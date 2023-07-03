using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PanchiBot_Servidor
{
    public partial class Server : Form
    {
        Servidor server = new Servidor();
        public Server()
        {
            InitializeComponent();
        }

        private void btnPermitirConexiones_Click(object sender, EventArgs e)
        {
            server.iniciar();
            //server.abrirConexiones();
            //server.recibir();
            
        }
    }
}
