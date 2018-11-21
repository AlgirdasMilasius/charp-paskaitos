using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            //Ar pirmas skaičius didesnis už antrą?
            //Ar trečias skaičius didesnis už pirmą?
            //Ar pirmi du skaičiai yra lygūs?
            //Ar paskutiniai du skaičiai yra lygūs?

            if (Pirmas > Antras)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            else if (Trecias > Pirmas)
            {
                Console.WriteLine("Trecias skaicius didesnis uz pirma");
            }
            else if (Pirmas == Antras)
            {
                Console.WriteLine("Pirmas ir antras skaiciai vienodi");
            }
            else if (Antras == Trecias)
            {
                Console.WriteLine("Antras ir trecias skaiciai vienodi");
            }


        }
    }
}
