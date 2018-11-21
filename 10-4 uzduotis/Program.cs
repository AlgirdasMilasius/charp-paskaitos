using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pirmas = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Antras = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Trecias = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();
            var Max = 0;
            string MaxKuris = "a";

            var Skaicius = rand.Next(1, Pirmas.Length - 1);
            Console.WriteLine(Pirmas[Skaicius]);
            if (Max < Pirmas[Skaicius])
            {
                Max = Pirmas[Skaicius];
                MaxKuris = "pirmas";
            }

            Skaicius = rand.Next(1, Pirmas.Length - 1);
            Console.WriteLine(Antras[Skaicius]);
            if (Max < Antras[Skaicius])
            {
                Max = Antras[Skaicius];
                MaxKuris = "antras";

            }

            Skaicius = rand.Next(1, Pirmas.Length - 1);
            Console.WriteLine(Trecias[Skaicius]);
            if (Max < Trecias[Skaicius])
            {
                Max = Trecias[Skaicius];
                MaxKuris = "trecias";

            }

            Console.WriteLine("Didziausias skaicius yra " + MaxKuris + " : " + Max);
        }
    }
}
