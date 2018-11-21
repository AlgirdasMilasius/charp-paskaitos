using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pirmas = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < Pirmas.Length; i++)
            {
                Console.Write(Pirmas[i]);
                if (i < Pirmas.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
