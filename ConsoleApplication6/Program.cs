using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace ConsoleApplication6
{
    internal class Program
    {
        public  static void Main()
        {
            using (WebApp.Start<Startup>("http://localhost:5000/"))
            {
                Console.WriteLine("Press [enter] to quit");
                Console.ReadLine();
            }
        }

       
    }
}