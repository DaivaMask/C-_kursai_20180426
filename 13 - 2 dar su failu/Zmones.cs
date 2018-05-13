using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___2_dar_su_failu
{
    public class Zmones
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }

        public Zmones(string vardas, int amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public Zmones(string eilute)
        {
            var duomenys = eilute.Split(';');
            Vardas = duomenys[0];
            Amzius = Convert.ToInt32(duomenys[1]);
        }
    }
}
