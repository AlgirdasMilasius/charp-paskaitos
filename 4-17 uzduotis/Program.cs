using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //markė; modelis; gamybos metai; darbinis tūris; rida; ar yra galiojanti techninė apžiūra
            var Marke = "Marke";
            var Modelis = "Modelis";
            var GamybosMetai = "Gamybos metai";
            var DarbinisTuris = "Darb. turis";
            var Rida = "Rida";
            var Technikine = "Technik. apziura";

            Console.WriteLine("Iveskite markė; modelis; gamybos metai; darbinis tūris; rida; ar yra galiojanti techninė apžiūra");
            var Marke1 = Console.ReadLine();
            var Modelis1 = Console.ReadLine();
            var GamybosMetai1 = Convert.ToInt32(Console.ReadLine());
            var DarbinisTuris1 = Convert.ToDouble(Console.ReadLine());
            var Rida1 = Convert.ToInt32(Console.ReadLine());
            var Technikine1 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Iveskite antrai masinai markė; modelis; gamybos metai; darbinis tūris; rida; ar yra galiojanti techninė apžiūra");
            var Marke2 = Console.ReadLine();
            var Modelis2 = Console.ReadLine();
            var GamybosMetai2 = Convert.ToInt32(Console.ReadLine());
            var DarbinisTuris2 = Convert.ToDouble(Console.ReadLine());
            var Rida2 = Convert.ToInt32(Console.ReadLine());
            var Technikine2 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("| {0,7} | {1,7} | {2,10} | {3,12} | {4,7} | {5,12} |", Marke, Modelis, GamybosMetai, DarbinisTuris, Rida, Technikine);
            Console.WriteLine("| {0,7} | {1,7} | {2,10} | {3,12} | {4,7} | {5,12} |", Marke1, Modelis1, GamybosMetai1, DarbinisTuris1, Rida1, Technikine1);
            Console.WriteLine("| {0,7} | {1,7} | {2,10} | {3,12} | {4,7} | {5,12} |", Marke2, Modelis2, GamybosMetai2, DarbinisTuris2, Rida2, Technikine2);


        }
    }
}
