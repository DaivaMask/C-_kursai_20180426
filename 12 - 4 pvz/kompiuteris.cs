using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___4_pvz
{
    class kompiuteris
    {
        //prop + tab tab
        //propg
        public string Vaizduske { get; private set; }
        public string Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }



        public kompiuteris(string vaizduske, string motinine, int diskoTalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskoTalpa;
        }

        public kompiuteris()
        {

        }

        //ivedimo ir isvedimo metodai

        public void Isvedimas()
        {
            Console.WriteLine("kompiuterio vaizdas {0}, motinine {1}, o disko talpa {2}", Vaizduske, Motinine, DiskoTalpa);
        }


        public void Ivedimas()
        {
            Console.WriteLine("kokia vaizdo plokste?: ");
            Vaizduske = Console.ReadLine();
            Console.WriteLine("kokia motinine plokste?: ");
            Motinine = Console.ReadLine();
            Console.WriteLine("Kokia disko talpa?: ");
            DiskoTalpa = Convert.ToInt32(Console.ReadLine());

        }


    }
}
