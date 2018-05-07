using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program(); // objektas, kvieciamas metodas
                                          //var vartotojo_vardas = programa.vartotojoVardas(); //kuriamas kintamasis = kvieciamas metodas //su void neina prisilyginti nieko
                                          ////programa.pasisveikinti(vartotojo_vardas); //kvieciamas metodas - nieko negrazina, nes yra void, pagal pvz tik isveda
                                          //var amzius = programa.vartotojoAmzius();
                                          //programa.pasisveikinti(vartotojo_vardas, amzius); //kvieciamas metodas - nieko negrazina, nes yra void, pagal pvz tik isveda

            ////programa.ivesk_skaiciu();



            var sarasas = programa.sarasas();
            foreach (var sk in sarasas)
            {
                Console.Write(sk + " ");
            }
            Console.WriteLine();
             //programa.didziausias(sarasas);

            Console.WriteLine(programa.didziausias(sarasas));
            //foreach (var d_sk in sarasas)
            //{
            //    Console.WriteLine("didziausias sk" + d_sk);
            //}

        }

        //parasyti metoda, kuris grazintu List<int> tipo atsakyma,
        //o metode leiskite vartotojui suvesti duomenis i si sarasa.
        //ten kur kviesite metoda, ji prisilyginkite var skaiciai
        //isveskite visas saraso reiksmes i ekrana

        public List<int> sarasas()
        {
            List<int> list = new List<int>();

            Console.WriteLine("suvesk 5 skaicius: ");
            for (int i = 0; i < 5; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return list;
        }
        //parasyto ,metoda, kuris is gauto saraso rastu didziausia skaiciu ir ji grazintu
        public int didziausias(List<int> sarasas)
        {
            var d_sk = 0;
            for (int i = 0; i < sarasas.Count; i++)
            {
                if (d_sk < sarasas[i])
                {
                    d_sk = sarasas[i];
                }
                //didziausias
            }
            return d_sk;
        }

        //parasyti metoda, kuris is gauto saraso rastu skaiciu suma

        //public int suma(List<int> sarasas)
        //{
        //    //ieskoti sumos
        //}

        ////parasyti metoda, kuris gautu turimo saraso vidurki (sumai gauti naudoti pries tai aprasyta sumos radimo metoda)

        //public double Vidurkis(List<int> sarasas)
        //{
        //    var suma = suma(sarasas);
            //    var kiekis = ..;
            //    var vidurkis = ..

            //        return vidurkis;
            //}


            //liepia ivesti skaiciu
            ////public void ivesk_skaiciu()
            ////{
            ////    Console.WriteLine("ivesk sveika skaiciu: ");
            ////    int skaicius = Convert.ToInt32(Console.ReadLine());
            ////    int skaicius2 = Convert.ToInt32(Console.ReadLine());
            ////    // kvieciamas int suma() metodas

            ////    Console.WriteLine("suma: " + suma(skaicius, skaicius2));

            ////}

            ////public int suma(int a, int b)
            ////{
            ////    return a + b;
            ////}


            //public void pasisveikinti(string vardas, int amzius) //
            //{
            //    Console.WriteLine("o labas, " + vardas + " tau " + amzius + " metu, cha cha :)");
            //}

            //public string vartotojoVardas()
            //{
            //    Console.WriteLine("ivesk varda: ");
            //    var vardas = Console.ReadLine();
            //    return vardas;
            //}

            ////vartotojo amzius
            //public int vartotojoAmzius()
            //{
            //    Console.WriteLine("kiek tau metu?");
            //    int amzius = Convert.ToInt32(Console.ReadLine());
            //    return amzius;
            //}
        }

    }
