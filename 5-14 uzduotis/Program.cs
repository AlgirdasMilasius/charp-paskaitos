using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());

            //Ar pirmas skaičius didesnis už antrą?
            //Ar antras skaičius didesnis už pirmą?
            //Jeigu nei vienas skaičius nėra didesnis už kitą -tai skaičiai yra lygūs.

            if (Pirmas > Antras)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            else if (Pirmas < Antras)
            {
                Console.WriteLine("Antras skaicius didesnis uz pirma");
            }
            else
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
        }
    }
}
