using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var Sarasas = new List<string> { "string", "kintamasis", "iš", "tiesų", "yra", "char", "masyvas" };

            Console.WriteLine("Kiek norite zodziu parasyti i sarasa?");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            var p = new Program();

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Parasykite zodi");
                Sarasas.Add(Console.ReadLine());
            }

            p.Metodas(Sarasas);
            
        }
        public void Metodas(List<string> SarasasMetodas)
        {
            var max = 0;
            var MaxZodis = "";

            foreach (var Zodis in SarasasMetodas)
            {
                if (Zodis.Length > max)
                {
                    max = Zodis.Length;
                    MaxZodis = Zodis;
                    
                }
                
            }
            Console.WriteLine(MaxZodis);

        }
    }
}
