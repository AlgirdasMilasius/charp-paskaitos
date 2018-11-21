using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardai = new List<string>();

            Console.WriteLine("Kiek norite vardu suvesti?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite varda");
                Vardai.Add(Console.ReadLine());
            }

            Console.WriteLine("Ivedet siuos vardus: ");
            foreach (var Vardas in Vardai)
            {
                Console.WriteLine(Vardas + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Pirmas ivestas vardas: "+Vardai.First());
            Console.WriteLine("Antras ivestas vardas: "+Vardai.Last());


        }
    }
}
