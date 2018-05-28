using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Korta
    {
        public string Skaicius { get; }
        public char Zenklai { get; }

        //privatus metodas, kuris grazins string tipa
        private string SkaiciausKeitimasIRaide(string Skaicius)
        {
            switch (Skaicius)
            {
                case "1":
                    return "A";

                case "11":
                    return "J";

                case "12":
                    return "Q";

                case "13":
                    return "K";

                default:
                    return Skaicius;

            }
        }


        public Korta(string Skaicius, char Zenklai) //parametru sarasas
        {
            this.Skaicius = SkaiciausKeitimasIRaide(Skaicius); //this nurodo kad ims is class Korta ir ims Skaicius, kvieciamas metodas
            this.Zenklai = Zenklai;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Random rng = new Random();
            char[] raides = { 'K', 'S', 'B', 'P' }; //kortu zenklu masyvas

            //ciklas, kuris sugeneruos 52 kortas (raide + skaicius)
            int i = 0;
            List<Korta> kalade = new List<Korta>();
            while (i < 52)
            {
                Korta laikinaKorta = new Korta(rng.Next(1, 14).ToString(), raides[rng.Next(0, raides.Length)]);

                //surasti ar tokia korta jau yra kaladeje (vienodu kortu nedubliavimas)
                bool pozymis = true;
                foreach (var item in kalade)
                {
                    if (laikinaKorta.Skaicius == item.Skaicius && laikinaKorta.Zenklai == item.Zenklai)
                    {
                        pozymis = false;
                        break; //nutraukia cikla
                    }
                }
                if (pozymis) //pozymis bus true
                {
                    kalade.Add(laikinaKorta);
                    i++;
                }
            }

            foreach (var item in kalade)
            {
                Console.WriteLine(item.Zenklai + " " + item.Skaicius);
            }

        }
    }


}
