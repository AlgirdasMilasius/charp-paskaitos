using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardas = new[] {"Algirdas", "Petras", "Jonas", "Kazys", "Ieva", "Jurgita", "Laura", "Kotryna" };
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                var Skaicius = rand.Next(0, Vardas.Length - 1);
                Console.WriteLine(Vardas[Skaicius]);
            }

        }
    }
}
