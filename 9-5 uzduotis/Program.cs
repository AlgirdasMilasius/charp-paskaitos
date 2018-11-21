using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 0;
            do
            {
                Console.Write("Iveskite skaiciu: ");
                Skaicius = Convert.ToInt32(Console.ReadLine());
                if (Skaicius % 9 ==0)
                {
                    Console.WriteLine("Ivedet skaiciu kuris dalinasi is 9");
                }

            } while (Skaicius % 9 != 0);

        }
    }
}
