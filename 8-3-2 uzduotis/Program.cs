using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 1;

            do
            {
                if (Skaicius % 5 == 0)
                {
                    Console.WriteLine("Dalinasi is 5");
                }
                else
                {
                    Console.WriteLine(Skaicius);
                }
                    Skaicius++;

            } while (Skaicius % 100 != 0);

        }
    }
}
