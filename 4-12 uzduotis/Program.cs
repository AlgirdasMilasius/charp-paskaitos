using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kvadratai: " + Math.Pow(a, 2) + " " + Math.Pow(b, 2) + " " + Math.Pow(c, 2));
            Console.WriteLine("Kubu: " + Math.Pow(a, 3) + " " + Math.Pow(b, 3) + " " + Math.Pow(c, 3));
            Console.WriteLine("Padalinta iš 2: " + a/2 + " " + b/2 + " " + c/2);

        }
    }
}
