using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();


            var Pirmas = p.Ivedimas();
            var Antras = p.Ivedimas();

            p.Didesnis(Pirmas, Antras);

        }

        public int Ivedimas()
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());
            return Skaicius;
        }

        public void Didesnis(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("Didesnis " + a);
            }
            else if (a==b)
            {
                Console.WriteLine("Vienodi " + a);
            }
            else
            {
                Console.WriteLine("Didesnis " + b);
            }
        }
    }
}
