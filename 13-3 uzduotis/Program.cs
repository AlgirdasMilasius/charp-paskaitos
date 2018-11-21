using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Norimi = new List<string>();
            Console.WriteLine("Kiek norite suvesti zodziu");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite norima zodi");
                Norimi.Add(Console.ReadLine());

            }

            foreach (var Noriu in Norimi)
            {
                Metodas(Noriu);
            }
        }

        static void Metodas(string X)
        {
            Console.WriteLine("-" +X);
        }
    }
}
