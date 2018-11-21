using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());

            //ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            if (Pirmas > Antras || Pirmas == 0)
            {
                Console.WriteLine("Pirmas skaicius arba didesnis uz antra, arba yra lygus 0");
            }
            //ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            if (Antras > Pirmas || Antras == 5)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma, arba lygus 5");
            }
            //ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            if (Pirmas > Antras && Pirmas == 20)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra ir yra lygus 20");
            }
            //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;
            if(Antras > Pirmas && Antras < 100)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma ir yra mazesnis uz 100");
            }


        }
    }
}
