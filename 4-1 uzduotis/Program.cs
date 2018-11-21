using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tekstas = Console.ReadLine();
            Console.WriteLine("{0} {0}", Tekstas);
            Console.WriteLine();

            var Simbolis = Console.Read(); // nuskaito simboli ir i ALT / ASCII koda pavercia
            Console.WriteLine(Simbolis);

        }
    }
}
