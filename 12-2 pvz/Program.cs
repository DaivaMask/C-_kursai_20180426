using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var prieglauda = new prieglauda("penkta koja", "kaunas kaunas",
                new List<suo> {
                    new suo ("zakas", "vokietis", 12),
                    new suo ("pifas", "kiemsargis", 5),
                    new suo ("betovenas", "sembernaras", 8)
                });

            prieglauda.Isvedimas();
            prieglauda.Checkin();
            prieglauda.Isvedimas();
        }
    }
}
