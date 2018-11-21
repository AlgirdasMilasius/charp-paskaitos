using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodas();
            Console.WriteLine();
            Masyvas();

        }
        static void Metodas()
        {
            var rand = new Random();
            var Saras = new List<int>();

            Console.WriteLine("Kiek norite ivesti skaiciu?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite Skaiciu");
                Saras.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var Item in Saras)
            {
                Console.Write(Item + " ");
            }
        }

        static void Masyvas()
        {
            var rand = new Random();
            var atsitiktiniai = new int[rand.Next(10, 100)];

            for (int i = 0; i < atsitiktiniai.Length; i++)
            {
                atsitiktiniai[i] = rand.Next(1000);
            }

            foreach (var item in atsitiktiniai)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
