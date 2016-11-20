using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyEvaluation
{
    class Program
    {
        const string url = "http://localhost:8080";
        static void Main(string[] args)
        {
            var hostConfiguration = new HostConfiguration();
            hostConfiguration.UrlReservations.CreateAutomatically = true;

            using (var host = new NancyHost(hostConfiguration, new Uri(url)))
            {
                host.Start();
                Console.WriteLine($"Running on {url}");
                Console.ReadLine();
            }
        }
    }
}
