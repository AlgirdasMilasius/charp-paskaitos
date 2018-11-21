using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite viena is siu vairiantu:\n1- vanduo \n2-nevanduo\n3-dar kazkas\n4-mirtis");
            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (Pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote nevandeni");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkote dar kazka");
                    break;
                case 4:
                    Console.WriteLine("Pasirinkote mirti :D");
                    break;
                default:
                    Console.WriteLine("KLAIDOS ANFKJDNGFLAMGLAMFLNAFALK");
                    break;
            }

            //Ar pasirinkimas lygus 1 ? Jei taip, išveskite, kad vartotojas pasirinko vandenį.
            //Ar pasirinkimas lygus 2 ? Jei taip, išveskite, kad vartotojas pasirinko limonadą.
            //Ar pasirinkimas lygus 3 ? Jei taip, išveskite, kad vartotojas pasirinko arbatą.
            //Ar pasirinkimas lygus 4 ? Jei taip, išveskite, kad vartotojas pasirinko kavą.
            //Jei pasirinkimas neegzistuoja, išveskite klaidos pranešimą.

        }
    }
}
