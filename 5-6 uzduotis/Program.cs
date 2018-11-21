using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            //Jei skaičius lyginis, tuomet išveskite šį skaičių, bei jo penktą laipsnį.
            if (Skaicius % 2 == 0)
            {
                Console.WriteLine(Skaicius + " " + Math.Pow(Skaicius, 5));
            }
            //Jei skaičius nesidalina iš 4, tuomet liepkite įveskite antrąjį skaičių.Išveskite abiejų skaičių sumą ir sandaugą.
            if (Skaicius % 4 != 0)
            {
                Console.WriteLine("Iveskite antra skaiciu");
                var AntrasSkaicius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine((Skaicius + AntrasSkaicius) + " " + (Skaicius * AntrasSkaicius));

            }
        }
    }
}
