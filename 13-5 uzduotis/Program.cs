using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodas();
            

        }
        static void Metodas()
        {
            var rand = new Random();
            var Lentele = new List<int>();

            Lentele.Add(rand.Next(100));
            Lentele.Add(rand.Next(100));
            Lentele.Add(Lentele[0] + Lentele[1]);

            foreach (var Skaicius in Lentele)
            {
                Console.Write(Skaicius + " ");
            }
            Console.WriteLine();
        }

    }
}
