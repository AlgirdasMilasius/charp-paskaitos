using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kiekis = 1;
            var Sandauga = 1;

            while (Kiekis <= 10)
            {
                Sandauga = Sandauga * Kiekis;
                Kiekis++;
            }
            Console.WriteLine(Sandauga);

            //Kiekis = 0;
            //Sandauga = 1;
            //while (Kiekis < 10)
            //{
            //    Kiekis++;
            //    Sandauga = Sandauga * Kiekis;

            //}
            //Console.WriteLine(Sandauga);
        }
    }
}
