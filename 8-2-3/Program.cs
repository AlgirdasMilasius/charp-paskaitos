using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            while (skaicius <=100)
            {
                Console.Write(skaicius);
                if (skaicius<100)
                {
                    Console.Write(",");
                }
                skaicius++;
            }
            Console.WriteLine();
        }
    }
}
