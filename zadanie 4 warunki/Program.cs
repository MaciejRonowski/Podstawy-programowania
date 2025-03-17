using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, min, max;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj czwartą liczbę:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj piątą liczbę:");
            e = Convert.ToDouble(Console.ReadLine());
            //najmniejsza liczba
            min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            if (min > d) min = d;
            if (min > e) min = e;
            //największa liczba
            max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            Console.WriteLine("Liczba {0} jest najmniejsza.", min);
            Console.WriteLine("Liczba {0} jest największa.", max);
            Console.ReadKey(true); //pauza
        }
    }
}
