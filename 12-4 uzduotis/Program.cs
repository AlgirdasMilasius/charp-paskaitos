using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                Skaiciai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var Skaicius in Skaiciai)
            {
                Console.Write(Skaicius + " ");
            }


        }
    }
}
