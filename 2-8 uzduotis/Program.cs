using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vardas = "Algirdas";
            Console.WriteLine("Mano vardas yra: " + Vardas);

            var Studento_Grupe = "ifzm-6";
            var Vidurkis = 6.53;
            Console.WriteLine("Akademine grupe: " + Studento_Grupe + "\nVidurkis: " + Vidurkis);

            var Zodis = "paskutinis";
            Console.WriteLine(Zodis + Zodis + Zodis + Zodis + Zodis);

            var Skaicius = 5;
            Console.WriteLine(Skaicius + " " + Skaicius + " " + Skaicius + " " + Skaicius + " " + Skaicius);

            var pavadinimas = "suo";
            var amžius = 2; // m.
            var kailio_spalva = "ruda";
            var svoris = 1.4; // kg

            // Gyvūnas - šuo (2 m.) turi rudą kailio spalvą ir sveria 1.4 kg.
            Console.WriteLine("Gyvunas - " + pavadinimas + " (" + amžius + " m. ) turi " 
                + kailio_spalva + " kailio spalva ir sveria " + svoris + " kg.");


        }
    }
}
