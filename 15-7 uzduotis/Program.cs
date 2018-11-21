using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_7_uzduotis
{
    class Program
    {
        //Priimtų skaičių masyvą, grąžintų mažiausią rastą skaičių.
        public void PirmaDalis()
        {
            var Skaiciai = Ivestis();
            Console.WriteLine("Maziausias " + Maziausias(Skaiciai));
        }

        //Priimtų skaičių masyvą, grąžintų didžiausią rastą skaičių.
        public void AntraDalis()
        {
            var Skaiciai = Ivestis();
            Console.WriteLine("Didziausias " + Didziausias(Skaiciai));
        }

        //Priimtų skaičių masyvą, grąžintų sumą.
        public void TreciaDalis()
        {
            var Skaiciai = Ivestis();
            Console.WriteLine("Suma " + Suma(Skaiciai));
        }

        //Priimtų sumą ir kiekį, grąžintų vidurkį.
        public void KetvirtaDalis()
        {
            var Skaiciai = Ivestis();
            Console.WriteLine("Vidurkis " + Vidurkis(Suma(Skaiciai), Skaiciai.Length));
        }

        //Priimtų skaičių masyvą, iškviestų visus ankstesnius metodus, išvedant visus papildomus tekstus, 
        //kurie apibūdintų atliktus skaičiavimus ir gautus rezultatus..
        public void PenktaDalis()
        {
            var Skaiciai = Ivestis();
            Console.WriteLine("Maziausias " + Maziausias(Skaiciai));
            Console.WriteLine("Didziausias " + Didziausias(Skaiciai));
            Console.WriteLine("Suma " + Suma(Skaiciai));
            Console.WriteLine("Vidurkis " + Vidurkis(Suma(Skaiciai), Skaiciai.Length));

        }

        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            //p.PirmaDalis();
            //p.AntraDalis();
            //p.TreciaDalis();
            //p.KetvirtaDalis();
            p.PenktaDalis();
            
            
        }

        public new int[] Ivestis()
        {
            Console.WriteLine("Kiek norite skaiciu masyve?");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            var Skaiciai = new int[Kiek];

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                Skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            return Skaiciai;
        }

        public int Maziausias(int[] Skaiciai)
        {
            var Maziausias = Skaiciai.Min();
            return Maziausias;
        }

        public int Didziausias(int[] Skaiciai)
        {
            var Didziausias = Skaiciai.Max();
            return Didziausias;
        }

        public int Suma(int[] Skaiciai)
        {
            var Suma = 0;
            foreach (var item in Skaiciai)
            {
                Suma += item;
            }
            return Suma;
        }

        public double Vidurkis(int Suma, int Kiekis)
        {
            var Vidurkis = Suma / Kiekis;
            return Vidurkis;
        }
    }
}
