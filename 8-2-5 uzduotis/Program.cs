using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 1;
            var LyginiuSuma = 0;
            var NelyginiuSuma = 0;

            while (Skaicius <= 100)
            {
                if (Skaicius % 2 == 0)
                {
                    LyginiuSuma += Skaicius;
                }
                else if (Skaicius % 2 != 0)
                {

                    NelyginiuSuma += Skaicius;
                }

                Skaicius++;
            }

            Console.WriteLine("Lyginiu skaiciu suma rezyje [1-100]: " + LyginiuSuma);
            Console.WriteLine("Nelyginiu skaiciu suma rezyje [1-100]: " + NelyginiuSuma);
        }
    }
}
