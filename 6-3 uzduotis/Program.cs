using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius % 2 == 0 || Skaicius % 5 == 0 || Skaicius % 7 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 2 arba 5 arba 7");
            }
        }
    }
}
