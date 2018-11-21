using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 25;

            while (Skaicius<=50)
            {
                if (Skaicius % 3 == 0)
                {
                    Console.WriteLine("Dalinasi is 3");
                }
                else
                {
                    Console.WriteLine(Skaicius);
                }
                Skaicius++;
            }

        }
    }
}
