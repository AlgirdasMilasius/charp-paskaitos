using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Trecias();

        }

        static void Pirmas()
        {
            var Sarasas = new List<string>() { "Labas", "Atia", "Viso", "Babai" };
            var rand = new Random();

            Console.WriteLine(Sarasas[rand.Next(0, Sarasas.Count)]);
        }

        static void Antras()
        {
            var rand = new Random();
            Console.WriteLine(rand.Next());

        }
        static void Trecias()
        {
            Pirmas();
            Antras();
        }
    }
}
