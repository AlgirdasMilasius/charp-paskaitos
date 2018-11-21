using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Alus
    {
        //propg

        public int Laipsniai { get; private set; }
        public double Turis { get; private set; }
        public string  Spalva { get; private set; }
        public string Ipakavimas { get; private set; }
        public double Reitingas { get; private set; }

        public Alus(int laipsniai, double turis, string spalva, string ipakavimas, double reitingas)
        {
            Laipsniai = laipsniai;
            Turis = turis;
            Spalva = spalva;
            Ipakavimas = ipakavimas;
            Reitingas = reitingas;
        }


        public void Isvedimas()
        {
            Console.WriteLine("Alus yra {0} laipsniu stiprumo, {1} spalvos, supakuotas i {2} L {3} ir ivertingas {4} balu",
                Laipsniai, Spalva, Turis, Ipakavimas, Reitingas);
            Console.WriteLine();
        }
    }
}
