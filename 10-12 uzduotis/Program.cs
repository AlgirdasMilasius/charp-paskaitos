using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kilometrai = new[] { 120, 250, 30 };
            var VidGreitis = new[] { 70, 120, 200 };
            var BenzinoKaina = new[] { 1.25, 1.2, 3 };
            double Suma = 0;
            var Trukme = 0;

            Console.WriteLine("Is viso nuvaziuota: " + Kilometrai.Sum());

            for (int i = 0; i < Kilometrai.Length; i++)
            {
                Suma += (Kilometrai[i] * BenzinoKaina[i]/100*7);
            }
            Console.WriteLine("Is viso kelione kainavo: " + Suma );

            for (int i = 0; i < Kilometrai.Length; i++)
            {
                Trukme += (Kilometrai[i] / VidGreitis[i]);
            }
            Console.WriteLine("Is viso kelione uztruko: " + Trukme);



        }
    }
}
