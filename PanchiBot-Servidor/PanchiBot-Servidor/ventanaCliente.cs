using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanchiBot_Servidor
{
    public partial class ventanaCliente : Form
    {
        public ventanaCliente()
        {
            InitializeComponent();
        }

        private void ventanaCliente_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
