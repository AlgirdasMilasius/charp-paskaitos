using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sarasas = new List<string>() { "Kazkas", "Nezinau", "Nenoriu", "Baik", "asdkasngkang" };
            var p = new Program();

            for (int i = 0; i < 5; i++)
            {
                p.Metodas(Sarasas[i]);
            }


        }
        public void Metodas(string A)
        {
            Console.WriteLine("--" + A + " --");
        }
    }
}
