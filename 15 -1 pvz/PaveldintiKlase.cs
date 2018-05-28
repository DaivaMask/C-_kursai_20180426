using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15__1_pvz
{
    class PaveldintiKlase : Alkoholis
    {
        public string Rusis { get; }
        public string KilmesSalis { get; }

        public PaveldintiKlase()
        {
                
        }

        public PaveldintiKlase(double Laipsniai, int Turis, string Spalva, string Rusis)
            : base(Laipsniai, Turis, Spalva)         //base - kokie parametrai bus siunciami i bazine klase
        {
            this.Rusis = Rusis;
        }

    }
}
