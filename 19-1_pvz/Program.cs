using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_pvz
{
    class Program
    {
        public delegate int MathDelegate(int a, int b);

        static int Add(int a, int b)
        {
            Console.WriteLine((a+b));
            return (a + b);
        }

        static int Substract(int a, int b)
        {
            Console.WriteLine((a-b));
            return (a - b);
        }

        static void Main(string[] args)
        {
            MathDelegate mathoperation = Add; 
            int a = 10;
            int b = 5;
            int sum = mathoperation(a, b);
            //Console.WriteLine(mathoperation(a,b));
            mathoperation += Substract;  //prides kita metoda
            int sub = mathoperation(a, b);
            //Console.WriteLine(mathoperation(a, b));
        }
    }
}
