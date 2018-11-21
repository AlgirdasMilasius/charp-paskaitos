using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Kiekis = 1;
            var Suma = 0;

            while (Kiekis <= 100)
            {
                var Skaicius = rand.Next(1, 100);
                Console.Write(Skaicius);
                if (Kiekis < 100)
                {
                    Console.Write(",");
                }
                Suma += Skaicius;
                Kiekis++;
            }
            Console.WriteLine();
            Console.WriteLine("Visu skaiciu suma: " + Suma);
            Console.WriteLine("Visu skaiciu Vidurkis: " + (Suma/Kiekis));
        }
    }
}
