using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            var Skaiciai = p.Generavimas(rand, 100, 1, 10);

            p.Spausdinti(Skaiciai);

        }

        public List<int> Generavimas(Random rand, int Kiek, int nuo, int iki)
        {
            var Skaiciai = new List<int>();
            for (int i = 0; i < Kiek; i++)
            {
                Skaiciai.Add(rand.Next(nuo, iki));
            }
            return Skaiciai;
        }

        public void Spausdinti(List<int> Skaiciai)
        {
            foreach (var item in Skaiciai)
            {
                Console.Write(item + " ");
            }
        }
    }
}
