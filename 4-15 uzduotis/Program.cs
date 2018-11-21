using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //vardas; pavardė; gimimo metai; specialybė; etatas (nuo 0 iki 1); gaunama alga.
            Console.WriteLine("Iveskite Varda, Pavarde; Gimimo metus; Specialybe; Etata (nuo 0 iki 1); Gaunama alga (eur/men)");
            var Vardas = Console.ReadLine();
            var Pavarde = Console.ReadLine();
            var GimimoMetai = Convert.ToInt32(Console.ReadLine());
            var Specialybe = Console.ReadLine();
            var Etatas = Convert.ToDouble(Console.ReadLine());
            var GaunamaAlga = Convert.ToInt32(Console.ReadLine());

            var Amzius = 2018 - GimimoMetai;

            Console.WriteLine("{0} {1} ({2} m.) dirba {3} {4} etatu ir uzdirba {5} eur/men"
                , Vardas, Pavarde, Amzius, Specialybe, Etatas, GaunamaAlga);           
            //Algis Algiausias (52 m.) dirba policininku 0.5 etatu ir uždirba 500 eur/mėn.
        }
    }
}
