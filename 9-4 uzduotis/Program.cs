using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite zodi arba exit");
            //String Zodis;
            //String Sakinys;

            var Zodis = "";
            var Sakinys = "";

            while (Zodis != "exit")
            {
                Console.Write("Iveskite zodi arba exit: ");
                Zodis = Console.ReadLine();
                if (Zodis != "exit")
                {
                    Sakinys += Zodis + " ";
                }
            }
            Console.WriteLine(Sakinys);
        }
    }
}
