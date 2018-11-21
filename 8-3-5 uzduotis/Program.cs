using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Skaicius = 0;

            do
            {
                Skaicius = rand.Next(1, 100);
                Console.WriteLine(Skaicius);

            } while (Skaicius % 3 != 0);

        }
    }
}
