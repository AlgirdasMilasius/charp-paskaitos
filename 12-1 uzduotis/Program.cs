using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rand = new Random();
            var Skaiciai = new List<int>();
            var Kiek = 10;

            for (int i = 0; i < Kiek; i++)
            {
                Skaiciai.Add(Rand.Next(100));
            }

            foreach (var Skaicius in Skaiciai)
            {
                Console.Write(Skaicius + " ");
            }
            Console.WriteLine();

            Console.WriteLine(Skaiciai.Min());


        }
    }
}
