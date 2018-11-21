using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var p = new Program();
            var Pirmas = rand.Next(100);
            var Antras = rand.Next(100);

            p.Sudetis(Pirmas, Antras);

            Console.WriteLine("Ar norite pakeisti skaicius? t/n");
            var atsakymas = Console.ReadLine();
            if (atsakymas == "t")
            {
                Pirmas = rand.Next(100);
                Antras = rand.Next(100);
            }

            p.Atimtis(Pirmas, Antras);

            Console.WriteLine("Ar norite pakeisti skaicius? t/n");
            atsakymas = Console.ReadLine();
            if (atsakymas == "t")
            {
                Pirmas = rand.Next(100);
                Antras = rand.Next(100);
            }

            p.Sandauga(Pirmas, Antras);

            Console.WriteLine("Ar norite pakeisti skaicius? t/n");
            atsakymas = Console.ReadLine();
            if (atsakymas == "t")
            {
                Pirmas = rand.Next(100);
                Antras = rand.Next(100);
            }

            p.Dalmuo(Pirmas, Antras);

        }

        public void Sudetis(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
        }
        public void Atimtis(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void Sandauga(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public void Dalmuo(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        public void Keisti()
        {

        }
    }
}
