using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new[] { 3, 5, 2, 33, 5 };

            Console.WriteLine(Skaiciai[0]);
            Console.WriteLine(Skaiciai[1]);
            Console.WriteLine(Skaiciai[Skaiciai.Length-1]);

        }
    }
}
