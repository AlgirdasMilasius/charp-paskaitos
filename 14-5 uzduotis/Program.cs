using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Bendras();
            p.Bendras();


        }
        public void Informacija(string Vardas, string Pavarde, string Grupe)
        {
            Console.WriteLine("{0} {1} {2}", Vardas, Pavarde, Grupe);
        }

        public void Ivertinimas(int a, int b, int c)
        {
            Console.WriteLine("Pazymiai: {0} {1} {2} Vidurkis: {3}", a, b, c, (a+b+c)/3);
        }

        public void Bendras()
        {
            Console.WriteLine("Iveskite studento Varda");
            var Vardas = Console.ReadLine();
            Console.WriteLine("Iveskite studento Pavarde");
            var Pavarde = Console.ReadLine();
            Console.WriteLine("Iveskite studento Studento grupe");
            var Grupe = Console.ReadLine();

            var Pazymiai = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite {0}-aji pazymi", i+1);
                Pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Informacija(Vardas, Pavarde, Grupe);
            Ivertinimas(Pazymiai[0], Pazymiai[1], Pazymiai[2]);

        }
    }
}
