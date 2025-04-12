using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i
             wypisujący na ekranie jego wartość.
             */
            int n;
            Console.WriteLine("Podaj numer wyrazu ciągu n:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartość ciągu a(n)=3n-1 wynosi: {0}", 3*n-1);
            Console.ReadKey(true);
        }
    }
}
