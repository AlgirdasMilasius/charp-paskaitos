using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigiama skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            while (Skaicius <=0)
            {
                Console.Write(Skaicius + " ");
                Skaicius++;
            }


        }
    }
}
