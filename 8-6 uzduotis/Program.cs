using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rezio pradzia");
            var Pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite rezio pabaiga");
            var Pabaiga = Convert.ToInt32(Console.ReadLine());

            if (Pradzia < Pabaiga)
            {
                for (int i = Pradzia; i <= Pabaiga; i++)
                {
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine("Skaicius {0} yra nelyginis arba dalinasi is 8", i);
                    }
                }
            }

        }
    }
}
