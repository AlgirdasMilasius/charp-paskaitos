using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite Pavadinima");
            var Pavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite Seima");
            var Seima = Console.ReadLine();

            Console.WriteLine("Iveskite Regiona");
            var Regionas = Console.ReadLine();

            Console.WriteLine("Gyvunas {0} priklauso {1} seimai ir yra randamas {2}", Pavadinimas, Seima, Regionas);

        }
    }
}
