using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Drawing;

namespace Web_ptoj
{
   public class PageHandler
    {
        //private WebAppContext db = new WebAppContext();
        //private Balancer balancer;
        //public Uri URI { get; set; }
        //public PageHandler() 
        //{
        //    balancer = new Balancer();
        //}
        //public PageHandler(Uri uri)
        //{
        //    URI = uri;
        //    balancer = new Balancer();
        //}
        //public byte[] Respond(string information)
        //{
        //    switch (URI.ToString())
        //    {
        //        case "http://localhost:8888/Main/":
        //            {
        //                return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\Main.html");
        //            }
        //        case "http://localhost:8888/Reg/":
        //            {
        //                return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\Reg.html");
        //            }
        //        case "http://localhost:8888/Login/":
        //            {
        //                return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\Login.html");
        //            }
        //        case "http://localhost:8888/History/":
        //            {
        //                return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\History.html");
        //            }
        //        case "http://localhost:8888/OCR/":
        //            {
        //                return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\OCR.html");
        //            }
        //        case "http://localhost:8888/LoginAction/":
        //            {
        //                return LogIn(information); 
        //            }
        //        case "http://localhost:8888/DoOCR/":
        //            {
        //                return ConnectToServer(information, balancer.ChoosePort());
        //            }
        //        default: break;
        //    }
        //    return GetFile(@"B:\Prog\C#\Web_ptoj\Web_ptoj\Pages\Error.html");
        //}
        //private byte[] LogIn(string information)
        //{
        //    byte[] buffer = new byte[256];
        //    var inf = information.Split('&');
        //    var usern = inf[0].Split('=');
        //    var pass = inf[1].Split('=');
        //    User user = (from User searchingUser in db.User
        //                 where searchingUser.Username == usern[1] &
        //                 searchingUser.Password == pass[1]
        //                 select searchingUser).FirstOrDefault();
        //    if (user != null)
        //    {

        //        return buffer = Encoding.UTF8.GetBytes("Logged successfully");
        //    }
        //    else
        //    {
        //        return buffer = Encoding.UTF8.GetBytes("Error: User not found in base");
        //    }
        //}
        //private byte[] GetFile(string file)
        //{
        //    if (!File.Exists(file)) return null;
        //    FileStream readIn = new FileStream(file, FileMode.Open, FileAccess.Read);
        //    byte[] buffer = new byte[1024 * 1000];
        //    int nRead = readIn.Read(buffer, 0, 10240);
        //    int total = 0;
        //    while (nRead > 0)
        //    {
        //        total += nRead;
        //        nRead = readIn.Read(buffer, total, 10240);
        //    }
        //    readIn.Close();
        //    byte[] maxresponse_complete = new byte[total];
        //    System.Buffer.BlockCopy(buffer, 0, maxresponse_complete, 0, total);
        //    return maxresponse_complete;
        //}
        //static public byte[] ConnectToServer(string request, int port)
        //{
        //    TcpClient tcpClient = new TcpClient();
        //    tcpClient.Connect(IPAddress.Loopback, port);
        //    byte[] data = new byte[256];
        //    StringBuilder connectionCheckString = new StringBuilder();
        //    NetworkStream stream = tcpClient.GetStream();

        //    do
        //    {
        //        int bytes = stream.Read(data, 0, data.Length);
        //        connectionCheckString.Append(Encoding.UTF8.GetString(data, 0, bytes));
        //    }
        //    while (stream.DataAvailable);
        //    string connection = connectionCheckString.ToString();
        //    if (connection == "ok")
        //    {
        //        var split = request.Split(',');
        //        byte[] request_data = Convert.FromBase64String(split[1]);
        //        stream.Write(request_data, 0, request_data.Length);
        //    }
        //    connectionCheckString.Clear();
        //    do
        //    {
        //        int bytes = stream.Read(data, 0, data.Length);
        //        connectionCheckString.Append(Encoding.UTF8.GetString(data, 0, bytes));
        //    }
        //    while (stream.DataAvailable);

        //    tcpClient.Close();
        //    byte[] respond = Encoding.UTF8.GetBytes(connectionCheckString.ToString());
        //    return respond;
        //}
    }
}
