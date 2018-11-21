using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var p = new Program();
            var skaiciai = new int[2] { rand.Next(100), rand.Next(100) };

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item + " ");
            }

            p.Metodas(skaiciai[0], skaiciai[1]);

        }
        public void Metodas(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine(a);
            }
            else if (a==b)
            {
                Console.WriteLine("Skaiciai lygus");
            }
            else
            {
                Console.WriteLine(b);
            }

        }
    }
}
