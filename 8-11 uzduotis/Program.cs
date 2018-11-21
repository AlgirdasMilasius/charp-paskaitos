using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Rasti visų skaičių, žemesnių už 1000 ir kurie dalinasi iš 3 arba 5, sumą.

            var suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Skaiciu zemesniu uz 1000 kurie dalinasi is 3 ir 5 suma: " + suma);
        }
    }
}
