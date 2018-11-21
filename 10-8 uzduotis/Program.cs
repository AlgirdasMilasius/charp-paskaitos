using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new[] { 7, 13, 4, -6, 12, 8, -99, 6, 0 };
            var Suma = 0;
            var Vidurkis = Skaiciai.Length;

            foreach (var SK in Skaiciai)
            {
                Suma += SK;
            }
            Console.WriteLine("Suma: " + Suma);
            Console.WriteLine("Vidurkis: " + (Suma/Vidurkis));

        }
    }
}
