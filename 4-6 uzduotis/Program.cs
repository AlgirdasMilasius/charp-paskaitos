using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ivedete skaicius " + Skaicius);
            Console.WriteLine("Jusu skaicius kvadratu " + Math.Pow(Skaicius, 2));

        }
    }
}
