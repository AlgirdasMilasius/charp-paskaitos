using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roles: vartotojas, moderatorius, administratorius");
            Console.WriteLine("Iveskite turima role:");
            var Role = Console.ReadLine();

            switch (Role)
            {
                case "vartotojas":
                    Console.WriteLine("Pasirinkta role - vartotojas");
                    break;
                case "moderatorius":
                    Console.WriteLine("Pasirinkta role - moderatorius");
                    break;
                case "administratorius":
                    Console.WriteLine("Pasirinkta role administratorius");
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }
            //Ar rolė yra “vartotojas”?
            //Ar rolė yra “moderatorius”?
            //Ar rolė yra “administratorius”?
            //Jei nei vienas pasirinkimas netinka, išveskite klaidos pranešimą.

        }
    }
}
