using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
            else
            {
                Console.WriteLine("Skaicius yra nelyginis");
            }
        }
    }
}
