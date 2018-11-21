using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius > 0)
            {
                Console.WriteLine("Saunu");
            }
            else if (Skaicius == 0)
            {
                Console.WriteLine("Ivedei 0");
            }
            else
            {
                Console.WriteLine("SGDFHWERSFHNFJSDFADSFAFASFJ");
            }
        }
    }
}
