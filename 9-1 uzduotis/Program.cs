using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            while (Skaicius >0)
            {
                Console.WriteLine(Skaicius);
                Skaicius--;
            }


        }
    }
}
