using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            long Pirmas = 1;
            long Antras = 0 + Pirmas;
            long Trecias = 0;   

            Console.WriteLine("Keliu skaiciu norite fibonacio sekoje");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            if (Skaicius < 0)
            {
                Console.WriteLine("Ivedet neigiama skaiciu!");
            }
            else
            {
                switch (Skaicius)
                {
                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine(Pirmas);
                        break;
                    case 2:
                        Console.WriteLine(Pirmas + " " + Antras);
                        break;
                    default:
                        Console.Write("{0} {1} ", Pirmas, Antras);
                        for (int i = 2; i < Skaicius; i++)
                        {
                            Trecias = Pirmas + Antras;
                            Pirmas = Antras;
                            Antras = Trecias;
                            Console.Write(Trecias + " ");
                        }
                        break;
                }
            }
        }
    }
}
