using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Iveskite Varda");
                var Vardas = Console.ReadLine();
                Console.WriteLine("Iveskite Pavarde");
                var Pavarde = Console.ReadLine();
                Console.WriteLine("Iveskite Amziu");
                var Amzius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite Specialybe");
                var Specialybe = Console.ReadLine();

                p.Metodas(Vardas, Pavarde, Amzius, Specialybe);
            }

        }
        public void Metodas(string Vardas, string Pavarde, int Amzius, string Specialybe)
        {
            Console.WriteLine("Tavo vardas " + Vardas + " " + Pavarde + " tau yra " + Amzius + " ir dirbi " + Specialybe);
        }
    }
}
