using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardas = new[] { "Algirdas", "Petras", "Jonas", "Kazys", "Ieva", "Jurgita", "Laura", "Kotryna" };
            var AntrasVardas = new[] { "Algirdas", "Petras", "Jonas", "Kazys", "Ieva", "Jurgita", "Laura", "Kotryna" };

            Console.WriteLine(Vardas[0] + " " + AntrasVardas[AntrasVardas.Length-1]);

        }
    }
}
