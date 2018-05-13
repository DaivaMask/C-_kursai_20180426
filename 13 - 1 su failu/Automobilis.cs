using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___1_su_failu
{
    public class Automobilis
    {
        public string Marke { get; private  set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }

        public Automobilis(string marke, string modelis, int metai)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
        }

        public Automobilis(string eilute) //bus automobilio duomenys atskirti kabliataskiu  (pvz: audi;a4;2004)
        {
            var duomenys = eilute.Split(';');
            Marke = duomenys[0];
            Modelis = duomenys[1];
            Metai = Convert.ToInt32(duomenys[2]);
        }

        //prop
        //ctorp - tik su resharper pluginu

    }
}
