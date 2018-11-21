using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testas
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            var Temperaturos = p.Ivestis();

            Console.Write("Suvestos temperatūros: ");
            p.Isvestis(Temperaturos);

            Console.WriteLine("Temperatūrų vidurkis: " + p.Vidurkis(Temperaturos));
            Console.WriteLine("Žemiausia temperatūra: " + p.Zemiausia(Temperaturos));
            Console.WriteLine("{0}-a dieną buvo aukščiausia temperatūra, kuri siekė {1} laipsnius",
                p.Auksciausia(Temperaturos)[0], p.Auksciausia(Temperaturos)[1]);
            //**
            Console.WriteLine("{0} dienas temperatūra buvo žemesnė nei bendras visų dienų temperatūrų vidurkis ", p.Zemesne(Temperaturos, p.Vidurkis(Temperaturos)));
            p.PirmaIrPaskutine(Temperaturos);

            Console.Write("Temperatūros kurios buvo nutolusios nuo vidurkio per 1 laipsnį: ");
            p.Isvestis(p.ArtimosTemperaturos(Temperaturos, p.Vidurkis(Temperaturos)));
        }

        public List<int> Ivestis()
        {
            var Temperaturos = new List<int>();

            Console.WriteLine("Kelių dienų temperatūras norite suvesti?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Kiek; i++)
            {
                Console.WriteLine("Iveskite {0}-os dienos temperatūrą", i + 1);
                Temperaturos.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return Temperaturos;
        }
        public void Isvestis(List<int> Temperaturos)
        {
              foreach (var Temperatura in Temperaturos)
              {
                  Console.Write(Temperatura + ",");
              }
              Console.WriteLine();

        }
        public double Vidurkis(List<int> Temperaturos)
        {

            var Suma = 0;
            foreach (var Temperatura in Temperaturos)
            {
                Suma += Temperatura;
            }

            double Vidurkis = (double) Suma / Temperaturos.Count();

            return Vidurkis;
        }
        public int Zemiausia(List<int> Temperaturos)
        {
            var Min = Temperaturos[0];
            foreach (var Temperatura in Temperaturos)
            {
                if (Temperatura < Min)
                {
                    Min = Temperatura;
                }
            }
            return Min;
        }
        public List<int> Auksciausia (List<int> Temperaturos)
        {
            var Auksciausia = new List<int>();
            var Diena = 1;
            var AuksciausiaTemp = Temperaturos[0];

            for (int i = 0; i < Temperaturos.Count; i++)
            {
                if (Temperaturos[i] > AuksciausiaTemp)
                {
                    AuksciausiaTemp = Temperaturos[i];
                    Diena = i+1;
                }
            }
            Auksciausia.Add(Diena);
            Auksciausia.Add(AuksciausiaTemp);

            return Auksciausia;
        }
        public int Zemesne (List<int> Temperaturos, double Vidurkis)
        {
            var Zemesne = 0;
            foreach (var Temperatura in Temperaturos)
            {
                if (Temperatura < Vidurkis)
                {
                    Zemesne++;
                }
            }

            return Zemesne;
        }
        public void PirmaIrPaskutine(List<int> Temperaturos)
        {
            if (Temperaturos[0] > Temperaturos[Temperaturos.Count-1])
            {
                Console.WriteLine("Pirma diena buvo karštesnė už paskutinė, ir skyrėsi {0} laipsniais", Temperaturos[0]-Temperaturos[Temperaturos.Count-1]);
            }
            else if (Temperaturos[0] == Temperaturos[Temperaturos.Count-1])
            {
                Console.WriteLine("Pirmą ir paskutinę" +
                    " dienomis buvo vienodos temperatūros");
            }
            else
            {
                Console.WriteLine("Paskutinė diena buvo karštesnė už pirmąją, ir skyrėsi {0} laipsniais", Temperaturos[Temperaturos.Count-1]-Temperaturos[0]);
            }

        }
        public List<int> ArtimosTemperaturos(List<int> Temperaturos, double Vidurkis)
        {
            var Artimos = new List<int>();

            foreach (var Temperatura in Temperaturos)
            {
                if (Temperatura <= (Vidurkis+1) && Temperatura >= (Vidurkis-1))
                {
                    Artimos.Add(Temperatura);
                }

            }

            return Artimos;
        }
    }
}
