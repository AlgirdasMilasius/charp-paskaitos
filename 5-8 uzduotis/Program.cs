using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pazimi");
            var Pazimys = Convert.ToInt32(Console.ReadLine());

            //Jei pažymys yra lygus 10 išvesti “puiku”.
            //Jei pažymys yra lygus 9 išvesti “labai gerai”.
            //Jei pažymys yra lygus arba didesnis nei 7 išvesti “gerai”.
            //Jei pažymys yra lygus arba didesnis nei 5 išvesti “patenkinamai”.
            //Jei pažymys mažesnis nei 5 išvesti “egzaminas neišlaikytas”.

            if (Pazimys > 10)
            {
                Console.WriteLine("Nemeluok");
            }
            else if (Pazimys == 10)
            {
                Console.WriteLine("Puiku");
            }
            else if (Pazimys == 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (Pazimys >= 7)
            {
                Console.WriteLine("Gerai");
            }
            else if (Pazimys >= 5)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (Pazimys < 5)
            {
                Console.WriteLine("Egzaminas neislaikytas");
            }
        }
    }
}
