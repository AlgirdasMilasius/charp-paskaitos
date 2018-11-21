using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 18;
            do
            {
                Console.WriteLine(Skaicius);
                Skaicius++;

            } while (Skaicius % 17 != 0);

        }
    }
}
