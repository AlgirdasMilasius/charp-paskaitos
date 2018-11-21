using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Produktas = new[] { "Piestukas", "Tusinukas", "Trintukas", "Penalas" };
            var Kaina = new[] { 0.50, 0.99, 0.75, 3.00 };

            for (int i = 0; i < Produktas.Length; i++)
            {
                Console.WriteLine(Produktas[i] + " " + Kaina[i]);
            }
        }
    }
}
