using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanchiBot
{
    public partial class Form1 : Form
    {
        Cliente client = new Cliente();
        internal static string textoRec;
        //Socket clientSocket;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Down_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnEnviar
            client.enviarMsg(tbMensaje.Text);
            string auxLargo = tbMensaje.Text;
            while (auxLargo.Length> 42)
            {
                string aux = auxLargo.Substring(0, 42);
                string aux2 = auxLargo.Substring(42);
                auxLargo = aux2;
                listBox.Items.Add("Yo: "+aux);

            }
            listBox.Items.Add("Yo: " + auxLargo);
            tbMensaje.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.iniciar();
            btnConnect.BackColor = Color.LightGreen;
            Thread h = new Thread(recibir);
            h.Start();
        }
        public void recibir()
        {
            while (true)
            {
                byte[] ByRec = new byte[255];
                int enteroRecibido = client.clientSocket.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, enteroRecibido);
                string textoRecibido = Encoding.Default.GetString(ByRec);
                while (textoRecibido.Length > 45)
                {
                    string aux = textoRecibido.Substring(0, 45);
                    string aux2 = textoRecibido.Substring(45);
                    textoRecibido = aux2;
                    listBox.Items.Add(aux);
                }
                listBox.Items.Add(textoRecibido);
            }
        }

    }
}
