using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 1;
            var Suma = 0;
            var Kiekis = 0;

            do
            {
                if (Skaicius % 2 != 0)
                {
                    Suma += Skaicius;
                    Kiekis++;
                }
                Skaicius++;

            } while (Skaicius <50);

            Console.WriteLine("Suma: " + Suma);
            Console.WriteLine("Vidurkis: " + (Suma/Kiekis));
        }
    }
}
