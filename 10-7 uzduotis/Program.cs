using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new[] { 7, 13, 4, -6, 12, 8, -99, 6, 0 };
            Random rand = new Random();
            var Antriniai = new[] { rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10) };

            for (int i = 0; i < Skaiciai.Length; i++)
            {
                Console.WriteLine("Indekse {0} yra skaicius {1}", i, Skaiciai[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < Antriniai.Length; i++)
            {
                Console.WriteLine("Indekse {0} yra skaicius {1}", i, Antriniai[i]);
            }

        }
    }
}
