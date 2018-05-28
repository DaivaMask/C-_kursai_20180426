using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_koldunai
{
    class Dalyviai
    {
        public string Vardas { get; }
        public int KiekSuvalge { get; }
        public int KiekTelpa { get; }

        public Dalyviai(string Vardas, int KiekSuvalge, int KiekTelpa)
        {
            this.Vardas = Vardas;
            this.KiekSuvalge = KiekSuvalge;
            this.KiekTelpa = KiekTelpa;
        }
    }

    class PersivalgeKoldunuException : Exception
    {
        public int KiekSuvalge { get; set; }
        public PersivalgeKoldunuException(int KiekSuvalge)
        {
            this.KiekSuvalge = KiekSuvalge;
        }
    }
}
