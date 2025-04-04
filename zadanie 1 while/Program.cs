using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while(i<=b)
            {
                if (i%2==0) Console.Write("{0}, ", i);
                i++;
            } //while
            Console.ReadKey(true); //pauza
        }
    }
}
