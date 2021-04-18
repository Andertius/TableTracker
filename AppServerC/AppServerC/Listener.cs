using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppServerC
{
    class Listener
    {
        public HttpListener listener;
        static public StringBuilder response_string;
        //static public PageHandler router;
        //public static WebAppContext db = new WebAppContext();
        public Listener()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8888/User/Login/");
            listener.Prefixes.Add("http://localhost:8888/User/Registr/");
            listener.Prefixes.Add("http://localhost:8888/History/");
            listener.Prefixes.Add("http://localhost:8888/OCR/");
            listener.Prefixes.Add("http://localhost:8888/DoOCR/");
            listener.Start();
            //router = new PageHandler();
            Console.WriteLine("HTTP server is running!\nAwaiting for connection:");
        }
        public void Listen()
        {
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                new Thread(() => DoListen(context)).Start();

            }
        }
        static public void DoListen(HttpListenerContext context)
        {
            Console.WriteLine("Get connection");
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            Console.WriteLine(request.Url);
            var content = "";
            using (var reader = new StreamReader(request.InputStream))
                content = reader.ReadToEnd();
            //router.URI = request.Url;
            //byte[] page = router.Respond(content);
            //response.ContentLength64 = page.Length;
            response.ContentType = "Json";
            Stream output = response.OutputStream;
            //output.Write(page, 0, page.Length);
            output.Close();
        }
       
    }
}

