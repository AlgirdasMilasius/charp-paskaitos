using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());

            //patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją:)
            if (Skaicius < 0)
            {
                Console.WriteLine("ARHAHAFKJALFKKJALKFJALFKJAKFLANFLKANFLAL");
            }

            //patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
            if (Skaicius > 0)
            {
                Console.WriteLine("Good job");
            }
            //patikrinti ar skaičius lyginis;
            if (Skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
            //patikrinti ar skaičius dalinasi iš 4;
            if (Skaicius % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            //patikrinti ar skaičius yra didesnis nei 10.
            if (Skaicius > 10)
            {
                Console.WriteLine("Skaicius yra didesnis nei 10");
            }

        }
    }
}
