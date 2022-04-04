using Online_Bus_Ticket_Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Bus_host
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Service1);
            Uri http = new Uri("http://localhost:8001/Bus_Management");
            ServiceHost host = new ServiceHost(t, http);
            host.Open();
            Console.WriteLine("host running");
            Console.ReadLine();
            host.Close();
        }
    }
}
