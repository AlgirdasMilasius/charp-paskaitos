using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Dvimatis = new int[2, 10];


            Random rand = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Dvimatis[i, j] = rand.Next(1, 10);

                }
            }

            var Suma = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(Dvimatis[i,j] + " ");
                    Suma += Dvimatis[i, j];
                }
                Console.WriteLine(" Suma: "+ Suma);
                Suma = 0;

            }

        }
    }
}
