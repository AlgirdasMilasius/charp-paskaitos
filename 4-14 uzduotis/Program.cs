using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli");
            var a = Convert.ToChar(Console.Read());
            //Console.ReadLine();

            Console.WriteLine("  " + a + "\n " + a + a + a + "\n " + a + a + a + a + a + "\n  " + a);

        }
    }
}
