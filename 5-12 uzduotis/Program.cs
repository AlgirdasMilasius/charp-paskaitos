using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());

            if (Pirmas > Antras)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            else
            {
                Console.WriteLine("Ivyko klaida :( nes tu kaltas!!!!!!");
            }
        }
    }
}
