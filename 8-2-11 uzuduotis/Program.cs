using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_11_uzuduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Suma = 0;

            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            while (Skaicius != 0)
            {
                Suma += Skaicius;
                Console.WriteLine("Iveskite dar viena skaiciu");
                Skaicius = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Visu skaicius suma: " + Suma);

        }
    }
}
