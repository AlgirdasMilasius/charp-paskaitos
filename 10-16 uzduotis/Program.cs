using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Masyvas = new int[25];

            for (int i = 0; i < 25; i++)
            {
                Masyvas[i] = rand.Next(1,100);
            }

            for (int i = 0; i < 25; i+=5)
            {
                Console.Write("" + Masyvas[0 + i] + " " + Masyvas[1 + i] + " " + Masyvas[2 + i] + " " + Masyvas[3 + i]
                    + " " + Masyvas[4 + i]);
                Console.WriteLine();
            }

        }
    }
}
