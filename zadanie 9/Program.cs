using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów
             wczytanych liczb.
             */
            int a, b, suma;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b= Convert.ToInt32(Console.ReadLine());
            suma = (a * a) + (b * b);
            Console.WriteLine("Suma kwadratów tych liczb wynosi: {0}", suma);
            Console.ReadKey(true);
        }
    }
}
