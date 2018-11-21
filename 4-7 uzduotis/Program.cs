using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());
            var Ketvirtas = Convert.ToInt32(Console.ReadLine());
            var Penktas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciai: {0} {1} {2} {3} {4}", Pirmas, Antras, Trecias, Ketvirtas, Penktas);
            Console.WriteLine("Vidurkis: " + (Pirmas + Antras + Trecias + Ketvirtas + Penktas) / 5);
        }
    }
}
