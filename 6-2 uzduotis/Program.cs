using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius > 0 && Skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius yra teigiamas ir lyginis");
            }

        }
    }
}
