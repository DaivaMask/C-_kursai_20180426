
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_112uotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk pirma skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ivesk antra skaiciu");
            var b = Convert.ToInt32(Console.ReadLine());

            var veiksmas = "t";
            while (veiksmas == "t")
            {
                //Console.WriteLine("ivesk pirma skaiciu");
                //var a = Convert.ToInt32(Console.ReadLine())

                //Console.WriteLine("ivesk antra skaiciu");
                //var b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a + " + " + b +" = " + (a+b));
                Console.WriteLine(a + " - " + b + " = " + (a - b));
                Console.WriteLine(a + " * " + b + " = " + (a * b));
                Console.WriteLine(a + " / " + b + " = " + (a / b));
                
                Console.WriteLine("ar nori dar skaiciuoti? t/n");
                    veiksmas = Console.ReadLine();
            }


        }
    }
}
