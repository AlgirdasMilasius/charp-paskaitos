using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            while (skaicius < 50)
            {
                Console.Write(skaicius);

                if (skaicius % 2 == 0)
                {
                    Console.Write(" Lyginis");
                }
                else if (skaicius % 2 != 0)
                {
                    Console.Write(" Nelyginis");
                }

                Console.WriteLine();
                skaicius++;
            }
        }
    }
}
