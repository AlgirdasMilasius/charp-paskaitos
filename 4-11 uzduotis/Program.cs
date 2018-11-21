using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());
            var Kintamasis = 1;


            Console.WriteLine("{0} * {1} = " + Skaicius * Kintamasis, Skaicius, Kintamasis);
            Kintamasis++;
            Console.WriteLine("{0} * {1} = " + Skaicius * Kintamasis, Skaicius, Kintamasis);
            Kintamasis++;
            Console.WriteLine("{0} * {1} = " + Skaicius * Kintamasis, Skaicius, Kintamasis);
            Kintamasis++;
            Console.WriteLine("{0} * {1} = " + Skaicius * Kintamasis, Skaicius, Kintamasis);
            Kintamasis++;
            Console.WriteLine("{0} * {1} = " + Skaicius * Kintamasis, Skaicius, Kintamasis);

        }
    }
}
