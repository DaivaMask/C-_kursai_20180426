using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__4_GUIuzduotis_is_FB
{
    public class Miestas
    {
        public string Pavadinimas { get; set; }
        public int GyventojuSkaicius { get; set; }
        public int Plotas { get; set; }

        public Miestas (string pavadinimas, int gyventojuSkaicius, int plotas)
        {
            Pavadinimas = pavadinimas;
            GyventojuSkaicius = gyventojuSkaicius;
            Plotas = plotas;

        }

        public Miestas(string eilute)
        {
            var duomenys = eilute.Split(';');
            Pavadinimas = duomenys[0];
            GyventojuSkaicius = Convert.ToInt32(duomenys[1]);
            Plotas = Convert.ToInt32(duomenys[2]);
        }

        internal static void Add(Miestas miestas)
        {
            throw new NotImplementedException();
        }
    }
}
