using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rezio pradzia");
            var Pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite rezio pabaiga");
            var Pabaiga = Convert.ToInt32(Console.ReadLine());

            if (Pradzia<Pabaiga)
            {
                for (int i = Pradzia; i <= Pabaiga; i++)
                {
                    Console.WriteLine(i + " " + Math.Pow(i,2));
                }
            }

        }
    }
}
