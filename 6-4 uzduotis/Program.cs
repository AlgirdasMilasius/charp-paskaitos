using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            if (Pirmas>Antras && Pirmas > Trecias)
            {
                Console.WriteLine("Pirmas skaicius yra didziausias");
            }
            else if (Antras > Trecias)
            {
                Console.WriteLine("Antras skaicius yra didziausias");
            }
            else
            {
                Console.WriteLine("Trecias skaicius yra didziausias");
            }
        }
    }
}
