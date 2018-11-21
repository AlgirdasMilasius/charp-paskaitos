using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaiciuotuvas");
            var Testi = "t";

            do
            {
                Console.WriteLine("Iveskite pirma skaiciu");
                var Pirmas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iveskite veiksma (+ - * /)");
                var Veiksmas = Console.ReadLine();

                Console.WriteLine("Iveskite antra skaiciu");
                var Antras = Convert.ToInt32(Console.ReadLine());

                var Rezultatas = 0;
                switch (Veiksmas)
                {
                    case "+":
                        Rezultatas = Pirmas + Antras;
                        break;
                    case "-":
                        Rezultatas = Pirmas - Antras;
                        break;
                    case "*":
                        Rezultatas = Pirmas * Antras;
                        break;
                    case "/":
                        Rezultatas = Pirmas / Antras;
                        break;
                    default:
                        Console.WriteLine("Ivyko klaida bandykite dar karta");
                        continue;
                }

                Console.WriteLine("{0} {1} {2} = {3}", Pirmas, Veiksmas, Antras, Rezultatas);


                Console.WriteLine("Ar norite testi? t/n");
                Testi = Console.ReadLine();
            } while (Testi == "t");


        }
    }
}
