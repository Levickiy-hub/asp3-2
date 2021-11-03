using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCF.MyService));
            host.Open();
            System.Console.WriteLine("WCF console started");
            System.Console.ReadKey();
        }
    }
}
