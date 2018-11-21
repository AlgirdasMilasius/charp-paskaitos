using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sarasas = new List<string> { "string", "kintamasis", "iš", "tiesų", "yra", "char", "masyvas" };
            var Sarasas2 = new List<string> { "Parašykite", "metodą", "kuris", "išasaa", "gauto", "žodžių", "sąrašo", "rastų" };

            var p = new Program();

            p.Metodas(Sarasas);
            p.Metodas(Sarasas2);


        }

        public void Metodas(List<string> SarasasMetodas)
        {
            var min = 99;
            foreach (var Zodis in SarasasMetodas)
            {
                if (Zodis.Length < min)
                {
                    min = Zodis.Length;
                }
            }

            foreach (var Zodis in SarasasMetodas)
            {
                if (Zodis.Length == min)
                {
                    Console.Write("@@@@" + Zodis + " ");
                }
                else
                {          
                Console.Write(Zodis + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
