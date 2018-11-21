using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_UZDUOTIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 3;
            Console.WriteLine(Math.Pow(Skaicius, 2) + "+" + Math.Pow(Skaicius, 3));
            Console.WriteLine(Math.Pow(Skaicius, 2));

            var a = 2;
            var b = 3;
            var c = 4;
            Console.WriteLine(a + b + c);
            Console.WriteLine(a * b * c);

            var z = 3;
            var x = 5;

            var Suma = z + x;
            var Skirtumas = z - x;

            Console.WriteLine("Sandauga: " + Suma * Skirtumas);
            Console.WriteLine("Dalmuo: " + Suma / Skirtumas);

            var q = 5;
            var w = 5;
            var e = 5;
            var r = 4;

            Console.WriteLine((double) (q + w + e + r) / 4);


        }
    }
}
