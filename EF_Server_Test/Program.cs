using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EF_Server_Test.Service;
using EF_Server_Test.Infrastructure;
using System.ServiceModel.Security;

namespace SvcHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bootstrapper.Initialize();

                ServiceHost host = new ServiceHost(typeof(TestService));
                host.Open();

                Console.WriteLine("Service started!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal error. " + ex);
            }
            
            
            Console.ReadKey(true);
        }
    }
}
