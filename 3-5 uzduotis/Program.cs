using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = 2;
            Double b = 3;

            Console.WriteLine(a + "+" + b + "= " + (a + b));
            Console.WriteLine(a + "-" + b + "= " + (a - b));
            Console.WriteLine(a + "*" + b + "= " + (a * b));
            Console.WriteLine(a + "/" + b + "= " + (a / b));
            Console.WriteLine(a + "%" + b + "= " + (a % b));

            //-1 + 4 * 6
            Console.WriteLine(-1 + 4 * 6);
            //(35 + 5) % 7
            Console.WriteLine((35 + 5) % 7);
            //14 + -4 * 6 / 11
            Console.WriteLine(14 + -4 * 6 / 11);
            //2 + 15 / 6 * 1 - 7 % 2
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //Turite gauti: 23, 5, 12, 3.

            var c = 1;
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));
            Console.WriteLine(a + "*" + c + "=" + (a * c++));

            var x = 68;
            var z = x / 10;
            Console.Write(z);
            Console.Write("+");
            var zc = x % 10;
            Console.Write(zc);
            Console.Write("=");
            Console.Write(z + zc);

        }
    }
}
