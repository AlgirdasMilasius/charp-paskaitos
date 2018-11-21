using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek norite ivesti skaiciu?");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            var Sarasas = new List<int>();
            var p = new Program();

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                Sarasas.Add(Convert.ToInt32(Console.ReadLine()));
            }

            p.Metodas(Sarasas);


        }
        public void Metodas(List<int> x)
        {
            Console.WriteLine("Maziausias: " + x.Min());

        }
    }
}
