using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            var Skaiciai = p.Ivedimas();
            p.RandomPrint(rand, Skaiciai);
        }

        public List<int> Ivedimas()
        {
            var Skaiciai = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                Skaiciai.Add(Convert.ToInt32(Console.ReadLine()));

            }
            return Skaiciai;
        }

        public void RandomPrint(Random rand, List<int> Skaiciai)
        {
            Console.WriteLine(Skaiciai[rand.Next(Skaiciai.Last()-1)]);

        }
    }
}
