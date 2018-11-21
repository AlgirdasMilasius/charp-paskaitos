using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo amziu");
            var Amzius = Convert.ToInt32(Console.ReadLine());

            if (Amzius > 18)
            {
                Console.WriteLine("Galite balsuoti");
            }
            else
            {
                Console.WriteLine("Balsuoti dar negalite");
            }


        }
    }
}
