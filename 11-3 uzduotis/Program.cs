using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Temperatura = new int[2,30];
            Random rand = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Temperatura[i, j] = rand.Next(-10, 15);
                    Console.Write(Temperatura[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(Temperatura.Cast<int>().Average());
            Console.WriteLine(Temperatura.Cast<int>().Max());
            Console.WriteLine(Temperatura.Cast<int>().Min());


        }
    }
}
