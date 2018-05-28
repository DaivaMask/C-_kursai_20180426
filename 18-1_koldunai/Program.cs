using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_koldunai
{

    class Program
    {
        static void Main(string[] args)
        {
            //txt faile: dalyvio vardas / kiek suvalge koldunu / kiek yra max iki apsivemimo
            System.IO.StreamReader reader = new System.IO.StreamReader("koldunai.txt"); //failo nuskaitymas
            List<Dalyviai> dalyviuSarasas = new List<Dalyviai>();  //sarasas sarase; kaip gridas

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] data = line.Split(' ');
                    Dalyviai dalyvis = new Dalyviai(data[0], int.Parse(data[1]), int.Parse(data[2]));
                    if (dalyvis.KiekSuvalge > dalyvis.KiekTelpa)    //surinks tik kurie nepersivalge
                        throw new PersivalgeKoldunuException(dalyvis.KiekSuvalge);
                    dalyviuSarasas.Add(dalyvis);
                }
                catch (PersivalgeKoldunuException ex)
                {

                    Console.WriteLine("PERSIVALGE");
                }
                catch (Exception ex)

                {
                    Console.WriteLine("Nezinoma klaida");
                }
            }
                //valgymo greitis
                int max = int.MinValue;
                Dalyviai maxDalyvis = new Dalyviai(null, 0, 0);
                foreach (var item in dalyviuSarasas)
                {
                    if (item.KiekSuvalge > max)
                    {
                        max = item.KiekSuvalge;
                        maxDalyvis = item;
                    }
                   // Console.WriteLine("Laimejo {0} , suvalges {1}", maxDalyvis.Vardas, maxDalyvis.KiekSuvalge);
                }






            }
        
    }
}
    

