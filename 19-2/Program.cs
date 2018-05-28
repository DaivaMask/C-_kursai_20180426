using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2
{
    class Program
    {
        /* jie yra sukurti sistemoje, nereikia atskirai kurtis (kas uzkomentuota):
        public delegate void Action ();
        public delegate void Action<T>(T arg); //Action gali tureti 16 parametru

        public delegate T Func<T> (); //gauti tam tikra informacija; T - neapibreztas tipas
        public delegate T Func<T, K>(K arg); //func gali tureti iki 15 parametru
        
    */

        static void Main(string[] args)
        {
            Photo photo = new Photo();
            Action virt = RemoveRedEye;
            Action<int, int> math = Add;

            Func<string> pavyzdys = A;
            Func<int, string> pvz = B;

            string result = pavyzdys();
            string res = pvz(1);

            //vienintele vieta, kai naudojama out (baigiasi po if)
            int sk = 0;
            bool ats = int.TryParse("1", out sk);
            if (int.TryParse("1", out sk)) //dazniau naudojama tokioj vietoj
            {

            }
          //  int.Parse(); //gazins exeption



            PhotoFiltras filtras = new PhotoFiltras();
            photo.ApplyFilter(filtras.GrayScale);
            photo.ApplyFilter(RemoveRedEye);

        }

        static string A()
        {
            return "A";

        }
        static string B(int K)
        {
            return "B";

        }

        static void Add(int a, int b)
        {

        }
        static void RemoveRedEye()
        {
            Console.WriteLine("taikomas Remove Red Eye filtras");
        }
    }
}
