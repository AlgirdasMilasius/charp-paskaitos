using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            switch (Pirmas)
            {
                case 1:
                    Console.WriteLine("{0}+{1}+{2}= " + (Pirmas+Antras+Trecias), Pirmas, Antras, Trecias);
                    break;
                case 2:
                    Console.WriteLine("{0}*{1}= " + (Antras*Trecias), Antras, Trecias);
                    break;
                case 3:
                    Console.WriteLine("{0}^2 = " + Math.Pow(Pirmas,2), Pirmas);
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }

            //Ar pirmas skaičius lygus 1 ? Jei taip, išvesti visų trijų skaičių sumą.
            //Ar pirmas skaičius lygus 2 ? Jei taip, išvesti antro ir trečio skaičių sandaugą.
            //Ar pirmas skaičius lygus 3 ? Jei taip, išvesti pirmo skaičiaus kvadratą.
            //Jei nei vienas variantas netinka, išveskite klaidos pranešimą.

        }
    }
}
