using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 pazymius");
            var PirmasPazimys = Convert.ToInt32(Console.ReadLine());
            var AntrasPazimys = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (Double)(PirmasPazimys + AntrasPazimys) / 2;

            if (vidurkis >= 5)
            {
                Console.WriteLine("Vidurkis yra teigiamas");
            }
            else
            {
                Console.WriteLine("Vidurkis nera teigiamas");
            }
        }
    }
}
