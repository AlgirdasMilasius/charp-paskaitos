using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            Console.WriteLine("Kiek skaiciu norite sugeneruoti?");
            var atsakymas = Convert.ToInt32(Console.ReadLine());

            p.Kiek(atsakymas);

        }

        public void Kiek(int a)
        {
            var rand = new Random();
            var Atsitikriniai = new List<int>();
            for (int i = 0; i < a; i++)
            {
                Atsitikriniai.Add(rand.Next(100));
            }

            foreach (var item in Atsitikriniai)
            {
                Console.Write(item + " ");
            }
        }
    }
}
