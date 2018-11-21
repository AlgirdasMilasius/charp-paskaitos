using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 1;

            while (Skaicius % 3 != 0 && Skaicius % 5 != 0)
            {
                Console.WriteLine(Skaicius);
                Skaicius++;
            }

        }
    }
}
