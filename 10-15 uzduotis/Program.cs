using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Skaicius = rand.Next(1, 100);
            var Masyvas = 0;
            var Masyvas2 = new int[100];

            for (int i = 0; i < 100; i++)
            {
                Masyvas = rand.Next(1, 100);

                if (Skaicius < Masyvas)
                {
                    Masyvas2[i] += Masyvas;
                }
            }

            Console.WriteLine(Masyvas2.Sum() + " " + Masyvas2.Average());
    
        }
    }
}
