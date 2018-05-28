using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___2_testavimas
{
    public class Siuntimas :ISiuntimas
    {
        public bool IsShipped { get; set; } //ar yra issiusta siunta
        public int SiuntosSkaiciuotuvas() //suskaiciuos, kiek kainuos siunta
        {
            if (IsShipped == false )
            
                throw new Exception(message: "Siunta jau issiusta");
                //do something
                return 20;

            
        }
        public Siuntimas (bool IsShiped)
        {
            this.IsShipped = IsShipped; 

        }
    }

    public interface ISiuntimas
    {
        bool IsShipped { get; }
        int SiuntosSkaiciuotuvas();
    }

   public class Uzsakymas
    {
        public int Kaina { get; set; }
        public ISiuntimas Siunta { get; set; }
        public string Client { get; set; }

        public void ProceddOrder()
        {
            Kaina = Siunta.SiuntosSkaiciuotuvas() + 20;
        }

        public Uzsakymas(ISiuntimas Siunta)
        {
            this.Siunta = Siunta;
        }
    }
}
