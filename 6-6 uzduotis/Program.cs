using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            var vidurkis = ((Pirmas + Antras + Trecias) / 3);
            Console.WriteLine(vidurkis);

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("Puikiai [8-10]");
            }
            else if (vidurkis >=5 && vidurkis <= 8)
            {
                Console.WriteLine("OK [5-8]");
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("Neislaikyta [<5]");
            }
            else
            {
                Console.WriteLine("Ivedet netinkamus balus");
            }
            //ar gautas vidurkis yra[8 - 10];
            //ar gautas vidurkis yra[5 - 8);
            //ar gautas vidurkis yra< 5.

        }
    }
}
