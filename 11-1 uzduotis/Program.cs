using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Dvimatis = new int[4, 4]
            {
                {8, 3, 4, 2},
                {1, 3, 7, 6},
                {6, 5, 4, 3},
                {9, 6, 7, 1}
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Iveskite skaiciu i 4x4 matrica");
                    Dvimatis[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Dvimatis[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
