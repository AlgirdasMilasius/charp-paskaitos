using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            var Vardas = Console.ReadLine();

            Console.WriteLine("Iveskite amziu");
            var Amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Vardas + " " + Amzius);
        }
    }
}
