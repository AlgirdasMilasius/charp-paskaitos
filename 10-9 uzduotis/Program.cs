using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new[] { 7, 13, 4, -6, 12, 8, -99, 6, 0 };
            var Skaiciai2 = new[] { 7, 13, 4, -6, 12, 8};

            var Suma = 0;
            var Suma2 = 0;

            foreach (var sk in Skaiciai)
            {
                Suma += sk;
            }

            foreach (var sk in Skaiciai2)
            {
                Suma2 += sk;
            }

            Console.WriteLine("Pirma suma {0}, antra suma {1}, didziausia suma: {2}", Suma, Suma2, Math.Max(Suma, Suma2));

        }
    }
}
