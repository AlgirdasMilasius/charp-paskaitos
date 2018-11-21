using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pazymiai = new List<int>();

            Console.WriteLine("Kiek norite ivesti pazymiu?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite pazymi");
                Pazymiai.Add(Convert.ToInt32(Console.ReadLine()));

            }
            Console.WriteLine();

            Console.WriteLine("MAX: " + Pazymiai.Max());
            Console.WriteLine("MIN: " +Pazymiai.Min());
            Console.WriteLine("AVG: " + Pazymiai.Average());
            var Rand = new Random();
            Console.WriteLine("Random: " + Pazymiai[Rand.Next(Pazymiai.Count())]);

            var desimtukai = 0;
            foreach (var desimt in Pazymiai)
            {
                if (desimt == 10)
                {
                    desimtukai++;
                }
            }
            Console.WriteLine("Kiek desimtuku: "+ desimtukai);
            var neigiami = 0;
            foreach (var neigt in Pazymiai)
            {
                if (neigt < 4)
                {
                    neigiami++;
                }
            }
            Console.WriteLine("Neigiamu [0-4): " + neigiami);

        }
    }
}
