using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace TcpIpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Waiting for connection....");

                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener server = new TcpListener(address, 9000);
                server.Start();

                while (true)
                {
                    using (Socket socket = server.AcceptSocket())
                    {
                        Console.WriteLine("Connection made!");

                        byte[] b = new byte[500];
                        socket.Receive(b);

                        string r = System.Text.Encoding.Default.GetString(b);
                        
                        Random random = new Random();
                        int randomNum = random.Next(1,30000);

                        byte[] sendBuffer = System.Text.Encoding.Default.GetBytes(randomNum.ToString() + ".90");
                        socket.Send(sendBuffer);
                    }
                }
            }
            catch (SocketException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
