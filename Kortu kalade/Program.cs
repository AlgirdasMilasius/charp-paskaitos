using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortu_kalade
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            string[] simboliai = { "P", "Š", "B", "K" };
            string[] skaiciai = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            //Korta korta = new Korta(simboliai[rand.Next(0,4)], skaiciai[rand.Next(0,13)].ToString());
            //Console.WriteLine(korta.Simbolis + " " + korta.Skaicius);

            List<Korta> kalade = new List<Korta>();
            kalade = RecursiveSearchForCards(simboliai, skaiciai, rand, kalade);

            foreach (var item in kalade)
            {
                Console.WriteLine(item.Simbolis + " " + item.Skaicius);
            }
        }
        #region
        /// <summary>
        /// Searchas kodui
        /// </summary>
        /// <param name="simboliai"></param>
        /// <param name="skaiciai"></param>
        /// <param name="rand"></param>
        /// <param name="kalade"></param>
        /// <returns></returns>
        #endregion

        private static List<Korta> RecursiveSearchForCards(string[] simboliai, string[] skaiciai, Random rand, List<Korta> kalade)
        {
            // Korta korta = new Korta(simboliai[rand.Next(0, 4)], rand.Next(1, 14).ToString());
            Korta korta = new Korta(simboliai[rand.Next(0, 4)], skaiciai[rand.Next(0, 13)]);
            bool vienoda = false;

            foreach (var item in kalade)
            {
                if (item.Simbolis == korta.Simbolis && item.Skaicius == korta.Skaicius)
                {
                    vienoda = true;
                    break;
                }
            }
            if (!vienoda)
            {
                kalade.Add(korta);
            }

            if (kalade.Count < 52)
            {
                return RecursiveSearchForCards(simboliai, skaiciai, rand, kalade);
            }
            else
            {
                return kalade;
            }


        }
    }
}

