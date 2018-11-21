using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodas();
        }
        static void Metodas()
        {
            Console.WriteLine("Iveskite varda");
            var Vardas = Console.ReadLine();
            Console.WriteLine("Sveikas " + Vardas);
            
        }

    }
}
