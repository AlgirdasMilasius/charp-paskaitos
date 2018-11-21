using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            Console.WriteLine("Kiek skaiciu norite sugeneruoti?");
            var atsakymas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koks maziausias skaicius?");
            var atsakymas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koks didziausias skaicius? (iskaitant)");
            var atsakymas2 = Convert.ToInt32(Console.ReadLine());

            p.Kiek(atsakymas,atsakymas1, atsakymas2);

        }

        public void Kiek(int a, int b, int c)
        {
            var rand = new Random();
            var Atsitikriniai = new List<int>();
            for (int i = 0; i < a; i++)
            {
                Atsitikriniai.Add(rand.Next(b, c+1));
            }

            foreach (var item in Atsitikriniai)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
