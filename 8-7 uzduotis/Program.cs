using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Pirmas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu is kurio norite dauginti");
            var Antras = Convert.ToInt32(Console.ReadLine());
            int Z = 0;

            for (int i = 0; Z <= Antras; i +=Pirmas, Z++)
            {
                if (Z == Antras)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
