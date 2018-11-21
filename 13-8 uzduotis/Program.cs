using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Metodas();
            }

        }
        static void Metodas()
        {
            var rand = new Random();
            var skaicius = rand.Next(100);
            Console.Write("{0,-3}", skaicius);
        }
    }
}
