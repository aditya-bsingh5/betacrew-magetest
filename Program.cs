using System;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace BetaCrewClient
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                var endPoint = new IPEndPoint(IPAddress.Parse("172.16.5.4"), 3000);
                using var client = new TcpClient(endPoint);

                if(client.Connected) Console.WriteLine("good");
                else Console.WriteLine("no connection");
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }        
        }
    }
}
