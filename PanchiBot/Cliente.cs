using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PanchiBot
{
    class Cliente
    {
        IPEndPoint miDireccion;
        public Socket clientSocket;
        public Cliente()
        {
            miDireccion = new IPEndPoint(IPAddress.Parse("192.168.0.113"), 123);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        public void iniciar()
        {
            clientSocket.Connect(miDireccion);
            //Console.WriteLine("Conectado con exito ");
        }
        public void enviarMsg(string msg)
        {
            byte[] textoEnviar = Encoding.Default.GetBytes(msg);
            clientSocket.Send(textoEnviar, 0, textoEnviar.Length, 0);
            //Console.WriteLine("Mensaje enviado.");
        }
    }
}
