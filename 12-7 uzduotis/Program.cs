using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var Rand = new Random();
            var Skaiciai = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                Skaiciai.Add(Rand.Next(100));
            }

            foreach (var Skaicius in Skaiciai)
            {
                Console.Write(Skaicius + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Paskutinis " + Skaiciai.Last());
            Console.WriteLine("Random " + Skaiciai[Rand.Next(Skaiciai.Count())]);
            Console.WriteLine("Min " + Skaiciai.Min());
            Console.WriteLine("Max " + Skaiciai.Max());
            Console.WriteLine("Suma " + Skaiciai.Sum());
            Console.WriteLine("Vidurkis " + Skaiciai.Average());

            var Lyginiai = 0;
            foreach (var Skaicius in Skaiciai)
            {
                if (Skaicius % 2 == 0)
                {
                    Lyginiai++;
                }
            }
            Console.WriteLine("Lyginiu skaiciu kiekis " + Lyginiai);

        }
    }
}
