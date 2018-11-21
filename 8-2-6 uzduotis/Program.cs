using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Kiekis = 0;
            var Suma = 0;


            while (Kiekis <= 10)
            {
                var Skaicius = rand.Next(1, 100);
                Console.WriteLine(Skaicius);
                Suma += Skaicius;
;
                Kiekis++;
            }

            Console.WriteLine("Skaiciu suma: " + Suma);
        }
    }
}
