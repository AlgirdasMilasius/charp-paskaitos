using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskita Varda");
            var Vardas = Console.ReadLine();

            Console.WriteLine("Iveskite Pavarde");
            var Pavarde = Console.ReadLine();
            Console.WriteLine("Sveikas, " + Vardas + " " + Pavarde);
        }
    }
}
