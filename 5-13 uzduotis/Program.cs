using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            //Ar skaičius dalinasi iš 2 ?
            //Ar skaičius dalinasi iš 3 ?
            //Ar skaičius dalinasi iš 4 ?
            //Ar skaičius dalinasi iš 5 ?
            //Ar skaičius dalinasi iš 7 ?
            //Jeigu skaičius iš nieko nesidalina, išvesti klaidos pranešimą.

            if (Skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 2");
            }
            else if (Skaicius %3 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 3");
            }
            else if (Skaicius % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            else if (Skaicius % 7 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 7");
            }
            else
            {
                Console.WriteLine("Ir vel tu kaltas del klaidos");
            }

        }
    }
}
