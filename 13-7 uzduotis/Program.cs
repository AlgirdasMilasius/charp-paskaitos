using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodas();
            Console.WriteLine();
        }
        static void Metodas()
        {
            var rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                var Skaicius = rand.Next(1000);
                Console.Write(Skaicius + " ");
            }
        }
    }
}
