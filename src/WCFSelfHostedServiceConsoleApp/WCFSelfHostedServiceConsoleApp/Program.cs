using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFSelfHostedServiceConsoleApp.Services;

namespace WCFSelfHostedServiceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(ComisionCalculator)))
            {
                serviceHost.Open();
                
                Console.Write("Service is running... ");
                Console.Read();
            }
        }
    }
}
