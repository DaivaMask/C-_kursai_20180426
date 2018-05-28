using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> datos = new List<DateTime>()
            {
                new DateTime(year: 1995, month: 12, day: 02 ),
                new DateTime(year: 2001, month: 05, day: 14 ),
                new DateTime(year: 2017, month: 12, day: 21 ),
                new DateTime(year: 2010, month: 10, day: 30 ),
                new DateTime(year: 2002, month: 02, day: 02 ),

            };

            IEnumerable<DateTime> siandien = datos.Where(x => x == DateTime.Today);  //ieskos datu, kurios yra siandien
            IEnumerable<DateTime> antraDiena = datos.Where(x => x.Day == 2);
            IEnumerable<DateTime> tarpas = datos.Where(x => (x.Year > 1999 && x.Year < 2015)).OrderBy(x=> x.Year) ;

            var data = tarpas.All (x =>
            {
                Console.WriteLine(x);
                return true;
            });

        }
    }
}
