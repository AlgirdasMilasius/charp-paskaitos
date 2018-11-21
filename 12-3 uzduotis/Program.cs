using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Markes = new List<string>();

            Markes.Add("BMW");
            Markes.Add("Audi");
            Markes.Add("Mazda");
            Markes.Add("WV");
            foreach (var Marke in Markes)
            {
                Console.Write(Marke + ", ");
            }

            Console.WriteLine();
        }
    }
}
