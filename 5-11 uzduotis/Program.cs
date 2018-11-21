using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius % 7 == 0)
            {
                Console.WriteLine("Norimas tekstas");
            }
            else
            {
                Console.WriteLine("Pasirinkote bloga skaiciu :(");
            }

        }
    }
}
