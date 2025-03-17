using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            c = Convert.ToDouble(Console.ReadLine());
            //najmniejsza liczba
            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza", c);
            //największa liczba
            if ((a >= b) && (a >= c))
                Console.WriteLine("Liczba {0} jest najwięksa", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa", b);
            else
                Console.WriteLine("Liczba {0} jest największa", c);
            Console.ReadKey(true); //pauza
        }
    }
}
