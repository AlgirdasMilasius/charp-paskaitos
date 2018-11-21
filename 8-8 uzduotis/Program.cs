using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(" skaiciu [1-100] suma: " + suma);

        }
    }
}
