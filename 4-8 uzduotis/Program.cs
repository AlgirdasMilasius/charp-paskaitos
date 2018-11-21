using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kelvinus");
            var Kelvinas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Kelvinas);
            
            Console.WriteLine("Fahrenheitas: " + (double)(9 / 5 * Kelvinas - 459.67));
            Console.WriteLine(9/5);
        }
    }
}
