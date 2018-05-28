using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
            {
                new VIP(1, "Jurgis Jurgaitis"),
                new Silver (2, "Petras Petraitis"),
                new Basic (3, "Jonas Jonaitis")
            };

            foreach (var item in clients)
            {
                item.SkaiciuotiMoketinaSuma();
                Console.WriteLine(item.Vardas + " moketi reikia " + item.MoketinaSuma);
            }
        }
    }
}
