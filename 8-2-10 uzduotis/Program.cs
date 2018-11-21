using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kiekis = 1;

            while (Kiekis <= 50)
            {
                Console.Write("Skaicius " + Kiekis + " dalinasi is: ");

                var Dalmuo = 2;
                while (Dalmuo < 10)
                {
                    if (Kiekis % Dalmuo == 0)
                    {
                     Console.Write(Dalmuo + " ");
                    }
                    Dalmuo++;
                }
                Console.WriteLine();
                Kiekis++;
            }
        }
    }
}
