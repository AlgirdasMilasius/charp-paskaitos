using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();

            var Vardas = "Algirdas";
            var Pavarde = "Kazkas";
            var Amzius = 26;
            var Alga = 300;
            var Etatas = 0.5;
            var Specializacija = "Policininkas";

            Metodas(Vardas, Pavarde, Amzius, Alga, Etatas, Specializacija);


        }

        public static void Metodas(string Vardas, string Pavarde, int Amzius, int Alga, double Etatas, string X)
        {
            Console.WriteLine(Vardas);
            Console.WriteLine(Pavarde);
            Console.WriteLine(Amzius);
            Console.WriteLine(Alga);
            Console.WriteLine(Etatas);
            Console.WriteLine(X);
        }
    }
}
