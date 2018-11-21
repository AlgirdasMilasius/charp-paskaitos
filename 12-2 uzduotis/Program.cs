using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardai = new List<string>();

            Vardai.Add("Algirdas");
            Vardai.Add("Jonas");
            Vardai.Add("Petras");
            Vardai.Add("Laura");
            Vardai.Add("Justina");

            Console.WriteLine(Vardai[0] + " " + Vardai[1]);

        }
    }
}
