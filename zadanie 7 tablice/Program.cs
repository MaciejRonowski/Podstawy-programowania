using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
             najmniejszą i największą wczytaną liczbę.
             */
            int[] tab = new int[1000];
            int n, i, min, max;
            Console.Write("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                Console.Write("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = tab[0];
            min = tab[0];
            for (i=1; i<n; i++)
            {
                if (tab[i] < min) min = tab[i];
                if (tab[i] > max) max = tab[i];

            }
            Console.WriteLine("Najmniejsza liczba to: {0}", min);
            Console.WriteLine("Największa liczba to: {0}", max);
            Console.ReadKey(true);
        }
    }
}
