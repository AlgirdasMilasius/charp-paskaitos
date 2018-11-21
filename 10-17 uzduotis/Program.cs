using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Miestai = new[] { "Kaunas", "Vilnius", "Klaipeda", "Riga", "Talinas" };
            var Gyventojai = new[] { 100000, 250000, 97461, 2674321, 1384351 };

            for (int i = 0; i <Miestai.Length ; i++)
            {
                Console.WriteLine("Mieste {0} gyvena {1} gyventojai", Miestai[i], Gyventojai[i]);
            }


        }
    }
}
