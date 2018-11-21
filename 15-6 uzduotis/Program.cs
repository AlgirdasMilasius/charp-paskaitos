using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var Skaiciai = p.SkaiciuMasyvas();
            p.Didziausias(Skaiciai);

        }

        public new int[] SkaiciuMasyvas()
        {
            Console.WriteLine("kokio dydzio norite skaiciu masyvo?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            var Skaiciai = new int[Kiek];
            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                Skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
            return Skaiciai;
        }

        public void Didziausias(int[] Skaiciai)
        {
            Console.WriteLine(Skaiciai.Max());
        }
    }
}
