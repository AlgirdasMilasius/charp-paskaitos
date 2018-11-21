using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var Vardas = "ALG";
            var Amzius = 21;
            Console.WriteLine("Vardas: {0}", Vardas);
            Console.WriteLine("Amzius: {0}", Amzius);

            var Pavadinimas = "Liepa";
            var Aukštis = 7; //m
            var Storis = 145; //mm
            Console.WriteLine("Medis {0} yra {1} metru aukscio ir {2} mm storio", Pavadinimas, Aukštis, Storis);

            var Skaicius = 25;
            Console.WriteLine("{0}{0}{0}{0}{0}", Skaicius);
            Console.WriteLine("{0} {0} {0} {0} {0}", Skaicius);

            var Simbolis = "*";
            Console.WriteLine("{0}{0}{0}{0}\n{0}  {0}\n{0}  {0}\n{0}{0}{0}{0}", Simbolis);

        }
    }
}
