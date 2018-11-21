using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var Skaicius = rand.Next(1,10);
            var Atsakymas = Skaicius;

            //Console.WriteLine(Atsakymas);

            do
            {
                Console.Write("Bandykite atspeti slapta skaiciu [1-10]: ");
                Atsakymas = Convert.ToInt32(Console.ReadLine());
                //kodel su Console.Read() kodas luzta, ir kartoja cikla 3 kartus ? ir nenuskaito arba atsakymo arba skaiciaus kaip vienodo
                if (Skaicius>Atsakymas)
                {
                    Console.WriteLine("Skaicius yra didesnis");
                }
                else if (Skaicius<Atsakymas)
                {
                    Console.WriteLine("Skaicius yra mazesnis");
                }

            } while (Skaicius != Atsakymas);

            Console.WriteLine("Sveikinu atspejus skaiciu :)");
        }
    }
}
