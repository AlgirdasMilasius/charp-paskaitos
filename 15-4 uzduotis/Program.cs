using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine(p.Ivedimas());

        }
        public string Ivedimas()
        {
            var Sarasas = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite zodi");
                Sarasas[i] = Console.ReadLine();
            }
            var Stringas = "";

            foreach (var item in Sarasas)
            {
                Stringas += item + " ";
            }

            return Stringas;
        }

    }
}
