using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_uzduotis3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zinute zinute = new Zinute();
            RasomIConsole rasomIConsole = new RasomIConsole();
            RasomIFaila sendSms = new RasomIFaila();
            zinute.PranesimasSend += rasomIConsole.Rasom;
            zinute.PranesimasSend += sendSms.Rasom;
            zinute.VeikiamDabar();
        }
    }

    class RasomIFaila
    {
        public void Rasom(object sender, EventArgs e)
        {
            //irasytu i txt
            System.IO.StreamWriter irasyti = new System.IO.StreamWriter("Zinute.txt");
            irasyti.WriteLine("Atsiunteme sita zinute  i *.txt faila, va :)");
            irasyti.Flush(); //jeigu irasinejama daug eiluciu, jeigu dar irasinesim info
            irasyti.Close(); //jeigu visai uzdaryti faila
        }

    }

    class RasomIConsole
    {
        public void Rasom(object sender, EventArgs e)
        {
            Console.WriteLine("parasiau");
        }
    }
}
