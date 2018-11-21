using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var Sarasas = new List<string> { "string", "kintamasis", "iš", "tiesų", "yra", "char", "masyvas" };
            var min = 99;
            var MinZodis = "";
            var max = 0;
            var MaxZodis = "";

            foreach (var Zodis in Sarasas)
            {
                if (Zodis.Length < min)
                {
                    min = Zodis.Length;
                    MinZodis = Zodis;
                }
                if (Zodis.Length > max)
                {
                    max = Zodis.Length;
                    MaxZodis = Zodis;
                }


            }
            Console.WriteLine(MinZodis + " " + MinZodis.Length);
            Console.WriteLine(MaxZodis + " " + MaxZodis.Length);

        }
    }
}
