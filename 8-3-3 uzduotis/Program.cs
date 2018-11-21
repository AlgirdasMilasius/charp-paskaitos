using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 1;
            var Suma = 0;

            do
            {
                if (Skaicius % 2 == 0)
                {
                    Suma += Skaicius;
                }
                Skaicius++;

            } while (Skaicius % 20 != 0);
            Console.WriteLine(Suma);

        }
    }
}
