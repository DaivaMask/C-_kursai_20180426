using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2
{
    class VIP : Client
    {


        public VIP(int ID, string Vardas) : base(ID, Vardas)
        {

        }

        public override void SkaiciuotiMoketinaSuma()
        {
            base.SkaiciuotiMoketinaSuma();
            MoketinaSuma *= 0.7; //30% nuolaida
        }



    }
}
