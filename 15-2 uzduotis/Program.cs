using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var Zodz = p.Masyvas();

            p.Spausdinti(Zodz);

        }

        public new string[] Masyvas()
        {
            var Zodziai = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite {0}-aji zodi ", i + 1);
                Zodziai[i] = Console.ReadLine();
            }
            return Zodziai;
        }

        public void Spausdinti(string[] Zodeliai)
        {
            var min = 99;

            foreach (var Zodis in Zodeliai)
            {
                if (Zodis.Length < min)
                {
                    min = Zodis.Length;
                }

            }

            foreach (var Zodis in Zodeliai)
            {
                if (Zodis.Length == min)
                {
                    Console.Write(Zodis + " ");
                }

            }
            Console.WriteLine();
        }
    }
}

