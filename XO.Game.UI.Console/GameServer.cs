using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace XO.Game.UI.Server
{
    public static class ServerMultiplayer
    {
        ServerMultiplayer{};
        public enum Message
        {
            FAILURE,
            CLIENT_CONNECT,
            SERVER_CONNECT
        }
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
        public static string GetInput(string prompt = null,
            bool singleKey = false,
            bool intercept = false)
        {
            if (!string.IsNullOrEmpty(prompt))
                Console.WriteLine(prompt);

            if (singleKey)
                return Console.ReadKey(intercept).KeyChar.ToString();
            else
                return Console.ReadLine();
        }
        public static void SendMessage(string IP, int port, Message message)
        {
            using (TcpClient client = new TcpClient(IP, port))
            using (NetworkStream ns = client.GetStream())
            {
                byte[] byteMessage = Encoding.ASCII.GetBytes(message.ToString());
                ns.Write(byteMessage, 0, byteMessage.Length);
            }
        }
        public static void SendLocation(string IP, int port, string location)
        {
            using (TcpClient client = new TcpClient(IP, port))
            using (NetworkStream ns = client.GetStream())
            {
                byte[] byteMessage = Encoding.ASCII.GetBytes(location);
                ns.Write(byteMessage, 0, byteMessage.Length);
            }
        }

        public static void SendSize(string IP, int port, int size)
        {
            using (TcpClient client = new TcpClient(IP, port))
            using (NetworkStream ns = client.GetStream())
            {
                byte[] byteMessage = BitConverter.GetBytes(size);
                ns.Write(byteMessage, 0, byteMessage.Length);
            }
        }

        public static string ListenForLocation(this TcpListener _)
        {
            string retVal;

            // Accept a new TCP request and
            // reference it's network stream
            using (TcpClient client = _.AcceptTcpClient())
            using (NetworkStream ns = client.GetStream())
            {
                // Read bytes from the network stream
                byte[] receive = new byte[1024];
                int bytesRead = ns.Read(receive, 0, receive.Length);

                // Return the value from the network stream
                retVal = Encoding.ASCII.GetString(receive, 0, bytesRead).ToString();
            }

            return retVal;
        }

        public static Message ListenForMessage(this TcpListener _)
        {
            Message retVal;
            bool success = false;

            // Accept a new TCP request and
            // reference it's network stream
            using (TcpClient client = _.AcceptTcpClient())
            using (NetworkStream ns = client.GetStream())
            {
                // Read bytes from the network stream
                byte[] receive = new byte[1024];
                int bytesRead = ns.Read(receive, 0, receive.Length);

                // The use of the "out" keyword passes retVal by reference
                // which assigns it to the Message type the response parses out to
                // if the parse is successful
                success = Enum.TryParse<Message>(Encoding.ASCII.GetString(receive, 0, bytesRead), out retVal);
            }

            if (success)
                return retVal;
            else
                return Message.FAILURE;
        }
    }
}
