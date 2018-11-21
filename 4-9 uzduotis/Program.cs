using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Suma = Pirmas + Antras;
            var Skirtumas = Pirmas - Antras;
            var Sandauga = Pirmas * Antras;
            var Dalyba = Pirmas / Antras;

            Console.WriteLine("{0} + {1} = {2}", Pirmas, Antras, Suma);
            Console.WriteLine("{0} - {1} = {2}", Pirmas, Antras, Skirtumas);
            Console.WriteLine("{0} * {1} = {2}", Pirmas, Antras, Sandauga);
            Console.WriteLine("{0} / {1} = {2}", Pirmas, Antras, Dalyba);

        }
    }
}
