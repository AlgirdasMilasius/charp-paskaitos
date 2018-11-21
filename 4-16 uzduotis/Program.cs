using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //vardas; pavardė; grupės kodas; aukštosios mokyklos pavadinimas; norimą kiekį pažymių (pavyzdžiui 3 pažymius).
            Console.WriteLine("Iveskite Varda, Pavarde, Grupės koda, Aukštosios mokyklos pavadinima; 3 pažymius");
            var Vardas = Console.ReadLine();
            var Pavarde = Console.ReadLine();
            var GrupesKodas = Console.ReadLine();
            var AukstosiosPavadinimas = Console.ReadLine();
            var pazymis1 = Convert.ToInt32(Console.ReadLine());
            var pazymis2 = Convert.ToInt32(Console.ReadLine());
            var pazymis3 = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (double)(pazymis1 + pazymis2 + pazymis3) / 3;

            Console.WriteLine("{0} {1} mokosi grupeje {2} mokykle {3}, vidurkis: {4}"
                , Vardas, Pavarde, GrupesKodas, AukstosiosPavadinimas, vidurkis);


        }
    }
}
