using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_Darbuotojai
{
    class Darbuotojai
    {
        public string ID { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime DOB { get; set; }   //DateOfBirth
        public int Alga { get; set; }
        public int KiekLaikoDirba { get; set; }

        public Darbuotojai(string ID, string Vardas, string Pavarde, DateTime DOB, int Alga, int KiekLaikoDirba)
        {
            this.ID = ID;
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.DOB = DOB;
            this.Alga = Alga;
            this.KiekLaikoDirba = KiekLaikoDirba;
        }
    }

    class KlaidosDarbuotojaiExeption : Exception
    {
        public DateTime DOB { get; set; }
        public KlaidosDarbuotojaiExeption(DateTime DOB)
        {
            this.DOB = DOB;
        }
    }
}
