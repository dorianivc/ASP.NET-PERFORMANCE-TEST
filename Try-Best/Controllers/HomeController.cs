using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;


namespace Try_Best.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()//RAM
        {
            ViewBag.Message = "Your application description page.";
            About();
            return View();
        }

        public ActionResult Contact()//CPU
        {
            while (true)
            {
                Console.WriteLine("Interrumpcion");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Salida()//TCP
        {
            while (true)
            {
                TcpClient tcpClient = new TcpClient();
                IPAddress ipAddress = Dns.GetHostEntry("www.google.com").AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 80);
                tcpClient.Connect(ipEndPoint);
            }
          

            return View();
        }
    }
}
