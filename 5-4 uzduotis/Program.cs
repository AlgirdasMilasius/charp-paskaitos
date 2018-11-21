using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());


            //Jei skaičius dalinasi iš 5, tuomet išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.
            if (Skaicius % 5 == 0)
            {
                var Daugiklis = 1;
                Console.WriteLine("{0}*{1}=" + (Skaicius * Daugiklis),Skaicius,Daugiklis++);
                Console.WriteLine("{0}*{1}=" + (Skaicius * Daugiklis),Skaicius,Daugiklis++);
                Console.WriteLine("{0}*{1}=" + (Skaicius * Daugiklis),Skaicius,Daugiklis++);
                Console.WriteLine("{0}*{1}=" + (Skaicius * Daugiklis),Skaicius,Daugiklis++);
                Console.WriteLine("{0}*{1}=" + (Skaicius * Daugiklis),Skaicius,Daugiklis++);

            }

            //Jei skaičius lyginis, tuomet išveskite šį skaičių, jo kvadratą ir jį padalintą iš 2.
            if (Skaicius % 2 == 0)
            {
                Console.WriteLine(Skaicius + " " + Math.Pow(Skaicius, 2) + " " + Skaicius / 2);

            }
            //Jei skaičius nesidalina iš 7, tuomet susikurkite antrąjį kintamąjį, išveskite šių dviejų skaičių sumą, skirtumą, sandaugą, dalmenį.
            if (Skaicius % 7 != 0)
            {
                Console.WriteLine("Iveskite dar viena skaiciu");
                var AntrasSkaicius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine((Skaicius + AntrasSkaicius) + " " + (Skaicius - AntrasSkaicius) + " " + (Skaicius * AntrasSkaicius) + " " + (Skaicius / AntrasSkaicius));
            }
        }
    }
}
