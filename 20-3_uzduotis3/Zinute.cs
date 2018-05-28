using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_uzduotis3
{
    class Zinute
    {
        public delegate void PranesimasEventHandler(object sender, EventArgs eventArgs);

        public event PranesimasEventHandler PranesimasSend;

        protected virtual void OnPranesimasSend()  
        {
            if (PranesimasSend != null)    
            {
                PranesimasSend(this, EventArgs.Empty); 
            }
        }


        public void VeikiamDabar()
        {
            Console.WriteLine("Siunciam zinute");

            OnPranesimasSend ();
        }



    }
}
