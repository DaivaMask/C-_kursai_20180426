using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2
{
    class Client
    {
        public int ID { get; }
        public string Vardas { get; set; }
        public double MoketinaSuma { get; set;  }


        public Client(int ID, string Vardas)
        {
            this.ID = ID;
            this.Vardas = Vardas;
           
            
        }
        public virtual void SkaiciuotiMoketinaSuma()
        {
            MoketinaSuma = 10 * 1;
        }





    }
}
