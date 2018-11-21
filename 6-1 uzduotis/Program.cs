using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            var pradzia = 1;
            var pabaiga = 100;

            if (Skaicius > pradzia && Skaicius < pabaiga)
            {
                Console.WriteLine("Skaicius patenka i rezi");
            }
        }
    }
}
