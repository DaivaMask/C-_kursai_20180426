using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _4_uzduotis
{
    class AmziusNeaiskusExeption : Exception
    {
        public int Amzius { get; set; }
        public AmziusNeaiskusExeption(int Amzius)
        {
            this.Amzius = Amzius;
        }

    }

    class Asmenys
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public Asmenys(string Vardas, int Amzius)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //txt faile: vardas amzius
            StreamReader reader = new StreamReader("amzius.txt");
            List<Asmenys> asmenuSarasas = new List<Asmenys>();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] data = line.Split(' ');
                    Asmenys asmuo = new Asmenys(data[0], int.Parse(data[1]));
                    if (asmuo.Amzius < 0)
                        throw new AmziusNeaiskusExeption(asmuo.Amzius);
                    asmenuSarasas.Add(asmuo);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Yra amzius < 0");
                }

            }

                //Asmenys pirmasAsmuo = new Asmenys(null, 0);
                foreach (var item in asmenuSarasas)
                {

                    if (Convert.ToInt32(item.Amzius) < 16)
                    {
                        Console.WriteLine(item.Vardas + " - vaikas, amzius - " + item.Amzius);
                    }

                    else if (Convert.ToInt32(item.Amzius) > 65)
                    {
                        Console.WriteLine(item.Vardas + " - pensininkas, amzius - " + item.Amzius);
                    }
                }


            }
        }
    }






