using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardas = new[] { "Algirdas", "Petras", "Jonas", "Kazys", "Ieva", "Jurgita", "Laura", "Kotryna" };
            for (int i = 0; i < Vardas.Length; i++)
            {
                Console.WriteLine(i + " " + Vardas[i]);
            }
            //foreach atiduoda tik duomenis o ne indeksa (neseka indekso)
        }
    }
}
