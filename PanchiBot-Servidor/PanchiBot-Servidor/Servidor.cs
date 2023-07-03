using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanchiBot_Servidor
{
    class Servidor
    {
        IPEndPoint miDireccion;
        Socket serverSocket;
        Socket clientSocket;

        public Servidor()
        {
            miDireccion = new IPEndPoint(IPAddress.Any, 123);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(miDireccion);
            serverSocket.Listen(5);

        }
        public void iniciar()
        {
            Thread h;
            while (true)
            {
                clientSocket = serverSocket.Accept();
                //Console.WriteLine("Esperando Conexiones");
                //Console.WriteLine("Un cliente se ha conectado.");
                h = new Thread(recibir);
                h.Start();

            }

        }
        public void recibir()
        {
            ventanaCliente nuevoCliente = new ventanaCliente();

            Thread ven = new Thread(new System.Threading.ThreadStart(ventana));
            ven.Start();
            void ventana()
            {

                Application.Run(nuevoCliente);
                //nuevoCliente = new ventanaCliente();
                //nuevoCliente.Show();

            }
            int auxPrimeraVez = 0;
            string name;
            while (true)
            {

                byte[] ByRec = new byte[255];
                int enteroRecibido = clientSocket.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, enteroRecibido);
                string textoRecibido = Encoding.Default.GetString(ByRec);
                nuevoCliente.listBox.Items.Add("Client: " + textoRecibido);

                if (textoRecibido != "" && auxPrimeraVez == 0)
                {
                    enviar("Panchi: Hola, soy Panchi, Ingresa tu nombre");

                }
                if (textoRecibido != "" && auxPrimeraVez == 1)
                {
                    name = textoRecibido;
                    enviar("Panchi: Hola " + name + " puedes hablar conmigo sobre: A.Quiero Adoptar B.Requisitos para Adoptar");

                }
                if (textoRecibido.ToUpper().Trim() == "A" && auxPrimeraVez > 1)
                {
                    enviar("Panchi: Estas de suerte! Aqui tenemos muchos amiguitos que quieren conocerte.  Para poder contactarte, y adoptar un perrito, necesito que ingreses los siguientes datos  (Nombre Completo/Telefono/Domicilio/Mail)  y al finalizar digites #");
                }
                if (textoRecibido.Contains("#"))
                    enviar("Panchi: Estas en la lista de espera, estaremos en contacto");
                if (textoRecibido.Trim().ToUpper() == "B" && auxPrimeraVez > 1)
                {
                    enviar("Panchi: Preguntese a usted mismo: La mascota va a vivir en su domicilio?/ En su domicilio, estan todos de acuerdo en adoptar?/ Conoce los gastos y cuidados que implica adoptar y esta dispuesto a asumirlos");
                }
                auxPrimeraVez++;
            }

        }
        public void enviar(string msg)
        {
            byte[] textoEnviar = Encoding.Default.GetBytes(msg);
            clientSocket.Send(textoEnviar, 0, textoEnviar.Length, 0);
        }

    }
}
