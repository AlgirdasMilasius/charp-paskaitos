using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Lengva
    {
        public string Pamoka;
        public int Pazymys;
        public bool SuoloDraugas;

        //ctor + TAB sukuria tuscia konstruktoriu
        public Lengva() { }

        public Lengva(string Pamoka, int pazymys, bool suoloDraugas)
        {
            this.Pamoka = Pamoka; // this. rodo klase
            Pazymys = pazymys;
            SuoloDraugas = suoloDraugas;
        }

        public void Nusirasinet()
        {
            if (SuoloDraugas)
            {
                Pazymys++;
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pamoka: " + Pamoka);
            Console.WriteLine("Pazymys: " + Pazymys);
            Console.WriteLine("Suolo draugas: " + SuoloDraugas);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var objektas = new Lengva();
            Lengva objektas2 = new Lengva();

            objektas.Pamoka = "Matke";
            objektas.Pazymys = 9;
            objektas.SuoloDraugas = true;

            objektas2.Pamoka = "Lietuviu";
            objektas2.Pazymys = 6;
            objektas2.SuoloDraugas = false;

            Console.WriteLine("Objektas: ");
            objektas.Isvedimas();
            objektas.Nusirasinet();
            objektas.Isvedimas();

            Console.WriteLine("Objektas2: ");
            objektas2.Isvedimas();
            objektas2.Nusirasinet();
            objektas2.Nusirasinet();
            objektas2.Isvedimas();

            Console.WriteLine("Much hard code... Very WOW");

            var objektas3 = new Lengva("Fizinis", 8, true);
            objektas3.Isvedimas();
            objektas3.Nusirasinet();
            objektas3.Nusirasinet();
            objektas3.Nusirasinet();
            objektas3.Isvedimas();

        }
    }
}
