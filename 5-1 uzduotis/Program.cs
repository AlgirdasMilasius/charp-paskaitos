using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            //Ar pirmas ir antras skaičiai yra lygūs?
            if (Pirmas == Antras)
            {
                Console.WriteLine("Pirmas ir antras skaiciai vienodi");
            }
            else
            {
                Console.WriteLine("Pirmas ir antras skaiciai nera vienodi");
            }
            //Ar antras ir trečias skaičiai yra lygūs?
            if (Antras == Trecias)
            {
                Console.WriteLine("Antras ir trecias skaiciai vienodi");
            }
            else
            {
                Console.WriteLine("Antras ir trecias skaiciai nera vienodi");
            }
            //Ar pirmas skaičius yra didesnis už antrąjį?
            if (Pirmas > Antras)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            else
            {
                Console.WriteLine("Pirmas skaicius nera didesnis uz antra");
            }
            //Ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę (trečias skaičius padaugintas iš 2)?
            if (Antras > (Trecias*2))
            {
                Console.WriteLine("Antras skaicius yra daugiau nei dvigubai didesnis uz treciaji");
            }
            else
            {
                Console.WriteLine("Antras skaicius nera dvigubai didesnis nei treciasis skaicius");
            }
            //Ar pirmas skaičius yra lyginis (ar dalinasi iš 2)?
            if (Pirmas % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 2", Pirmas);
            }
            else
            {
                Console.WriteLine("Skaicius {0} nesidalina is 2", Pirmas);

            }
            //Ar antras skaičius yra nelyginis (ar nesidalina iš 2)?
            if (Antras % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} nesidalina is 2", Antras);
            }
            else
            {
                Console.WriteLine("Skaicius {0} dalinasi is 2", Antras);

            }
            //Ar trečias skaičius yra teigiamas (didesnis už 0)?
            if (Trecias > 0)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz 0", Trecias);
            }
            else if (Trecias == 0)
            {
                Console.WriteLine("Skaicius {0} yra lygus 0", Trecias);
            }
            else
            {
                Console.WriteLine("Skaicius {0} yra mazesnis uz 0", Trecias);

            }
            //Ar pirmas skaičius yra neigiamas (mažesnis už 0)?
            if (Pirmas < 0)
            {
                Console.WriteLine("Skaicius {0} yra neigiamas", Pirmas);
            }
            else if (Trecias == 0)
            {
                Console.WriteLine("Skaicius {0} yra lygus 0", Pirmas);
            }
            else
            {
                Console.WriteLine("Skaicius {0} yra teigiamas", Pirmas);
            }
            //Ar antras skaičius dalinasi iš 4?
            if (Antras % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 4", Antras);
            }
            else
            {
                Console.WriteLine("Skaicius {0} nesidalina is 4", Antras);
            }
            //Ar trečias skaičius dalinasi iš 8?
            if (Trecias % 8 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 8", Trecias);
            }
            else
            {
                Console.WriteLine("Skaicius {0} nesidalina is 8", Trecias);
            }

        }
    }
}
